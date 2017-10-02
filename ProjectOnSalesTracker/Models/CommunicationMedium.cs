using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectOnSalesTracker.Models
{
    public class CommunicationMedium
    {
      [Key]  public int mediumId { get; set; }
        public string medium { get; set; }
    }
}