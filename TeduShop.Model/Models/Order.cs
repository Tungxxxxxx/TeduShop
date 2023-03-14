using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Required]
        public string CustomerAddress { get; set; }

        [Required]
        public string CustomerEmail { get; set; }

        [Required]
        public string CustomerMobile { get; set; }
        public string CustomerMessage { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public string PaymentMethod { get; set; }
        [Required]
        public bool PaymentStatus { get; set; }
    }
}