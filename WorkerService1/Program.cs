using Chetch.Services;

namespace WorkerService1;

public class Program
{
    public static void Main(string[] args)
    {
        Service<Worker>.Run(args);
    }
}