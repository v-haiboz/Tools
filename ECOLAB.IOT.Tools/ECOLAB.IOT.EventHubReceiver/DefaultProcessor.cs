namespace ECOLAB.IOT.EventHubReceiver
{
    using ECOLAB.IOT.Tools.Entity;
    using System;
    internal class DefaultProcessor
    {
        private DataDispatcher dataDispatcher;
        private EventHubListener eventHubListener;
        Action<ECOLABStreamContent> sendAction;
        public ManualResetEvent ListenerStopEvent;

        public DefaultProcessor(string connectionString, string eventHubName, string consumerGroup, Action<ECOLABStreamContent> txtReceiveAppend)
        {
            dataDispatcher = new DataDispatcher();
            eventHubListener = new EventHubListener(connectionString, eventHubName, consumerGroup, sendAction);
            this.ListenerStopEvent = new ManualResetEvent(false);
        }

        public void Start()
        {
            this.Stop();
            this.ListenerStopEvent.Reset();
            dataDispatcher.Start();
            eventHubListener.Start();
        }

        public void Stop()
        {
            if (eventHubListener != null)
            {
                using (eventHubListener)
                {
                    eventHubListener.Stop();
                }
            }

            if (dataDispatcher != null)
            {
                using (dataDispatcher)
                {
                    dataDispatcher.Stop();
                }
            }
        }
    }
}
