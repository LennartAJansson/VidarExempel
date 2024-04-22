using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Vidar1;


var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddTransient<IService, Service>();

var host = builder.Build();

await host.RunAsync();
