using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sandness_mvc4.Models.BestillingsFelter
{
    public class BestillingsFelterViewModel
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public int Ord { get; set; }
        public int ForUser { get; set; }
        public int ForTable { get; set; }
        public string AddRadio { get; set; }
        public string AddDropdown { get; set; }
        public  List<ChoicesViewModel> choiceModel { get; set; }
        public List<DropdownViewModel> dropdownModel { get; set; }
    }
}