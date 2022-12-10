namespace ECOLAB.IOT.EventHubReceiver
{
    using Azure.Messaging.EventHubs;
    using Azure.Messaging.EventHubs.Processor;
    using Azure.Storage.Blobs;
    using global::ECOLAB.IOT.Tools.Entity;
    using global::ECOLAB.IOT.Tools.Service;
    using System;
    using System.Diagnostics;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    internal class EventHubListener:BaseProcessor
    {
        private static ECOLABIOTToolConfigService eCOLABIOTToolConfigService = new ECOLABIOTToolConfigService();
        private static StorageConfig storageConfig = eCOLABIOTToolConfigService.GetReceiverStorageConfig();
        private BlobContainerClient storageClient;
        EventProcessorClient processor;
        string connectionString;
        string eventHubName;
        string consumerGroup;
        Action<ECOLABStreamContent> sendAction;

        public EventHubListener(string connectionString, string eventHubName, string consumerGroup, Action<ECOLABStreamContent> sendAction)
        {
            this.connectionString = connectionString;
            this.eventHubName = eventHubName;
            this.consumerGroup = consumerGroup;
            this.sendAction = sendAction;
        }

        protected override async Task<bool> OnProcess(object cancellationTokenObjec)
        {
            await OnProcess();
            return true;
        }
        private async Task OnProcess()
        {
            var processorOptions = new EventProcessorClientOptions
            {
                LoadBalancingUpdateInterval = TimeSpan.FromSeconds(10),
                PartitionOwnershipExpirationInterval = TimeSpan.FromSeconds(30),
                ConnectionOptions = new EventHubConnectionOptions
                {
                    TransportType = EventHubsTransportType.AmqpWebSockets
                }
            };

            storageClient = new BlobContainerClient(storageConfig.BlobStorageConnectionString, storageConfig.BlobContainerName);
            processor = new EventProcessorClient(storageClient, consumerGroup, connectionString, eventHubName, processorOptions);
            Task processEventHandler(ProcessEventArgs args)
            {
                try
                {
                    if (args.CancellationToken.IsCancellationRequested)
                    {
                        return Task.CompletedTask;
                    }

                    var str = Encoding.UTF8.GetString(args.Data.Body.ToArray());
                    string partition = args.Partition.PartitionId;
                    byte[] eventBody = args.Data.EventBody.ToArray();
                    sendAction(new ECOLABStreamContent(StreamType.Receive, $"\r\nEvent from partition {partition} with length {eventBody.Length}.\r\n{str}", 0));

                }
                catch
                {
                    // It is very important that you always guard against
                    // exceptions in your handler code; the processor does
                    // not have enough understanding of your code to
                    // determine the correct action to take.  Any
                    // exceptions from your handlers go uncaught by
                    // the processor and will NOT be redirected to
                    // the error handler.
                }

                return Task.CompletedTask;
            }

            Task processErrorHandler(ProcessErrorEventArgs args)
            {
                try
                {
                    Debug.WriteLine("Error in the EventProcessorClient");
                    Debug.WriteLine($"\tOperation: {args.Operation}");
                    Debug.WriteLine($"\tException: {args.Exception}");
                    Debug.WriteLine("");
                }
                catch (Exception ex)
                {
                    // It is very important that you always guard against
                    // exceptions in your handler code; the processor does
                    // not have enough understanding of your code to
                    // determine the correct action to take.  Any
                    // exceptions from your handlers go uncaught by
                    // the processor and will NOT be handled in any
                    // way.

                    //Application.HandleErrorException(args, ex);
                }

                return Task.CompletedTask;
            }

            try
            {
                //cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(30));
                processor.ProcessEventAsync += processEventHandler;
                processor.ProcessErrorAsync += processErrorHandler;

                try
                {
                    await processor.StartProcessingAsync(cancellationTokenSource.Token);
                    await Task.Delay(Timeout.Infinite, cancellationTokenSource.Token);
                }
                catch (TaskCanceledException)
                {
                    // This is expected if the cancellation token is
                    // signaled.
                }
                finally
                {
                    // This may take up to the length of time defined
                    // as part of the configured TryTimeout of the processor;
                    // by default, this is 60 seconds.

                    await processor.StopProcessingAsync();
                }
            }
            catch
            {
                // The processor will automatically attempt to recover from any
                // failures, either transient or fatal, and continue processing.
                // Errors in the processor's operation will be surfaced through
                // its error handler.
                //
                // If this block is invoked, then something external to the
                // processor was the source of the exception.
            }
            finally
            {
                // It is encouraged that you unregister your handlers when you have
                // finished using the Event Processor to ensure proper cleanup.  This
                // is especially important when using lambda expressions or handlers
                // in any form that may contain closure scopes or hold other references.

                processor.ProcessEventAsync -= processEventHandler;
                processor.ProcessErrorAsync -= processErrorHandler;
            }
        }
    }
}
