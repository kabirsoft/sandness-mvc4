using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sandness_mvc4.Models.Byggeplass
{
    public class ByggeplassViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        [Display(Name = "Prosjektnavn")]
        public string Name { get; set; }        
        [Display(Name = "Adresse")]        
        public string Address { get; set; }
        [Display(Name = "By")]
        public string City { get; set; }
        [Display(Name = "Projektnummer")]
        public string ProjectNumber { get; set; }
        public DateTime Created { get; set; }
    }
}