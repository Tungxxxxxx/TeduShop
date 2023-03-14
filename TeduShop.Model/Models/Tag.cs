using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }

        [ForeignKey("ID")]
        public virtual PostTag PostTag { get; set; }

        public virtual IEnumerable<ProductTag> ProductTags { get; set; }
    }
}