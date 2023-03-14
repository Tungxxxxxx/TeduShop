using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { get; set; }

        [Key]
        public int ProductID { get; set; }

        public int? Quantity { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}