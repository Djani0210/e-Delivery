using e_Delivery.EmailSubscriber;
using EasyNetQ;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using e_Delivery;

IHost host = Host.CreateDefaultBuilder(args)
   .ConfigureServices((hostContext, services) =>
   {
       // Register the IBus service
       services.AddSingleton<IBus>(sp =>
       {
           var configuration = sp.GetRequiredService<IConfiguration>();
           var host = Environment.GetEnvironmentVariable("RABBITMQ_HOST") ?? "localhost";
           var username = Environment.GetEnvironmentVariable("RABBITMQ_USERNAME") ?? "guest";
           var password = Environment.GetEnvironmentVariable("RABBITMQ_PASSWORD") ?? "guest";
           var virtualHost = Environment.GetEnvironmentVariable("RABBITMQ_VIRTUALHOST") ?? "/";
          
           return RabbitHutch.CreateBus($"host={host};virtualHost={virtualHost};username={username};password={password}");
       });

       services.AddHostedService<Worker>();
   })
   .Build();

await host.RunAsync();
