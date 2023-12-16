using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.FoodItem
{
    public class FoodItemPictureAddVM
    {
        public IFormFile FoodItem_image { get; set; }
    }
}
