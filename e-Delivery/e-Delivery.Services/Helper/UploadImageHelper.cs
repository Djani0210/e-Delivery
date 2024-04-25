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
        // Assuming 'Uploads/Images' directory exists at the project root level where Program.cs is.
        private static readonly string BasePath = "Uploads/Images";

        public static string UploadFile(IFormFile imageFile)
        {
            // Ensure 'imageFile' is not null to avoid exceptions.
            if (imageFile == null) throw new ArgumentNullException(nameof(imageFile));

            var fileName = Guid.NewGuid().ToString() + ".jpg";
            // Use a static path. You need to ensure this path is correct and accessible.
            var filePath = Path.Combine(BasePath, fileName);

            // Saving the file.
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                imageFile.CopyTo(stream);
            }

            // Constructing the relative URL to access the image.
            // Adjust the path format as needed based on how your static files are served.
            string imageUrl = $"/{BasePath}/{fileName}";
            return imageUrl;
        }
    }
}
