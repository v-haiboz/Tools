namespace ECOLAB.IOT.EventHubSender.Console.Entity
{
    using CommandLine;

    [Verb("PerformanceSendEvent", HelpText = "Performance Send Event Options")]
    public class SendEventOption
    {
        [Option('e', "EventHubConnetionString", Required = false, HelpText = "EventHub Connetion String.", Default = 1000)]
        public string EventHubConnetionString { get; set; }

        [Option('n', "EventHubName", Required = false, HelpText = "EventHub Name.", Default = 20)]
        public string EventHubName { get; set; }

        [Option('c', "ThreadCount", Required = false, HelpText = "Number of threads.", Default = 20)]
        public int ThreadCount { get; set; }

        [Option('s', "SleepTime", Required = false, HelpText = "Interval between requests(second).", Default = 0)]
        public int SleepTime { get; set; }

        [Option('t', "TotalTime", Required = false, HelpText = "Total Time", Default = 1)]
        public int TotalTime { get; set; }
        [Option('b', "Body", Required = false, HelpText = "Quest Body.", Default = 2000)]
        public string Body { get; set; }
    }
}
