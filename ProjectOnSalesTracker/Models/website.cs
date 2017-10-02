using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectOnSalesTracker.Models
{
    public class website
    {
        [Key]public int ID { get; set; }
        public string WebsiteName { get; set; }
    }
}