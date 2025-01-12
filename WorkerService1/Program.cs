namespace WorkerService1;

public class Program
{
    public static void Main(string[] args)
    {
        //create builder and do some things
        var builder = Host.CreateApplicationBuilder(args);
        builder.Services.AddSystemd();
        builder.Services.AddHostedService<Worker>();

        var host = builder.Build();
        host.Run();
    }
}