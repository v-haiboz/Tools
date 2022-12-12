﻿namespace ECOLAB.IOT.Tools.Privoder
{
    using ECOLAB.IOT.Tools.Common.Utilities;
    using ECOLAB.IOT.Tools.Entity;
    public interface IECOLABIOTToolConfigProvider
    {
        public EventHubConfig GetReceiverEventHubConfig();
        public StorageConfig GetReceiverStorageConfig();

        public EventHubConfig GetSenderEventHubConfig();

        public string GetSenderBody();

    }

    public class ECOLABIOTToolConfigProvider : IECOLABIOTToolConfigProvider
    {
        public EventHubConfig GetReceiverEventHubConfig()
        {
            return YamlDotNetExtesions.deserializer.Deserialize<EventHubConfig>(File.ReadAllText("EventHubReceiver/eventhubconfig.yaml"));
        }

        public StorageConfig GetReceiverStorageConfig()
        {
            return YamlDotNetExtesions.deserializer.Deserialize<StorageConfig>(File.ReadAllText("EventHubReceiver/storageconfig.yaml"));
        }

        public EventHubConfig GetSenderEventHubConfig()
        {
            return YamlDotNetExtesions.deserializer.Deserialize<EventHubConfig>(File.ReadAllText("EventHubSender/eventhubconfig.yaml"));
        }

        public string GetSenderBody()
        {
            return File.ReadAllText("EventHubSender/body.json");
        }

    }
}