using e_Delivery.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Entities
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedDate { get; set; }
        public bool IsPaid { get; set; }
    

        public PaymentMethod PaymentMethod { get; set; }
        public double TotalCost { get; set; }
        public string? Allergies { get; set; }
        public OrderState OrderState { get; set; }  

        [ForeignKey(nameof(CreatedByUserId))]
        public User CreatedByUser { get; set; }
        public Guid CreatedByUserId { get; set; }

        [ForeignKey(nameof(RestaurantId))]
        public Restaurant? Restaurant { get; set; }
        public int RestaurantId { get; set; }

        [ForeignKey(nameof(DeliveryPersonAssignedId))]
        public User? DeliveryPersonAssigned { get; set; }
        public Guid? DeliveryPersonAssignedId { get; set; }

        [ForeignKey(nameof(LocationId))]
        public Location? Location { get; set; }
        public int LocationId { get; set; }

        public List<OrderItem> OrderItems { get; set; }

    }
}
