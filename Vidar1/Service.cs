using Microsoft.Extensions.Logging;

namespace Vidar1;

public class Service(ILogger<Service> logger) : IService
{
  public Task DoWork()
  {
    logger.LogInformation("Service called at: {time}", DateTimeOffset.Now);
    return Task.CompletedTask;
  }
}