using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sandness_mvc4.Models.BestillingsFelter;
using sandness_mvc4.Models;
using sandness_mvc4.Code;
namespace sandness_mvc4.Controllers
{
    public class BestillingsfelterController : Controller
    {
        //
        // GET: /Bestillingsfelter/

        public ActionResult Index()
        {
            var FelterModel = new BestillingsFelterViewModel();
            return View( FelterModel );
        }
        [HttpPost]
        public ActionResult Index( BestillingsFelterViewModel FelterModel )
        {             
            using (var ctx = new Context())
            {                
                var felter_LastOrd = ctx.Felters.Take(1).OrderByDescending(m => m.Ord).Select(m => m.Ord).Single();
                Felters felter = new Felters
                {
                    Name        = FelterModel.Name,
                    Type        = FelterModel.Type,
                    Created     = DateTime.Now,
                    Ord         = felter_LastOrd + 1,
                    ForUser     = 0,
                    ForTable    = 0,
                };
                ctx.Felters.Add(felter);
                ctx.SaveChanges();
            }
            return View();
        }

        public ActionResult Move_down( int id=0 )
        {
            using (var ctx = new Context())
            {
                Felters felters = ctx.Felters.Where(m => m.Id == id).OrderByDescending(m=>m.Ord).FirstOrDefault();
                var CurrentOrd = felters.Ord;
                var CurrentId = id;
                //get next rows order and next rows id
                Felters GetNextRows = ctx.Felters.Where(m => m.Ord < CurrentOrd).OrderByDescending(m => m.Ord).Take(1).SingleOrDefault();
                var NextOrd = GetNextRows.Ord;
                var NextId = GetNextRows.Id;
                
                felters.Ord = NextOrd;
                GetNextRows.Ord = CurrentOrd;
                ctx.SaveChanges();

            }
            return RedirectToAction("Index", "Bestillingsfelter");
        }
        
       

        public ActionResult Move_Up( int id=0 )
        {
            using (var ctx = new Context())
            {
                Felters felters = ctx.Felters.Where(m => m.Id == id).OrderByDescending(m => m.Ord).FirstOrDefault();
                var CurrentOrd = felters.Ord;
                var CurrentId = id;
                //get next rows order and next rows id
                Felters GetNextRows = ctx.Felters.Where(m => m.Ord > CurrentOrd).OrderBy(m => m.Ord).Take(1).SingleOrDefault();
                var PrevOrd = GetNextRows.Ord;
                var PrevId = GetNextRows.Id;

                felters.Ord = PrevOrd;
                GetNextRows.Ord = CurrentOrd;
                ctx.SaveChanges();
            }
            return RedirectToAction("Index", "Bestillingsfelter");
        }

        public ActionResult ForNybestilling( int id=0 )
        {
            using (var ctx = new Context())
            {                
                Felters felters = ctx.Felters.Where(m => m.Id == id).FirstOrDefault();
                if (felters.ForUser == 1)
                {
                    felters.ForUser = 0;
                }
                else if (felters.ForUser == 0)
                {
                    felters.ForUser = 1;
                }
                ctx.SaveChanges();
            }
            return RedirectToAction("Index", "Bestillingsfelter");
        }
        public ActionResult ForBestilling( int id=0)
        {
            using (var ctx = new Context())
            {
                Felters felters = ctx.Felters.Where(m => m.Id == id).FirstOrDefault();
                if (felters.ForTable == 1)
                {
                    felters.ForTable = 0;
                }
                else if ( felters.ForTable == 0 )
                {
                    felters.ForTable = 1;
                }
                ctx.SaveChanges();
            }
            return RedirectToAction("Index", "Bestillingsfelter");
        }

        public ActionResult Delete( int id=0 )
        {
            using (var ctx = new Context())
            {
                Felters felter = ctx.Felters.Find(id);
                if (felter == null)  {  return HttpNotFound();  }
                ctx.Felters.Remove(felter);
                ctx.SaveChanges();
            }
            return RedirectToAction("Index", "Bestillingsfelter");
        }
        public ActionResult Edit( int id = 0 )
        {
            using (var ctx = new Context())
            {
                Felters felters = ctx.Felters.Find(id);
                if ( felters == null ){ return HttpNotFound(); }
                BestillingsFelterViewModel bestillingModel = new BestillingsFelterViewModel();
                bestillingModel.Id = felters.Id;
                bestillingModel.Type = felters.Type;
                bestillingModel.Name = felters.Name;
                bestillingModel.Ord = felters.Ord;
                bestillingModel.ForUser = felters.ForUser;
                bestillingModel.ForTable = felters.ForTable;
                var choices = ctx.Choices.Where(m => m.FeltId == id).OrderBy(m=>m.Ord).ToList();
                bestillingModel.choiceModel = new List<ChoicesViewModel>();                                
                foreach (var choice in choices)
                {
                    var newChoice = new ChoicesViewModel();
                    newChoice.Id = choice.Id;
                    newChoice.Name = choice.Name;
                    newChoice.Ord = choice.Ord;
                    newChoice.Default = choice.Default;
                    newChoice.FeltId = choice.FeltId;
                    bestillingModel.choiceModel.Add(newChoice);
                }

                var dropdowns = ctx.Dropdowns.Where(m => m.Did == id).OrderBy(m=>m.Ord).ToList();
                bestillingModel.dropdownModel = new List<DropdownViewModel>();
                foreach (var dropdown in dropdowns)
                {
                    var newDropdown = new DropdownViewModel();
                    newDropdown.Id = dropdown.Id;
                    newDropdown.Name = dropdown.Name;
                    newDropdown.Ord = dropdown.Ord;
                    newDropdown.Default = dropdown.Default;
                    newDropdown.Did = dropdown.Did;
                    bestillingModel.dropdownModel.Add( newDropdown );
                }
                return View(bestillingModel);    
            }            
        }

        [HttpPost]
        public ActionResult Edit( BestillingsFelterViewModel FelterModel )
        {
            using (var ctx = new Context())
            {
                Felters felter = ctx.Felters.Find( FelterModel.Id );
                felter.Name = FelterModel.Name;
                ctx.SaveChanges();
                
            }
            return RedirectToAction("Index", "Bestillingsfelter");
        }
        public ActionResult Edit_dropdown_movedown(int id = 0, int felterId = 0)
        {
            using (var ctx = new Context())
            {
                Dropdowns dropdown = ctx.Dropdowns.Where(m => m.Id == id).OrderBy(m => m.Ord).FirstOrDefault();
                var CurrentOrd = dropdown.Ord;
                var CurrentDid = dropdown.Did;
                var CurrentId = dropdown.Id;
                //get next rows order and next rows id
                Dropdowns getNextRows = ctx.Dropdowns.Where(m => m.Ord > CurrentOrd).Where(m => m.Did == CurrentDid).OrderBy(m => m.Ord).Take(1).SingleOrDefault();
                var NextOrd = getNextRows.Ord;

                dropdown.Ord = NextOrd;
                getNextRows.Ord = CurrentOrd;
                ctx.SaveChanges();
            }
            return RedirectToAction("Edit", "Bestillingsfelter", new { id = felterId });
        }
        public ActionResult Edit_dropdown_Moveup(int id = 0, int felterId = 0)
        {
            using (var ctx = new Context())
            {
                Dropdowns dropdown = ctx.Dropdowns.Where(m => m.Id == id).OrderBy(m => m.Ord).FirstOrDefault();
                var CurrentOrd = dropdown.Ord;
                var CurrentDid = dropdown.Did;
                var CurrentId = dropdown.Id;
                //get next rows order and next rows id
                Dropdowns getNextRows = ctx.Dropdowns.Where(m => m.Ord < CurrentOrd).Where(m => m.Did == CurrentDid).OrderByDescending(m => m.Ord).Take(1).SingleOrDefault();
                var NextOrd = getNextRows.Ord;

                dropdown.Ord = NextOrd;
                getNextRows.Ord = CurrentOrd;
                ctx.SaveChanges();
            }
            return RedirectToAction("Edit", "Bestillingsfelter", new { id = felterId });
        }

        public ActionResult Edit_radio_movedown(int id = 0, int felterId = 0)
        {
            using (var ctx = new Context())
            {
                Choices choices = ctx.Choices.Where(m => m.Id == id).OrderBy(m => m.Ord).FirstOrDefault();
                var CurrentOrd = choices.Ord;
                var CurrentFeltId = choices.FeltId;
                var CurrentId = choices.Id;
                //get next rows order and next rows id
                Choices getNextRows = ctx.Choices.Where(m => m.Ord > CurrentOrd).Where(m => m.FeltId == CurrentFeltId).OrderBy(m => m.Ord).Take(1).SingleOrDefault();
                var NextOrd = getNextRows.Ord;

                choices.Ord = NextOrd;
                getNextRows.Ord = CurrentOrd;
                ctx.SaveChanges();
            }
            return RedirectToAction("Edit", "Bestillingsfelter", new { id = felterId });
        }
        public ActionResult Edit_radio_moveup(int id = 0, int felterId = 0)
        {
            using (var ctx = new Context())
            {
                Choices choices = ctx.Choices.Where(m => m.Id == id).OrderBy(m => m.Ord).FirstOrDefault();
                var CurrentOrd = choices.Ord;
                var CurrentFeltId = choices.FeltId;
                var CurrentId = choices.Id;
                //get next rows order and next rows id
                Choices getNextRows = ctx.Choices.Where(m => m.Ord < CurrentOrd).Where(m => m.FeltId == CurrentFeltId).OrderByDescending(m => m.Ord).Take(1).SingleOrDefault();
                var NextOrd = getNextRows.Ord;

                choices.Ord = NextOrd;
                getNextRows.Ord = CurrentOrd;
                ctx.SaveChanges();
            }
            return RedirectToAction("Edit", "Bestillingsfelter", new { id = felterId });
        }

        [HttpPost]
        public ActionResult SaveEditRadio(BestillingsFelterViewModel FelterModel )
        {
            using (var ctx = new Context())
            {
                Felters felter = ctx.Felters.Find(FelterModel.Id);
                felter.Name = FelterModel.Name;
                ctx.SaveChanges();
                if (FelterModel.AddRadio != null)
                {
                    var Choices_LastOrd = 1;
                    try
                    {
                        Choices_LastOrd = ctx.Choices.Where(m => m.FeltId == felter.Id).OrderByDescending(m => m.Ord).Take(1).Select(m => m.Ord).Single();
                    }
                    catch (Exception ex)
                    {
                    }
                    if (Choices_LastOrd < 1)
                    {
                        Choices_LastOrd = 1;
                    }
                    Choices choice = new Choices
                    {
                        FeltId = FelterModel.Id,
                        Name = FelterModel.AddRadio,
                        Created = DateTime.Now,
                        Ord = Choices_LastOrd + 1
                    };
                    ctx.Choices.Add(choice);
                    ctx.SaveChanges();
                }
            }
            return RedirectToAction("Edit", "Bestillingsfelter", new { id = FelterModel.Id });
        }
        [HttpPost]
        public ActionResult SaveEditDropdown( BestillingsFelterViewModel FelterModel )
        {
            using (var ctx = new Context())
            {
                Felters felter = ctx.Felters.Find(FelterModel.Id);
                felter.Name = FelterModel.Name;
                ctx.SaveChanges();
                if (FelterModel.AddDropdown != null)
                {
                    var Dropdown_LastOrd = 1;
                    try
                    {
                        Dropdown_LastOrd = ctx.Dropdowns.Where(m => m.Did == felter.Id).OrderByDescending(m => m.Ord).Take(1).Select(m => m.Ord).Single();
                    }
                    catch (Exception ex) { }
                    if (Dropdown_LastOrd < 1)
                    {
                        Dropdown_LastOrd = 1;
                    }
                    Dropdowns dropdown = new Dropdowns
                    {
                        Did = FelterModel.Id,
                        Name = FelterModel.AddDropdown,
                        Created = DateTime.Now,
                        Ord = Dropdown_LastOrd + 1
                    };
                    ctx.Dropdowns.Add( dropdown );
                    ctx.SaveChanges();
                }
            }
            return RedirectToAction("Edit", "Bestillingsfelter", new { id = FelterModel.Id });
        }

        public ActionResult Delete_radio_dropdown( int id = 0, int felterId= 0, int type = 0)
        {
            using (var ctx = new Context())
            {
                if ( type == 3)
                {
                    Choices choice = ctx.Choices.Find(id);
                    if (choice == null) { return HttpNotFound(); }
                    ctx.Choices.Remove(choice);
                    ctx.SaveChanges();
                }
                else if ( type == 2 )
                {
                    Dropdowns dropdown = ctx.Dropdowns.Find(id);
                    if (dropdown == null) { return HttpNotFound(); }
                    ctx.Dropdowns.Remove( dropdown );
                    ctx.SaveChanges();
                }
            }
            return RedirectToAction("Edit", "Bestillingsfelter", new { id = felterId });
        }

    }
}
