using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstracts
{
    public interface IAuditable
    {
        //Seoable
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }

        //Auditable
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }

        // Swicthable
        bool Status { get; set; }
    }
}