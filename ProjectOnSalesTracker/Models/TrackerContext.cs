using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectOnSalesTracker.Models
{
    public class TrackerContext:DbContext
    {
        public  TrackerContext():base("name=dbConnectionString")
        {}
        public DbSet<BuyerInfo>BuyerInfoes    {get;set;}
        public DbSet<Communication> Communications { get; set; }
        public DbSet<CommunicationFrom> CommunicationForm { get; set; }
        public DbSet<CommunicationMedium> CommunicationMedium { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Source> Source { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<website> website { get; set; }
            
    }
}