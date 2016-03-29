using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace sandness_mvc4.Models.users
{
    public class userFormModel
    {
        public int Id { get; set; }
        [Display(Name = "E-post")]
        public string Email { get; set; }
        public string Password { get; set; }
        [Display(Name = "Fornavn")]
        public string FirstName { get; set; }
        [Display(Name = "Etternavn")]
        public string LastName { get; set; }
        [Display(Name = "Mobiltelefon")]
        public string Mobile { get; set; }
        public int UserGroupId { get; set; }
        public int rollId { get; set; }
        public int customerId { get; set; }
        public DateTime Create { get; set; }
        public DateTime LastLogin { get; set; }
    }
}