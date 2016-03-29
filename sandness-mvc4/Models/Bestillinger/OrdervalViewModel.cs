using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sandness_mvc4.Models.Bestillinger
{
    public class OrdervalViewModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Felt { get; set; }
        public string Choice { get; set; }
    }
}