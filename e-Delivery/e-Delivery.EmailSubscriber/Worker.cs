using e_Delivery.Model;
using EasyNetQ;
using MailKit.Security;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Net.Smtp;

namespace e_Delivery.EmailSubscriber
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly string _host;
        private readonly string _username;
        private readonly string _password;
        private readonly string _virtualHost;

        public Worker(ILogger<Worker> logger, IConfiguration configuration)
        {
            _logger = logger;
            _host = Environment.GetEnvironmentVariable("RABBITMQ_HOST") ?? "localhost";
            _username = Environment.GetEnvironmentVariable("RABBITMQ_USERNAME") ?? "guest";
            _password = Environment.GetEnvironmentVariable("RABBITMQ_PASSWORD") ?? "guest";
            _virtualHost = Environment.GetEnvironmentVariable("RABBITMQ_VIRTUALHOST") ?? "/";
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using (var bus = RabbitHutch.CreateBus($"host={_host};virtualHost={_virtualHost};username={_username};password={_password}"))
                    {
                        await bus.PubSub.SubscribeAsync<ApplyMessage>("email_subscriber", message =>
                        {
                            _logger.LogInformation($"Received message for {message.RestaurantOwnerEmail}");
                            // Implement your message handling logic here
                        }, config => config.WithTopic("your_topic"), stoppingToken);

                        _logger.LogInformation("Connected and listening for messages.");
                        await Task.Delay(Timeout.Infinite, stoppingToken);
                    }
                }
                catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
                {
                    _logger.LogInformation("Operation canceled.");
                    break; // Exit the loop if a cancellation is requested
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occurred while subscribing to RabbitMQ.");
                    await Task.Delay(5000, stoppingToken); // Wait before reconnecting
                }
            }
        }

        public override void Dispose()
        {
            base.Dispose();
            // Dispose any other resources if necessary
        }

        private async Task SendEmailAsync(string toEmail, string fromEmail, string confirmationLink)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("e-Delivery", "noreply@e-delivery.com"));
            emailMessage.To.Add(new MailboxAddress("Restaurant Owner", toEmail));
            emailMessage.Subject = "Delivery Person Application";

            var builder = new BodyBuilder();
            builder.HtmlBody = $@"
                <p>Delivery person with email {fromEmail} has applied to your restaurant.</p>
                <p>
                    <a href='{confirmationLink}' style='display: inline-block; padding: 10px 20px; background-color: #007bff; color: #fff; text-decoration: none; border-radius: 4px;'>Confirm Application</a>
                </p>";

            emailMessage.Body = builder.ToMessageBody();

            try
            {
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync("mverifikacija@gmail.com", "qhmjyeiyiuruotrc");
                    await client.SendAsync(emailMessage);
                    await client.DisconnectAsync(true);
                }
                Console.WriteLine($"Email sent successfully to {toEmail}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send email to {toEmail}: {ex.Message}");
            }
        }
    }
}
