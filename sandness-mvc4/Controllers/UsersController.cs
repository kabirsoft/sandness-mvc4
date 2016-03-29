using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sandness_mvc4.Models.users;
using sandness_mvc4.Models;
using sandness_mvc4.Code;

namespace sandness_mvc4.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/

        public ActionResult Index()
        {
            var UserModel = new userFormModel();
            return View(UserModel);
        }
        [HttpPost]
        public ActionResult Index( userFormModel UserModel)
        {
            using (var ctx = new Context())
            {
                User usr = new User
                {
                    Email       = UserModel.Email,
                    Password    = UserModel.Password,
                    FirstName   = UserModel.FirstName,
                    LastName    = UserModel.LastName,
                    Mobile      = UserModel.Mobile,
                    UserGroupId = UserModel.UserGroupId,
                    RollId      = UserModel.rollId,
                    CustomerId  = UserModel.customerId,
                    Create      = DateTime.Now
                };
                ctx.User.Add(usr);
                ctx.SaveChanges();
            }
            return View();
        }
        public ActionResult Edit(int id = 0)
        {
            using ( var ctx = new Context() )
            {
                User usr = ctx.User.Find(id);
                if ( usr == null )
                {
                    return HttpNotFound();
                }
                var UserModel = new userFormModel();
                UserModel.Id = usr.Id;
                UserModel.Email = usr.Email;
                UserModel.FirstName = usr.FirstName;
                UserModel.LastName = usr.LastName;
                UserModel.Mobile = usr.Mobile;
                UserModel.UserGroupId = usr.UserGroupId;
                UserModel.rollId = usr.RollId;
                UserModel.customerId = usr.CustomerId;   
                return View(UserModel);
            }
        }

        [HttpPost]
        public ActionResult Edit(userFormModel UserModel)
        {
            var ctx = new Context();
            User usr = ctx.User.Find( UserModel.Id );
            usr.FirstName = UserModel.FirstName;
            usr.LastName = UserModel.LastName;
            usr.Email = UserModel.Email;
            usr.Mobile = UserModel.Mobile;
            usr.UserGroupId = UserModel.UserGroupId;
            usr.RollId = UserModel.rollId;
            usr.CustomerId = UserModel.customerId;            
            if (!string.IsNullOrEmpty(UserModel.Password) )
            {
                usr.Password = UserModel.Password;
            }
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete( int id = 0)
        {
            var ctx = new Context();
            User usr = ctx.User.Find(id);
            if ( usr == null )
            {
                return HttpNotFound();
            }
            ctx.User.Remove(usr);
            ctx.SaveChanges();
            return RedirectToAction("Index", "Users");
        }

    }
}
