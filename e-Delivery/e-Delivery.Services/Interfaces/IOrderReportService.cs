using e_Delivery.Model.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface IOrderReportService
    {
        public Task<byte[]> GenerateOrderReportData();
    }
}
