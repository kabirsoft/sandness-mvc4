using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sandness_mvc4.Models.Infopage
{
    public class TextCodesViewModel
    {
        public int Id { get; set; }
        public string t_val { get; set; } 
        public int InfopagesId { get; set; }
        public int Ord { get; set; } 
        public DateTime Created { get; set; }
        public InfopageViewModel infoPaegView { get; set; }
        
    }
}