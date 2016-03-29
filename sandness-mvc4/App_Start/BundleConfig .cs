using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;


namespace sandness_mvc4.App_Start
{
    public class BundleConfig
    {
       public static void RegisterBundles(BundleCollection bundles) 
      {          
        bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
          "~/Scripts/jquery-1.9.1.min.js"
          ));
        bundles.Add(new ScriptBundle("~/bundles/bootstrapJs").Include(
            "~/Scripts/bootstrap.min.js"
       )); 
       

        /* Site SPecific CSS */
        bundles.Add(new StyleBundle("~/styles/jqueryUi").Include(
          "~/Content/jqueryUi/ui-lightness/jquery-ui-1.10.3.custom.css"            
          ));
        bundles.Add(new StyleBundle("~/styles/bootstrap").Include(
         "~/Content/bootstrap/bootstrap.css",
         "~/Content/bootstrap/bootstrap-theme.min.css"
       ));
        bundles.Add(new StyleBundle("~/styles/custom").Include(
            "~/Content/custom/style.css"));    

        BundleTable.EnableOptimizations = true; 
      } 

    }
}