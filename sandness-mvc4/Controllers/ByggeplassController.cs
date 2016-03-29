using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sandness_mvc4.Models.Byggeplass;
using sandness_mvc4.Models;
using sandness_mvc4.Code;
using System.Data.Entity;

namespace sandness_mvc4.Controllers
{
    public class ByggeplassController : Controller
    {   // GET: /Byggeplass/
        public ActionResult Index()
        {
            var ByggeplassModel = new ByggeplassViewModel();
            return View(ByggeplassModel);
        }
        // Create
        [HttpPost]
        public ActionResult Index( ByggeplassViewModel byggeplassModel )
        {   
            using (var ctx = new Context())
            {
                Project project = new Project
                {                  
                   CustomerId = byggeplassModel.CustomerId,
                   Name         = byggeplassModel.Name,
                   Address      = byggeplassModel.Address,
                   City         = byggeplassModel.City,
                   Projectnumber    = byggeplassModel.ProjectNumber,
                   Created          = DateTime.Now
                };
                ctx.Project.Add(project);
                ctx.SaveChanges();
                
                // save email
                int lastInsertId = project.Id;
                if (!string.IsNullOrEmpty(@Request.Form["added_email"]))
                {
                    var emails = Request.Form["added_email"].Split(',');
                    foreach (var email in emails)
                    {
                        ProjectsEmail pr_mails = new ProjectsEmail
                        {                            
                          created   = DateTime.Now,
                          ProjectId     = lastInsertId,
                          Email         = email            
                        };
                        ctx.ProjectsEmail.Add(pr_mails);
                        ctx.SaveChanges();
                    }
                }
            }
            return View();
        }
        // Edit Get
        public ActionResult Edit( int id = 0)
        {
            //ViewBag.ProjectID = id;
            using (var ctx = new Context())
            {
                //User usr = ctx.User.Where(m => m.Email.Equals(email) && m.Password.Equals(passwd)).FirstOrDefault();
                Project project = ctx.Project.Find(id);
                if (project == null)
                {
                    return HttpNotFound();
                }
                var ByggeplassModel = new ByggeplassViewModel();
                ByggeplassModel.Id = project.Id;
                ByggeplassModel.UserId = project.UserId;
                ByggeplassModel.CustomerId = project.CustomerId;
                ByggeplassModel.Name = project.Name;
                ByggeplassModel.Address = project.Address;
                ByggeplassModel.City = project.City;
                ByggeplassModel.ProjectNumber = project.Projectnumber;
                ByggeplassModel.Created = DateTime.Now;
                return View(ByggeplassModel);
            }            
        }
        // Edit Post
        [HttpPost]
        public ActionResult Edit( ByggeplassViewModel ByggeplassModel )
        {
            var ctx = new Context();
            Project project = ctx.Project.Find(ByggeplassModel.Id);
            project.Name = ByggeplassModel.Name;
            project.Address = ByggeplassModel.Address;
            project.City = ByggeplassModel.City;
            project.Projectnumber = ByggeplassModel.ProjectNumber;
            ctx.SaveChanges();

            //Update email
            foreach(var i in Request.Form.AllKeys)
            {
               if(i.Length > 7)
               {
                  if(i.Substring(0,7) == "prmail_")
                  { 
                       var eids = i.Split('_');                         
                       var Id = int.Parse(eids[1]);
                       if( Id  > 0)
                       {   
                           ProjectsEmail pro_email = ctx.ProjectsEmail.Find(Id);
                           pro_email.Email = Request[i];
                           ctx.SaveChanges();
                       }
                   }
                }
              }

            // add email
            if (!string.IsNullOrEmpty(@Request.Form["added_email"]))
            {
                var emails = Request.Form["added_email"].Split(',');
                foreach (var email in emails)
                {
                    ProjectsEmail pr_mails = new ProjectsEmail
                    {
                        created = DateTime.Now,
                        ProjectId = ByggeplassModel.Id,
                        Email = email
                    };
                    ctx.ProjectsEmail.Add(pr_mails);
                    ctx.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
        
        public ActionResult Delete( int id = 0)
        {
            var ctx = new Context();
            // delete foreignkey constraint ProjectsEmail with corresponding  Projectid
            var  proj_emails = ctx.ProjectsEmail.Where(m => m.ProjectId.Equals(id));
            if (proj_emails != null)
            {
                foreach (var proj_email in proj_emails)
                {
                    ctx.ProjectsEmail.Remove(proj_email);

                }
                ctx.SaveChanges();                
            }
            Project pro_del = ctx.Project.Find(id);
            if (pro_del == null)
            {
                return HttpNotFound();
            }
            ctx.Project.Remove(pro_del);
            ctx.SaveChanges();
            return RedirectToAction("Index","Byggeplass");
        }
        public ActionResult DeleteEmail( int id=0, int EmailId = 0)
        {            
            var ctx = new Context();
            var ProjectId = id;
            ProjectsEmail email_del = ctx.ProjectsEmail.Find(EmailId);
            if ( email_del == null )
            {
              return HttpNotFound();
            }
            ctx.ProjectsEmail.Remove(email_del);
            ctx.SaveChanges();
            return RedirectToAction("Edit", "Byggeplass", new { id = ProjectId });
        }
    }
}
