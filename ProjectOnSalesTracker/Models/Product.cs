using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectOnSalesTracker.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjectOnSalesTracker.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string ProductName { get; set; }

    }
}