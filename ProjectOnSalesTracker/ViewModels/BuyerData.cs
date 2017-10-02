using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectOnSalesTracker.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjectOnSalesTracker.ViewModels
{
    public class BuyerData
    {
       
        public ICollection<BuyerInfo> BuyerInfo { get; set; }
        public ICollection<Communication> Communication { get; set; }
        public ICollection<CommunicationFrom> CommunicationFrom { get; set; }
        public ICollection<CommunicationMedium> CommunicationMedium { get; set; }
        public ICollection<Product> Product { get; set; }
        public ICollection<Source> Source { get; set; }
        public ICollection<Status> Status { get; set; }
        public ICollection<website> website { get; set; }
    }
}