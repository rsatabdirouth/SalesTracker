using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectOnSalesTracker.Models
{
    public class Communication
    {
      [Key]  public int Id { get; set; }
      [ForeignKey("buyer")]  public int BuyerID { get; set; }
      public DateTime? FirstDateOfINteraction { get; set; }
      [ForeignKey("communicate")] public int CommunicationForm { get; set; }
      [ForeignKey("medium")]  public int CommunicationVia { get; set; }
        public string Feedback { get; set; }
        public bool IsInterested { get; set; }
        public string NextStep { get; set; }
        public DateTime? FollowupDate { get; set; }
        public bool? IsConverted { get; set; }
       public string transferredTo { get; set; } = "";
        //navigation
        public virtual BuyerInfo buyer { get; set; }
        public virtual CommunicationFrom communicate { get; set; }
        public virtual CommunicationMedium medium { get; set; }
        
    }
}