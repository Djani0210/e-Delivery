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
        private readonly IBus _bus;
        private readonly ILogger<Worker> _logger;

        public Worker(IBus bus, ILogger<Worker> logger)
        {
            _bus = bus;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                await _bus.PubSub.SubscribeAsync<ApplyMessage>("email_subscriber", async message =>
                {
                    Console.WriteLine($"Received ApplyMessage for restaurantOwnerEmail {message.RestaurantOwnerEmail}");
                    await SendEmailAsync(message.RestaurantOwnerEmail, message.DeliveryPersonEmail, message.ConfirmationLink);
                }, cancellationToken: stoppingToken);
            }
            catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
            {
                // Handle cancellation
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while subscribing to RabbitMQ.");
            }
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
