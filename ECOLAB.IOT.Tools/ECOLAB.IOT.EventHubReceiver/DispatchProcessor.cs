namespace ECOLAB.IOT.EventHubReceiver
{
    using global::ECOLAB.IOT.Tools.Entity;
    using System;
    using System.Collections.Concurrent;
    using System.Text;
    internal class DispatchProcessor: BaseProcessor
    {
        private ConcurrentQueue<ECOLABStreamContent> dataDispQueue = new ConcurrentQueue<ECOLABStreamContent>();

        public delegate void TextBoxAppendDel(Color color, string str);
        public void Receive(ECOLABStreamContent streamContent)
        {
            if (streamContent != null)
                dataDispQueue.Enqueue(streamContent);
        }

        protected async override Task<bool> OnProcess(object cancellationTokenObject)
        {
            var cancellationToken = (CancellationToken)cancellationTokenObject;
            
            DateTime lastUpdateTime = DateTime.Now;
            StreamType lastUpdateType = StreamType.Receive;
            StringBuilder rxStrBuff = new StringBuilder();
            StringBuilder txStrBuff = new StringBuilder();
            Color color = Color.AliceBlue;
            while ((!cancellationToken.IsCancellationRequested))
            {
                ECOLABStreamContent content = null;
                bool isSuccessful = false;
                if (dataDispQueue.Count > 0)
                {
                    isSuccessful = dataDispQueue.TryDequeue(result: out content);
                }
                else
                {
                    Thread.Sleep(1000);
                }

                if (isSuccessful && content != null)
                {
                    switch (content.Type)
                    {
                        case StreamType.Receive:
                             Console.WriteLine($"{content.Content}");
                            break;
                        default:
                            break;
                    }
                    lastUpdateType = content.Type;
                }
            }

            dataDispQueue.Clear();
            return await Task.FromResult(true);
            
        }
    }
}
