using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sandness_mvc4.Models.Roller;
using sandness_mvc4.Models;
using sandness_mvc4.Code;

namespace sandness_mvc4.Controllers
{
    public class RollerController : Controller
    {
        //
        // GET: /Roller/

        public ActionResult Index()
        {
            var RollerModel = new RollerViewModel();
            return View(RollerModel);
        }
        [HttpPost]
        public ActionResult Index( RollerViewModel RollerModel )
        {
            using (var ctx = new Context())
            {
                Roll roll = new Roll
                {
                    Name    = RollerModel.Name,
                    New     = RollerModel.New,
                    Edit    = RollerModel.Edit,
                    Created = DateTime.Now
                };
                ctx.Roll.Add(roll);
                ctx.SaveChanges();
            }
            return View();
        }
      
      public ActionResult Edit(int id = 0)
      {
          using (var ctx = new Context() )
          {
              Roll roll = ctx.Roll.Find( id );
              if (roll == null)
              {
                  return HttpNotFound();
              }
              var rollModel = new RollerViewModel();
              rollModel.Id = roll.Id;      
              rollModel.Name = roll.Name;
              rollModel.New =  roll.New;
              rollModel.Edit = roll.Edit;
              return View(rollModel);
          }
          
      }

      [HttpPost]
	  public ActionResult Edit( RollerViewModel rollModel )
      {
          using (var ctx = new Context())
          {
              Roll roll = ctx.Roll.Find( rollModel.Id);
              roll.Name = rollModel.Name;
              roll.New = rollModel.New;
              roll.Edit = rollModel.Edit;
              ctx.SaveChanges();
              return RedirectToAction("Index");
          }          
      }
      public ActionResult Delete( int id=0 )
      {
          using (var ctx = new Context())
          {
              Roll roll = ctx.Roll.Find(id);
              if (roll == null)
              {
                  return HttpNotFound();
              }
              ctx.Roll.Remove(roll);
              ctx.SaveChanges();
              return RedirectToAction("Index", "Roller");
          }
      }
    }
}
