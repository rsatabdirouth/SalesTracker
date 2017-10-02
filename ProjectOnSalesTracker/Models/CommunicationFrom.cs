using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectOnSalesTracker.Models
{
    public class CommunicationFrom
    {[Key] public int communicatorID { get; set; }
        public string Name { get; set; }
    }
}