namespace ECOLAB.IOT.Tools.Entity
{
    using YamlDotNet.Serialization;

    public class EventHubConfig
    {
        [YamlMember(Alias = "connectionString")]
        public string ConnectionString { get; set; }
        [YamlMember(Alias = "eventHubName")]
        public string EventHubName { get; set; }
        [YamlMember(Alias = "consumerGroup")]
        public string ConsumerGroup { get; set; }
    }
}