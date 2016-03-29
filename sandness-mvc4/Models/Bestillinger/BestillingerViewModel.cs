using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sandness_mvc4.Models.Bestillinger
{
    public class BestillingerViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public int ProjectId { get; set; }
        public string DeliveryDate { get; set; }
        public string DeliveryTime { get; set; }
        public string Lmin { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public int Deleted { get; set; }
        public DateTime Created { get; set; }
        public List<OrdervalViewModel> ordervalModel { get; set; }
        
    }
}


