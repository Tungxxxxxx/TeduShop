﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Department { get; set; }

        public string Skype { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }
        public string Yahoo { get; set; }
        public string Facebook { get; set; }

        public bool? Status { get; set; }
    }
}