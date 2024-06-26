﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace e_Delivery.Entities
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(FoodItemId))]
        public FoodItem FoodItem { get; set; }
        public int FoodItemId { get; set; }

        public List<int>? SideDishIds { get; set; } = new List<int>();

        [NotMapped]
        public List<SideDish>? SideDishes { get; set; } = new List<SideDish>();

        public int Quantity { get; set; }
        public double Cost { get; set; }
       
        [ForeignKey(nameof(Order))]
        [JsonIgnore]
        public Guid? OrderId { get; set; }

        public List<OrderItemSideDish> OrderItemSideDishes { get; set; } = new List<OrderItemSideDish>();
    }
}
