using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Entities
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string Path { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey(nameof(UserProfilePictureId))]
        public User? UserProfilePicture { get; set; }
        public Guid? UserProfilePictureId { get; set; }

        [ForeignKey(nameof(CreatedByUserId))]
        public User? CreatedByUser { get; set; }
        public Guid? CreatedByUserId { get; set; }

        [ForeignKey(nameof(ModifiedByUserId))]
        public User? ModifiedByUser { get; set; }
        public Guid? ModifiedByUserId { get; set; }
    }
}
