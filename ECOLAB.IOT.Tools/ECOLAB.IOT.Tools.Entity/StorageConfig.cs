using YamlDotNet.Serialization;

namespace ECOLAB.IOT.Tools.Entity
{
    public class StorageConfig
    {
        [YamlMember(Alias = "blobStorageConnectionString")]
        public string BlobStorageConnectionString { get; set; }
        [YamlMember(Alias = "blobContainerName")]
        public string BlobContainerName { get; set; }
    }
}