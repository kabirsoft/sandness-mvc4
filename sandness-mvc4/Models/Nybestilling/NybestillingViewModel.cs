using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sandness_mvc4.Models.Nybestilling
{
    public class NybestillingViewModel
    {
        public int CustomerId { get; set; } // company in the form
        public int ProjectId { get; set; }
        [Display(Name="Leveringsdato")]
        [Required]
        public string DeliveryDate { get; set; }
        [Display( Name="Klokkeslett levering")]
        public string DeliveryTime { get; set; }                       
        [Display(Name = "Tid mellom leveransene")]
        public string Lmin { get;  set; }
        [Display(Name = "Notater")]
        public string Note { get; set; }
		
    }
}