using e_Delivery.Model.Category;
using e_Delivery.Model.SideDish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Model.FoodItem
{
    public class FoodItemGetVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public int LogoId { get; set; }
        public CategoriesGetVM Category { get; set; }
        public List<FoodItemPictureGetVM> FoodItemPictures { get; set; }
        public int RestaurantId { get; set; }
        public List<GetSideDishVM> SideDishes { get; set; }
        

    }
}
