namespace ECOLAB.IOT.Tools.Service
{
    using ECOLAB.IOT.Tools.Entity;
    using ECOLAB.IOT.Tools.Privoder;

    public interface IECOLABIOTToolConfigService
    {
        public EventHubConfig GetReceiverEventHubConfig();
        public StorageConfig GetReceiverStorageConfig();
        public EventHubConfig GetSenderEventHubConfig();
        public string GetSenderBody();
    }

    public class ECOLABIOTToolConfigService : IECOLABIOTToolConfigService
    {
        private static ECOLABIOTToolConfigProvider eCOLABIOTToolConfigProvider = new ECOLABIOTToolConfigProvider();
        public EventHubConfig GetReceiverEventHubConfig()
        {
            return eCOLABIOTToolConfigProvider.GetReceiverEventHubConfig();
        }

        public StorageConfig GetReceiverStorageConfig()
        {
            return eCOLABIOTToolConfigProvider.GetReceiverStorageConfig();
        }
        public EventHubConfig GetSenderEventHubConfig()
        {
            return eCOLABIOTToolConfigProvider.GetSenderEventHubConfig();
        }
        public string GetSenderBody()
        {
            return eCOLABIOTToolConfigProvider.GetSenderBody();
        }
    }
}