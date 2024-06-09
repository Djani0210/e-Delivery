using e_Delivery.EmailSubscriber;
using EasyNetQ;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using e_Delivery;

IHost host = Host.CreateDefaultBuilder(args)
   .ConfigureAppConfiguration((context, config) =>
   {
       config.AddEnvironmentVariables();
       config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
   })
   .ConfigureServices((hostContext, services) =>
   {
       var configuration = hostContext.Configuration;

       var rabbitMqSettings = new e_Delivery.RabbitMqSettings
       {
           HostName = configuration["RABBITMQ_HOST"] ?? "localhost",
           Port = int.Parse(configuration["RABBITMQ_PORT"] ?? "5672"),
           UserName = configuration["RABBITMQ_USERNAME"] ?? "guest",
           Password = configuration["RABBITMQ_PASSWORD"] ?? "guest",
           VirtualHost = configuration["RABBITMQ_VIRTUALHOST"] ?? "/"
       };

       services.AddSingleton(sp =>
       {
           if (rabbitMqSettings == null)
           {
               throw new InvalidOperationException("RabbitMQ settings are missing in the configuration.");
           }

           return RabbitHutch.CreateBus($"host={rabbitMqSettings.HostName};port={rabbitMqSettings.Port};username={rabbitMqSettings.UserName};password={rabbitMqSettings.Password}");
       });

       services.AddHostedService<Worker>();
   })
   .Build();

await host.RunAsync();
