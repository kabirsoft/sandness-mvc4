﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sandness_mvc4.Models.BestillingsFelter
{
    public class ChoicesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FeltId { get; set; }
        public DateTime Created { get; set; }
        public int Default { get; set; }
        public int Ord { get; set; }        
    }
}