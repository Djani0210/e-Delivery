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
           var host = Environment.GetEnvironmentVariable("RABBITMQ_HOST") ?? "rabbitmq";
           var username = Environment.GetEnvironmentVariable("RABBITMQ_USERNAME") ?? "guest";
           var password = Environment.GetEnvironmentVariable("RABBITMQ_PASSWORD") ?? "guest";
           var virtualHost = Environment.GetEnvironmentVariable("RABBITMQ_VIRTUALHOST") ?? "/";
           var connectionString = $"host={host};virtualHost={virtualHost};username={username}" +
     $";password={password};requestedHeartbeat=60;timeout=60;publisherConfirms=true;persistentMessages=true;prefetchcount=1";
           return RabbitHutch.CreateBus(connectionString);
           //return RabbitHutch.CreateBus($"host={host};virtualHost={virtualHost};username={username};password={password} requestedHeartbeat = 60, timeout = 60");
       });

       services.AddHostedService<Worker>();
   })
   .Build();

await host.RunAsync();
