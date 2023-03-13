using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstracts
{
    public abstract class Auditable : IAuditable
    {
        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(256)]
        public string UpdatedBy { get; set; }
        public bool Status { get; set; }
    }
}