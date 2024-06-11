using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Model.Report;
using e_Delivery.Services.Interfaces;
using iTextSharp.text;
using iTextSharp.text.log;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class OrderReportService : IOrderReportService
    {
        public readonly eDeliveryDBContext _dbContext;
        public IAuthContext _authContext { get; set; }

        private readonly ILogger<OrderReportService> _logger;

        public OrderReportService(eDeliveryDBContext dbContext, IAuthContext authContext, ILogger<OrderReportService> logger)
        {
            _dbContext = dbContext;
            _authContext = authContext;
            _logger = logger;
        }

        public async Task<byte[]> GenerateOrderReportData(OrderReportParameters parameters)
        {


            try
            {
                using (var stream = new MemoryStream())
                {
                    var document = new Document();
                    var writer = PdfWriter.GetInstance(document, stream);
                    document.Open();

                    BaseFont font = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    Font bigFont = new Font(font, 36, Font.BOLD);

                    Paragraph header = new Paragraph("eDelivery", bigFont);
                    header.Alignment = Element.ALIGN_CENTER;
                    document.Add(header);

                    Paragraph title = new Paragraph("Izvještaj za narudžbe generisan: " + DateTime.Now);
                    document.Add(title);

                    PdfPTable table = new PdfPTable(7);
                    table.SpacingBefore = 10;
                    float totalWidth = 1100f;
                    table.TotalWidth = totalWidth;

                    float[] columnWidths = { 25f, 30f, 35f, 30f, 60f, 30f, 50f };
                    table.SetWidths(columnWidths);
                    table.WidthPercentage = 100f;

                    Font boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12f);
                    Font smallerFont = FontFactory.GetFont(FontFactory.HELVETICA, 10f);
                    int cellPadding = 5;

                    PdfPCell header1 = new PdfPCell(new Phrase("ID", boldFont)) { Padding = cellPadding };
                    PdfPCell header2 = new PdfPCell(new Phrase("Kupac", boldFont)) { Padding = cellPadding };
                    PdfPCell header3 = new PdfPCell(new Phrase("Datum narudžbe", boldFont)) { Padding = cellPadding };
                    PdfPCell header4 = new PdfPCell(new Phrase("Ukupna cijena", boldFont)) { Padding = cellPadding };
                    PdfPCell header5 = new PdfPCell(new Phrase("Stavke narudžbe", boldFont)) { Padding = cellPadding };
                    PdfPCell header6 = new PdfPCell(new Phrase("Prilozi", boldFont)) { Padding = cellPadding };
                    PdfPCell header7 = new PdfPCell(new Phrase("Adresa dostave", boldFont)) { Padding = cellPadding };


                    table.AddCell(header1);
                    table.AddCell(header2);
                    table.AddCell(header3);
                    table.AddCell(header4);
                    table.AddCell(header5);
                    table.AddCell(header6);
                    table.AddCell(header7);

                    var loggedUser = await _authContext.GetLoggedUser();

                    IQueryable<Order> ordersQuery = _dbContext.Orders
                        .Include(o => o.CreatedByUser)
                        .Include(o => o.OrderItems)
                        .ThenInclude(oi => oi.FoodItem)
                        .Include(o => o.OrderItems)
                        .ThenInclude(oi => oi.OrderItemSideDishes)
                        .ThenInclude(oisd => oisd.SideDish)
                                    .Where(order => order.RestaurantId == loggedUser.RestaurantId).OrderByDescending(order => order.CreatedDate);


                    if (parameters != null)
                    {
                        if (parameters.FromDate.HasValue && parameters.ToDate.HasValue)
                        {
                            DateTime fromDate = parameters.FromDate.Value.Date;
                            DateTime toDate = parameters.ToDate.Value.Date.AddDays(1);
                            ordersQuery = ordersQuery.Where(o => o.CreatedDate >= fromDate && o.CreatedDate <= toDate);
                        }
                        if (parameters.MinPrice.HasValue)
                        {
                            ordersQuery = ordersQuery.Where(o => o.TotalCost >= parameters.MinPrice.Value);
                        }
                        if (parameters.MaxPrice.HasValue)
                        {
                            ordersQuery = ordersQuery.Where(o => o.TotalCost <= parameters.MaxPrice.Value);
                        }
                    }
                    else
                    {
                        ordersQuery = ordersQuery;
                    }

                    List<Order> orders = await ordersQuery.ToListAsync();

                    foreach (var order in orders)
                    {
                        foreach (var orderItem in order.OrderItems)
                        {
                           
                            foreach (var orderItemSideDish in orderItem.OrderItemSideDishes)
                            {
                                _logger.LogInformation($"OrderItemSideDish ID: {orderItemSideDish.OrderItem?.Id}, " +
                                    $"SideDish ID: {orderItemSideDish.SideDish?.Id}, SideDish Name: {orderItemSideDish.SideDish?.Name}");
                            }
                            orderItem.SideDishes = orderItem.OrderItemSideDishes.Select(ois => ois.SideDish).ToList();
                        }
                    }


                    foreach (Order order in orders)
                    {
                        StringBuilder foodItemText = new StringBuilder();
                        StringBuilder sideDishText = new StringBuilder();


                        foreach (var item in order.OrderItems)
                        {
                            FoodItem foodItem = item.FoodItem;

                            if (foodItem != null)
                            {
                                string foodItemInfo = $"{foodItem.Name}, Qty: {item.Quantity}, Price: {item.Cost} KM ,\n";
                                foodItemText.Append(foodItemInfo);

                                var sideDishes = item.SideDishes?.Select(sd => sd.Name);
                                string sideDishInfo = sideDishes != null ? string.Join(", ", sideDishes) : "";
                                sideDishText.Append(sideDishInfo + "\n");
                            }
                        }

                        PdfPCell orderIdCell = new PdfPCell(new Phrase(order.Id.ToString()));
                        PdfPCell customerCell = new PdfPCell(new Phrase($"{order.CreatedByUser?.FirstName} {order.CreatedByUser?.LastName}"));
                        PdfPCell orderDateCell = new PdfPCell(new Phrase(order.CreatedDate.ToString()));
                        PdfPCell totalPriceCell = new PdfPCell(new Phrase(order.TotalCost.ToString() + " KM"));
                        PdfPCell foodItemCell = new PdfPCell(new Phrase(foodItemText.ToString()));
                        PdfPCell sideDishesCell = new PdfPCell(new Phrase(sideDishText.ToString()));
                        PdfPCell shippingAddressCell = new PdfPCell(new Phrase(order.Address));

                        table.AddCell(orderIdCell);
                        table.AddCell(customerCell);
                        table.AddCell(orderDateCell);
                        table.AddCell(totalPriceCell);
                        table.AddCell(foodItemCell);
                        table.AddCell(sideDishesCell);
                        table.AddCell(shippingAddressCell);
                    }
                    document.Add(table);

                    document.Close();
                    byte[] reportData = stream.ToArray();
                    return reportData;
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while generating the order report.");
                throw;
            }
        }
    }
}
