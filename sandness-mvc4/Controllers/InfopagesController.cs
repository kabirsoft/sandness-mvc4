using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sandness_mvc4.Models;
using sandness_mvc4.Models.Infopage;
using sandness_mvc4.Code;
using System.Web.Mvc;

namespace sandness_mvc4.Controllers
{
    public class InfopagesController : Controller
    {
        //
        // GET: /Infopages/

        public ActionResult Index()
        {
            var textModel = new TextCodesViewModel();
            return View(textModel);
        }
        [HttpPost]
        public ActionResult Index(TextCodesViewModel textModel)
        {
            using ( var ctx = new Context() )
            {
                Infopages info = new Infopages
                {                    
                    Text = textModel.infoPaegView.Text
                };
                ctx.Infopages.Add( info );
                ctx.SaveChanges();
                
                int highest_ord = ctx.Textcodes.Max(m => m.Ord);
                Textcodes textcode = new Textcodes
                {                     
                    InfopagesId = info.Id,
                    t_val =  textModel.t_val,
                    Ord = highest_ord + 1,                    
                    Created = DateTime.Now
                };
                ctx.Textcodes.Add( textcode );
                ctx.SaveChanges();   
            }
            return View();
        }

        public ActionResult Edit( int id = 0 )
        {
            using (var ctx = new Context())
            {
                Textcodes textcode = ctx.Textcodes.Find(id);
                if (textcode == null)
                {
                    return HttpNotFound();
                }
                TextCodesViewModel textModel = new TextCodesViewModel();                
                textModel.Id = id;
                textModel.t_val = textcode.t_val;
                textModel.InfopagesId = textcode.InfopagesId;
                Infopages infopage = ctx.Infopages.Find( textcode.InfopagesId );
                textModel.infoPaegView = new InfopageViewModel(); //initialize 
                textModel.infoPaegView.Id = textcode.InfopagesId;
                textModel.infoPaegView.Text = infopage.Text;                
                return View( textModel );
            }          
        }
        [HttpPost]
        public ActionResult Edit( TextCodesViewModel textModel )
        {
            var ctx = new Context();
            Textcodes textCode = ctx.Textcodes.Find( textModel.Id );
            textCode.t_val = textModel.t_val;
            ctx.SaveChanges();
            Infopages infopage = ctx.Infopages.Find(textModel.InfopagesId);            
            infopage.Text = textModel.infoPaegView.Text;
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete( int id=0 )
        {
            var ctx = new Context();
            Textcodes textCodeDel = ctx.Textcodes.Find( id );
            if (textCodeDel == null)
            {
                return HttpNotFound();
            }
            ctx.Textcodes.Remove(textCodeDel);
            ctx.SaveChanges();
            return RedirectToAction("Index", "Infopages");
        }
    }
}
