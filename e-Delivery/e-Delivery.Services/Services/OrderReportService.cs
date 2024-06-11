using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using System.Linq;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Services.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace e_Delivery.Services.Services
{
    public class OrderReportService : IOrderReportService
    {
        private readonly eDeliveryDBContext _dbContext;
        private readonly IAuthContext _authContext;
        private readonly ILogger<OrderReportService> _logger;

        public OrderReportService(eDeliveryDBContext dbContext, IAuthContext authContext, ILogger<OrderReportService> logger)
        {
            _dbContext = dbContext;
            _authContext = authContext;
            _logger = logger;
        }

        public async Task<byte[]> GenerateOrderReportData()
        {
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();

                var orders = await _dbContext.Orders
                    .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.FoodItem)
                    .Where(order => order.RestaurantId == loggedUser.RestaurantId)
                    .OrderByDescending(order => order.CreatedDate)
                    .ToListAsync();

                using (MemoryStream ms = new MemoryStream())
                {
                    PdfWriter writer = new PdfWriter(ms);
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf, PageSize.A4);

                    // Add title
                    document.Add(new Paragraph("eDelivery Order Report")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(20)
                        .SetBold());

                    // Add date
                    document.Add(new Paragraph($"Generated on: {DateTime.Now}")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(12));

                    // Most ordered food items
                    AddMostOrderedFoodItems(document, orders);

                    // Monthly earnings
                    AddMonthlyEarnings(document, orders);

                    document.Close();
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while generating the order report.");
                throw;
            }
        }

        private void AddMostOrderedFoodItems(Document document, List<Order> orders)
        {
            var foodItemCounts = orders.SelectMany(o => o.OrderItems)
                .GroupBy(oi => oi.FoodItem.Name)
                .Select(g => new { FoodItem = g.Key, Count = g.Sum(oi => oi.Quantity) })
                .OrderByDescending(x => x.Count)
                .Take(10)
                .ToList();

            document.Add(new Paragraph("Top 10 Most Ordered Food Items")
                .SetBold()
                .SetFontSize(14)
                .SetTextAlignment(TextAlignment.CENTER));

            Table table = new Table(2).UseAllAvailableWidth();
            table.AddCell(new Cell().Add(new Paragraph("Food Item").SetBold()));
            table.AddCell(new Cell().Add(new Paragraph("Order Count").SetBold()));

            foreach (var item in foodItemCounts)
            {
                table.AddCell(new Cell().Add(new Paragraph(item.FoodItem)));
                table.AddCell(new Cell().Add(new Paragraph(item.Count.ToString())));
            }

            document.Add(table);
        }

        private void AddMonthlyEarnings(Document document, List<Order> orders)
        {
            var monthlyEarnings = orders
                .GroupBy(o => new { o.CreatedDate.Year, o.CreatedDate.Month })
                .Select(g => new
                {
                    Date = new DateTime(g.Key.Year, g.Key.Month, 1),
                    Earnings = g.Sum(o => o.TotalCost)
                })
                .OrderBy(x => x.Date)
                .Take(12)
                .ToList();

            document.Add(new Paragraph("Monthly Earnings (Last 12 Months)")
                .SetBold()
                .SetFontSize(14)
                .SetTextAlignment(TextAlignment.CENTER));

            Table table = new Table(2).UseAllAvailableWidth();
            table.AddCell(new Cell().Add(new Paragraph("Month").SetBold()));
            table.AddCell(new Cell().Add(new Paragraph("Earnings").SetBold()));

            foreach (var item in monthlyEarnings)
            {
                table.AddCell(new Cell().Add(new Paragraph(item.Date.ToString("MMM yyyy"))));
                table.AddCell(new Cell().Add(new Paragraph(item.Earnings.ToString() + " KM")));
            }

            document.Add(table);
        }
    }
}
