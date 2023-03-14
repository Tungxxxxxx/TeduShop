using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostID { get; set; }

        [Key]
        public int TagID { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }

        public virtual IEnumerable<Tag> Tags { get; set; }
    }
}