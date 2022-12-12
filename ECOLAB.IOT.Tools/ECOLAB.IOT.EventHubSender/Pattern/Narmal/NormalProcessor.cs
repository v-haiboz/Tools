namespace ECOLAB.IOT.EventHubSender.Pattern.Narmal
{
    using Azure.Messaging.EventHubs;
    using Azure.Messaging.EventHubs.Producer;
    using System;
    using System.Threading.Tasks;

    internal class NormalProcessor:IDisposable
    {
        private const int numOfEvents = 1;
        private EventHubProducerClient producerClient;
        private string connetionString;
        private string name;
        private string body;
        private int count;

        public NormalProcessor(string connetionString,string name,string body,int count)
        {
            this.connetionString = connetionString;
            this.name = name;
            this.body = body;
            this.count = count;
            var options = new EventHubProducerClientOptions();
            options.ConnectionOptions.TransportType = EventHubsTransportType.AmqpWebSockets;
            producerClient = new EventHubProducerClient(connetionString, name, options);
        }

        public async Task<bool> Process(int batchNo)
        {
            try
            {
                Console.WriteLine($"=====BatchNO:{batchNo} Send Start.=====");
                for (var c = 1; c <= count; c++)
                {  ///to do: send to eventhub.
                    using EventDataBatch eventBatch = await producerClient.CreateBatchAsync();
                    for (int i = 1; i <= numOfEvents; i++)
                    {
                        if (!eventBatch.TryAdd(new EventData(body)))
                        {
                            // if it is too large for the batch
                            throw new Exception($".Event {i} is too large for the batch and cannot be sent.");
                        }
                    }

                    try
                    {
                        // Use the producer client to send the batch of events to the event hub
                        await producerClient.SendAsync(eventBatch);
                        Console.WriteLine($"              BatchNO: {batchNo},Count {c}.");
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }

                Console.WriteLine($"=====BatchNO:{batchNo} Send Finised.=====");
                return true;
            }
            catch (Exception ex)
            {
            }
            return true;
        }

        public async void Dispose()
        {
            await producerClient.DisposeAsync();
        }
    }
}
