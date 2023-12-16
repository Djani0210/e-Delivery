using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Entities
{
    public class Location : BaseEntity
    {
        public string Longitude { get; set; }
        public string Latitude { get; set; }

        [ForeignKey(nameof(CityId))]
        public City City { get; set; }
        public int CityId { get; set; }
    }
}
