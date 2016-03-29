using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sandness_mvc4.Models.Kunde
{
    public class KundeViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Bedriftsnavn")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "E-post")]
        public string Email { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Display(Name = "Adresse")]
        public string Address { get; set; }
        [Display(Name = "By")]
        public string City { get; set; }
        [Display(Name = "Organisasjonsnummer")]
        public string OrganizationNumber { get; set; }
        public DateTime Created { get; set; }
    }
}