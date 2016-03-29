using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sandness_mvc4.Models.Kunde;
using sandness_mvc4.Models;
using sandness_mvc4.Code;

namespace sandness_mvc4.Controllers
{
    public class KundeController : Controller
    {
        //
        // GET: /Kunde/

        public ActionResult Index()
        {
            var KundeModel = new KundeViewModel();
            return View(KundeModel);
        }

        [HttpPost]
        public ActionResult Index(KundeViewModel kundeModel )
        {
            using (var ctx = new Context())
            {
                Customer customer = new Customer
                {
                    Name                =   kundeModel.Name,
                    Email               =  kundeModel.Email,
                    Phone               =  kundeModel.Phone,
                    Address             = kundeModel.Address,
                    City                =  kundeModel.City,
                    OrganizationNumber  =  kundeModel.OrganizationNumber,
                    Created             = DateTime.Now
                };
                ctx.Customer.Add(customer);
                ctx.SaveChanges();
            }

            return View();
        }
        public ActionResult Edit(int id = 0)
        {
            using ( var ctx = new Context() )
            {
              Customer customer = ctx.Customer.Find(id);
              if (customer == null)
              {
                  return HttpNotFound();
              }

              var kundeModel = new KundeViewModel();
              kundeModel.Id = customer.Id;
              kundeModel.Name = customer.Name;
              kundeModel.Email = customer.Email;
              kundeModel.Phone = customer.Phone;
              kundeModel.Address = customer.Address;
              kundeModel.City = customer.City;
              kundeModel.OrganizationNumber = customer.OrganizationNumber;
              return View(kundeModel);
            }
        }

        [HttpPost]
        public ActionResult Edit( KundeViewModel kundeModel )
        {
            var ctx = new Context();
            Customer customer = ctx.Customer.Find(kundeModel.Id);
            customer.Name = kundeModel.Name;
            customer.Email = kundeModel.Email;
            customer.Phone = kundeModel.Phone;
            customer.Address = kundeModel.Address;
            customer.City = kundeModel.City;
            customer.OrganizationNumber = kundeModel.OrganizationNumber;
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
