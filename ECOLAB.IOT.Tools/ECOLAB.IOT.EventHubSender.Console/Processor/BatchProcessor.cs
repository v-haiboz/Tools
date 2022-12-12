namespace ECOLAB.IOT.EventHubSender.Console.Processor
{
    using System;

    public class BatchProcessor: IDisposable
    {
        public Guid ProcessorId { get; private set; }
        private Thread WorkerThread;
        private int WorkThreadTimeout = 2000;
        private readonly EventHubDefaultProcessor eventHubDefaultProcessor;
        private readonly CancellationTokenSource cancellationTokenSource;
        private readonly EventHubSendProcessor senderProcessor;
        private static int count = 0;

        public BatchProcessor(EventHubDefaultProcessor eventHubDefaultProcessor)
        {
            this.eventHubDefaultProcessor = eventHubDefaultProcessor;
            this.cancellationTokenSource = new CancellationTokenSource();
            this.ProcessorId = Guid.NewGuid();
            senderProcessor = new EventHubSendProcessor();

        }

        public void Start()
        {
            this.Stop();
            this.WorkerThread = new Thread(() =>
            {
                DoWork(this.cancellationTokenSource.Token);
            });
            this.WorkerThread.Start();
        }

        public void Stop()
        {
            var thread = this.WorkerThread;
            if (thread != null)
            {
                this.cancellationTokenSource.Cancel();
                if (!thread.Join(WorkThreadTimeout))
                {

                }
                this.WorkerThread = null;
            }
        }

        private void DoWork(object cancellationTokenObject)
        {
            var stopEvent = this.eventHubDefaultProcessor.ListenerStopEvent;
            var cancellatioinToken = (CancellationToken)cancellationTokenObject;
            int waitTime = 0;
            OnProcess(cancellationTokenObject);

            this.eventHubDefaultProcessor.RemoveProcessor(this.ProcessorId);

        }

        private bool OnProcess(object cancellationTokenObject)
        {
            var stopEvent = this.eventHubDefaultProcessor.ListenerStopEvent;
            var cancellationToken = (CancellationToken)cancellationTokenObject;
            var waitTime = 0;
            while ((!cancellationToken.IsCancellationRequested) && (!stopEvent.WaitOne(waitTime)))
            {
                var num=Interlocked.Increment(ref count);
                _ = senderProcessor.Process(ProcessorId).Result;
                Console.WriteLine($"                  ProcessorId {ProcessorId} ->Count: {num}");
            }

            return true;

        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.cancellationTokenSource.Dispose();
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
