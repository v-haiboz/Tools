namespace ECOLAB.IOT.Tools.Common.Utilities
{
    using YamlDotNet.Serialization;
    using YamlDotNet.Serialization.NamingConventions;

    public class YamlDotNetExtesions
    {
        public static IDeserializer deserializer = new DeserializerBuilder()
                                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                                    .Build();

        public static ISerializer serializer = new SerializerBuilder()
                                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                                    .Build();

    }
}
