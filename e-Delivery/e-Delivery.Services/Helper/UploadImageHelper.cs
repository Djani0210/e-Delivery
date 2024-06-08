using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Helper
{
    public static class UploadImageHelper
    {
        
        private static readonly string BasePath = "Uploads/Images";

        public static string UploadFile(IFormFile imageFile)
        {
           
            if (imageFile == null) throw new ArgumentNullException(nameof(imageFile));

            var fileName = Guid.NewGuid().ToString() + ".jpg";
           
            var filePath = Path.Combine(BasePath, fileName);

           
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                imageFile.CopyTo(stream);
            }

            
            string imageUrl = $"/{BasePath}/{fileName}";
            return imageUrl;
        }
    }
}
