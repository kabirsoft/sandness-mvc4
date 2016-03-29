using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sandness_mvc4.Code;
using sandness_mvc4.Models.Login;
using sandness_mvc4.Models;

namespace sandness_mvc4.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            var login = new LoginViewModel();
            return View(login);
        }
        
        [HttpPost]
        public ActionResult Index( LoginViewModel loginModel )
        {
            using (var ctx = new Context())
            {
                var email = loginModel.email;
                var passwd = loginModel.password;                

                User usr = ctx.User.Where(m => m.Email.Equals(email) && m.Password.Equals(passwd)).FirstOrDefault();
                if (usr != null)
                {
                    Session["username"] = usr.Email;
                    if (usr.UserGroupId == 2)
                    {
                        return RedirectToAction("Index", "Nybestilling");
                    }
                    else if (usr.UserGroupId == 1)
                    {
                        return RedirectToAction("Index", "Instillinger");
                    }
                    //var test = User;
                }
            }
            return View();
        }
        public ActionResult logout()
        {
            Session.Remove("username");
            return RedirectToAction("Index", "Login");
        }
    }
}
