using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public int ID { get; set; }

        public DateTime VisitedDate { get; set; }

        [Required]
        public string IPAddress { get; set; }
    }
}