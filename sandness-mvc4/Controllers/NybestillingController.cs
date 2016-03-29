using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sandness_mvc4.Code;
using sandness_mvc4.Models.Nybestilling;
using sandness_mvc4.Models;
using sandness_mvc4.Models.Diplo;


namespace sandness_mvc4.Controllers
{
    public class NybestillingController : Controller
    {
        //
        // GET: /Nybestilling/

        public ActionResult Index()
        {
            var orders = new NybestillingViewModel();

            return View(orders);
        }
        [HttpPost]
        public ActionResult Index( NybestillingViewModel nybestillingModel)
        {   
            var username = Session["username"];
            using (var ctx = new Context())
            {  
                //User usr = ctx.User.SingleOrDefault(m => m.Email == username);
                User usr = ctx.User.Where(m => m.Email == username).FirstOrDefault();                
                
                //userid, kunde, project, notater, lmin, khour, dato, created, deleted, status
                Order order = new Order  {   
                    UserId  = usr.Id,
                    CustomerId   = nybestillingModel.CustomerId,
                    ProjectId = nybestillingModel.ProjectId,
                    DeliveryDate    =  nybestillingModel.DeliveryDate,                    
                    Lmin    = nybestillingModel.Lmin,
                    Note = nybestillingModel.Note,
                    Created = DateTime.Now,
                    Deleted = 0,
                    Status = 1
                };
                ctx.Order.Add(order);
                ctx.SaveChanges();
                int lastInsertOrderId = order.Id;
                
                //var timestamp = ByggeplassRepository.ToUnix(now);
                foreach (var vals in Request.Form.AllKeys)
                {
                    if (vals.Length > 7)
                    {
                        if (vals.Substring(0, 7) == "values_")
                        {                            
                            var fids = vals.Split('_');
                            var fid = fids[1];
                                if (int.Parse(fid) > 0)
                                {
                                    //var t= Request[vals] + "-" + fid;                                    
                                    Orderval orderval = new Orderval
                                    {
                                        OrderId = lastInsertOrderId,                                                                                
                                        Felt = int.Parse(fid),
                                        Choice = Request[vals]
                                    };
                                    ctx.Orderval.Add(orderval);
                                    ctx.SaveChanges();                                    
                                }                            
                        }
                    }
                }
            }
            return View();
        }
        
    }
}
