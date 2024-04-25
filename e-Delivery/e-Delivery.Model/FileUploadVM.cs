using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model
{
    public class FileUploadVM
    {
        public IFormFile  ImageFile { get; set; }
        public bool IsChangingLogo { get; set; }
    }
}
