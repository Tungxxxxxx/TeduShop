using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Code { get; set; }

        public string ValueString { get; set; }
        public int? ValueInt { get; set; }
    }
}