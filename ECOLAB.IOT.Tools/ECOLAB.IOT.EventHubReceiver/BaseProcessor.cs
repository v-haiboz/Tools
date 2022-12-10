namespace ECOLAB.IOT.EventHubReceiver
{
    using System;

    internal class BaseProcessor:IDisposable
    {
        protected Thread WorkerThread;
        protected readonly CancellationTokenSource cancellationTokenSource;
        private int WorkThreadTimeout = 2000;
        public BaseProcessor()
        {
            cancellationTokenSource = new CancellationTokenSource();
        }

        public void Start()
        {
            Stop();
            this.WorkerThread = new Thread(async () =>
            {
               await DoWork(this.cancellationTokenSource.Token);
            });
            this.WorkerThread.Start();
        }

        private async Task DoWork(object cancellationTokenObject)
        {
           await OnProcess(cancellationTokenObject);
        }

        protected virtual Task<bool> OnProcess(object cancellationTokenObject)
        {
            return Task.FromResult(false);
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
