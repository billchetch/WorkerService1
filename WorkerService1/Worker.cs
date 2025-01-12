namespace WorkerService1;

using System.Threading;
using System.Threading.Tasks;
using Chetch.Services;

public class Worker : Service<Worker>
{

    public Worker(ILogger<Worker> logger) : base(logger){}

    /*protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            }
            await Task.Delay(1000, stoppingToken);
        }
    }*/

    System.Timers.Timer _timer = new System.Timers.Timer();

    protected override Task Execute(CancellationToken stoppingToken)
    {
        _timer.Interval = 2000;
        _timer.Elapsed += (sender, eargs) =>{
            Logger.LogInformation(10, "yep fired");
        };
        _timer.Start();
        return Task.Delay(1000);
    }
}
