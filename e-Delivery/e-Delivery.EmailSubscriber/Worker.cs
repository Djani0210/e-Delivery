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
        private readonly IBus _bus;

        public Worker(ILogger<Worker> logger, IBus bus)
        {
            _logger = logger;
            _bus = bus;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await ConnectToRabbitMQWithRetry(stoppingToken);
                    _logger.LogInformation("Connected and listening for messages.");
                    await Task.Delay(Timeout.Infinite, stoppingToken);
                }
                catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
                {
                    _logger.LogInformation("Operation canceled.");
                    break;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occurred while subscribing to RabbitMQ.");
                    await Task.Delay(5000, stoppingToken);
                }
            }
        }

        private async Task ConnectToRabbitMQWithRetry(CancellationToken stoppingToken)
        {
            int retryCount = 0;
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    await _bus.PubSub.SubscribeAsync<ApplyMessage>("email_subscriber", async message =>
                    {
                        _logger.LogInformation($"Received message for {message.RestaurantOwnerEmail}");
                        await SendEmailAsync(message.RestaurantOwnerEmail, message.DeliveryPersonEmail, message.ConfirmationLink);
                    }, cancellationToken: stoppingToken);
                    return;
                }
                catch (Exception ex)
                {
                    retryCount++;
                    _logger.LogWarning($"Failed to connect to RabbitMQ. Retry attempt {retryCount}. Error: {ex.Message}");
                    await Task.Delay(5000, stoppingToken);
                }
            }
        }

        public override void Dispose()
        {
            base.Dispose();
           
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
                Console.WriteLine($"Email sent  successfully to {toEmail}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send email to {toEmail}: {ex.Message}");
            }
        }
    }
}
