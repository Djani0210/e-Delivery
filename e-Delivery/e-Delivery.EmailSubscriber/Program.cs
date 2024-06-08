using e_Delivery.EmailSubscriber;

using EasyNetQ;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddSingleton(RabbitHutch.CreateBus("host=localhost"));
    })
    .Build();

await host.RunAsync();
