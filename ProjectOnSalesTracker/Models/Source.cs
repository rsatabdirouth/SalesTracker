using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectOnSalesTracker.Models
{
    public class Source
    {
      [Key]
        public int ID { get; set; }
        [Required]
        public string SourceName { get; set; }
    }
}