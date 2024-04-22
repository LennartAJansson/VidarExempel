using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Vidar1;
public class Worker(ILogger<Worker> logger, IService service) : IHostedService
{
  public Task StartAsync(CancellationToken cancellationToken)
  {
    logger.LogInformation("Worker starting at: {time}", DateTimeOffset.Now);
    service.DoWork();
    return Task.CompletedTask;
  }

  public Task StopAsync(CancellationToken cancellationToken)
  {
    logger.LogInformation("Worker stopping at: {time}", DateTimeOffset.Now);
    return Task.CompletedTask;
  }
}
