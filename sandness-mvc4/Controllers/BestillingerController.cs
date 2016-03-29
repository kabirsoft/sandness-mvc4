using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sandness_mvc4.Controllers
{
    public class BestillingerController : Controller
    {
        //
        // GET: /Bestillinger/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult edit_bestillinger(int orderID)
        {
            ViewBag.orderID = orderID;
            return View();
        }
        public ActionResult edit1_bestillinger(int orderID )
        {
            ViewBag.orderID = orderID;
            return View();
        }
    }
}
