namespace ECOLAB.IOT.EventHubSender.Console.Processor
{
    using Azure.Messaging.EventHubs;
    using Azure.Messaging.EventHubs.Producer;
    using System;

    public class EventHubSendProcessor
    {
        private const int numOfEvents = 1;
        private EventHubProducerClient producerClient;
        

        public EventHubSendProcessor()
        {
            var options = new EventHubProducerClientOptions();
            options.ConnectionOptions.TransportType = EventHubsTransportType.AmqpWebSockets;
            producerClient = new EventHubProducerClient(CallerContext.SendEventOption.EventHubConnetionString, CallerContext.SendEventOption.EventHubName, options);
        }

        public async Task<bool> Process(Guid processorId)
        {
            try
            {
                ///to do: send to eventhub.
                using EventDataBatch eventBatch = await producerClient.CreateBatchAsync();
                for (int i = 1; i <= numOfEvents; i++)
                {
                    if (!eventBatch.TryAdd(new EventData(CallerContext.SendEventOption.Body)))
                    {
                        // if it is too large for the batch
                        throw new Exception($"ProcessorId {processorId}.Event {i} is too large for the batch and cannot be sent.");
                    }
                }

                try
                {
                    // Use the producer client to send the batch of events to the event hub
                    await producerClient.SendAsync(eventBatch);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

               
                return true;
            }
            catch (Exception ex)
            {
            }
            return true;
        }



        public void Finish()
        {

        }

        public async void Dispose()
        {
            await producerClient.DisposeAsync();
        }
    }
}
