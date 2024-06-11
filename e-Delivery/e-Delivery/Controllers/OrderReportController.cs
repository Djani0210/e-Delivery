using e_Delivery.Database;
using e_Delivery.Model.Report;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace e_Delivery.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderReportController : ControllerBase
    {
        private readonly IOrderReportService _orderReportService;
        public readonly eDeliveryDBContext _dBContext;

        public OrderReportController(eDeliveryDBContext dBContext, IOrderReportService orderReportService)
        {
            _orderReportService = orderReportService;
            _dBContext = dBContext;
        }

        [HttpPost("order-report"), Authorize(Roles = "Desktop")]
        public async Task<IActionResult> GenerateOrderReport()
        {
            try
            {
                byte[] reportData = await _orderReportService.GenerateOrderReportData();

                return File(reportData, "application/pdf", "report.pdf");
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "An error occurred while generating the report: " + ex.Message);
            }
        }
    }
}
