﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Entities
{
    public class Verification
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime ExpireDate { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}
