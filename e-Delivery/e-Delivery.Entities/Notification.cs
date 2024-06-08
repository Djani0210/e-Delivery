using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Entities
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(SentByUserId))]
        public User? SentByUser { get; set; }
        public Guid? SentByUserId { get; set; }

        [ForeignKey(nameof(SentToUserId))]
        public User SentToUser { get; set; }
        public Guid SentToUserId { get; set; }

        public string? RestaurantName { get; set; }

    }
}
