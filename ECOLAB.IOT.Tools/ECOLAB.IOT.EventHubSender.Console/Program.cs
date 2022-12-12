using CommandLine;
using ECOLAB.IOT.EventHubSender.Console;
using ECOLAB.IOT.EventHubSender.Console.Entity;
using ECOLAB.IOT.EventHubSender.Console.Processor;

internal class Program
{
    static async Task<int> Main(string[] args)
    {
#if DEBUG
        args = new string[] {     @"-c", "1",
                                  @"-s", "0",
                                  @"-t", "10"};
#endif
        return await Parser.Default.ParseArguments<SendEventOption>(args)
          .MapResult(
            (SendEventOption opts) => ReplayDepotEvent(opts),
            errs => Task.FromResult<int>(1));

        Console.ReadKey();
    }

    static async Task<int> ReplayDepotEvent(SendEventOption opts)
    {
        CallerContext.SendEventOption = opts;
        var instance = new EventHubDefaultProcessor();
        instance.Start();
        return await Task.FromResult(1);
    }
}