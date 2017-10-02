using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectOnSalesTracker.Models
{
    public class Designation
    {
       [Key] public int ID { get; set; }
        public string Name { get; set; } = "";
    }
}