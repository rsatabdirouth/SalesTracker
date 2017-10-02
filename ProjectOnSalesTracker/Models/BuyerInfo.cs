using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectOnSalesTracker.Models
{
    public class BuyerInfo
    {
        [Key]public int BuyerId { get; set; }
        public DateTime? Date { get; set; }
        //Foreign key using Schema
        [ForeignKey("Product")]public int ProductLookingFor { get; set; }
        public string CompanyName { get; set; }
        [ForeignKey("Status")] public int BuyerStatus { get; set; }

       [ForeignKey("Source")] public int BuyerSource { get; set; }
       [ForeignKey("website")] public int Website { get; set; }
        public string SourceWebLlink { get; set; }
        public string Mobile { get; set; }
        public string ContactName { get; set; }
        public string AlternativePhone { get; set; } = "";
        public string Extension { get; set; }
        public string Email { get; set; }
        //[ForeignKey("designation")]
        //public int Designation { get; set; } 


        //Navigation property
        public virtual Product Product { get; set; }
        public virtual Status Status { get; set; }
        public virtual Source Source { get; set; }
        public virtual website website { get; set; }
        //public virtual Designation designation { get; set; }
    }
}