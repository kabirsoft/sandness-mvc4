using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sandness_mvc4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            if (Session["username"] == null)
            {
                return RedirectToAction("index", "Login");
            }

            //
            return View();
        }

    }
}
