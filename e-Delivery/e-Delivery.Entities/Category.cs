using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Name { get; set; }
        public List<FoodItem>? FoodItems { get; set; }
    }
    /* Assuming restaurantId is the ID of the restaurant you're interested in
        var categoriesWithFoodItems = dbContext.Categories
    .Where(c => c.FoodItems.Any(fi => fi.RestaurantId == restaurantId))
    .Include(c => c.FoodItems) // Eager loading to include related food items
    .ToList();
    */

}
