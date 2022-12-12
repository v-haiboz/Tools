namespace ECOLAB.IOT.EventHubSender.Console.Processor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EventHubDefaultProcessor
    { /// <summary>
      /// quit event
      /// </summary>
        public ManualResetEvent ListenerStopEvent;

        private IDictionary<Guid, BatchProcessor> processorCollection;

        private ReaderWriterLockSlim processorCollectionLock;

        private int processorCheckInterval = 3000;

        private DateTime expectedCompletionTime;

        private Action<bool> completedEvent;
        /// <summary>
        /// status work thread
        /// </summary>
        private Thread StatusCheckWorkerThread;

        public EventHubDefaultProcessor(Action<bool> completedEvent= null)
        {
            this.completedEvent = completedEvent;
            this.ListenerStopEvent = new ManualResetEvent(false);
            this.processorCollection = new Dictionary<Guid, BatchProcessor>();
            this.processorCollectionLock = new ReaderWriterLockSlim();
            expectedCompletionTime = DateTime.Now.AddMinutes(CallerContext.SendEventOption.TotalTime);
        }

        public void Start()
        {
            this.Stop();
            this.ListenerStopEvent.Reset();
            Console.WriteLine($"=====Advance Pattern Send Start TotalTime:{CallerContext.SendEventOption.TotalTime} ThreadCount:{CallerContext.SendEventOption.ThreadCount} SleepTime:{CallerContext.SendEventOption.SleepTime}=====");
            var processorCount = CallerContext.SendEventOption.ThreadCount;
            this.processorCollectionLock.EnterWriteLock();
            try
            {
                AddThreads(processorCount);
            }
            finally
            {
                this.processorCollectionLock.ExitWriteLock();
            }

            this.StatusCheckWorkerThread = new Thread(OnCheckProcessorStatus);
            this.StatusCheckWorkerThread.Start();
        }

        private void AddThreads(int maxThreadCount)
        {
            while (this.processorCollection.Count < maxThreadCount)
            {
                var processor = new BatchProcessor(this);
                this.processorCollection.Add(processor.ProcessorId, processor);
                processor.Start();
            }
        }

        public void Stop()
        {
            this.ListenerStopEvent.Set();

            var rwLock = this.processorCollectionLock;
            BatchProcessor processor = null;

            do
            {
                rwLock.EnterReadLock();
                try
                {
                    if (this.processorCollection != null)
                    {
                        processor = this.processorCollection.Values.FirstOrDefault();
                    }
                    else
                    {
                        processor = null;
                    }
                }
                finally
                {
                    rwLock.ExitReadLock();
                }

                if (processor != null)
                {
                    using (processor)
                    {
                        processor.Stop();
                        RemoveProcessor(processor.ProcessorId);
                    }
                }

            } while (processor != null);
        }


        /// <summary>
        /// work thread to monitor processors.
        /// </summary>
        /// <remarks>
        /// if thread is timeout, it will kill it. if number of current processors is lower than max number of processors,
        /// it will add new processors
        /// </remarks>
        private void OnCheckProcessorStatus()
        {
            do
            {
                try
                {
                    Queue<BatchProcessor> timeoutProcessors = null;
                    var rwLock = this.processorCollectionLock;
                    if (rwLock != null && DateTime.Now > expectedCompletionTime)
                    {
                        this.ListenerStopEvent.Set();
                        rwLock.EnterUpgradeableReadLock();
                        try
                        {
                            //Check and remove timeout threads
                            var now = DateTime.Now;
                            foreach (var processor in this.processorCollection.Values)
                            {
                                if (timeoutProcessors == null)
                                {
                                    timeoutProcessors = new Queue<BatchProcessor>();
                                }
                                timeoutProcessors.Enqueue(processor);
                            }

                            if (timeoutProcessors != null)
                            {
                                rwLock.EnterWriteLock();
                                try
                                {
                                    var i = 0;
                                    while (timeoutProcessors.Count > 0)
                                    {
                                        i++;
                                        var processor = timeoutProcessors.Dequeue();
                                        processor.Stop();
                                        this.processorCollection.Remove(processor.ProcessorId);
                                    }
                                }
                                finally
                                {
                                    rwLock.ExitWriteLock();
                                }
                            }
                        }
                        finally
                        {
                            rwLock.ExitUpgradeableReadLock();
                            Console.WriteLine($"=====Advance Pattern Send Finished =====");
                            if (completedEvent !=null)
                            {
                                completedEvent.Invoke(true);
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                }
            } while (!this.ListenerStopEvent.WaitOne(processorCheckInterval));
        }

        public bool RemoveProcessor(Guid proceesorId)
        {
            bool removed;
            this.processorCollectionLock.EnterWriteLock();
            try
            {
                removed = this.processorCollection.Remove(proceesorId);
            }
            finally
            {
                this.processorCollectionLock.ExitWriteLock();
            }

            return removed;
        }
    }
}
