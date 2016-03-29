using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace sandness_mvc4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute("EmailDelete",
                "Byggeplass/DeleteEmail/{id}/{EmailId}/",
                new { controller = "Byggeplass", action = "DeleteEmail", id = UrlParameter.Optional, EmailId = UrlParameter.Optional }                 
            );            
            routes.MapRoute("BestillingsfelterEditMoveDown",
                "Bestillingsfelter/Edit_dropdown_movedown/{id}/{felterId}/",
                new { controller = "Bestillingsfelter", action = "Edit_dropdown_movedown", id = UrlParameter.Optional, felterId = UrlParameter.Optional }
            );
            routes.MapRoute("BestillingsfelterEditMoveUp",
                "Bestillingsfelter/Edit_dropdown_Moveup/{id}/{felterId}/",
                new { controller = "Bestillingsfelter", action = "Edit_dropdown_Moveup", id = UrlParameter.Optional, felterId = UrlParameter.Optional }
            );

            routes.MapRoute("BestillingsfelterEditradioMoveDown",
               "Bestillingsfelter/Edit_radio_movedown/{id}/{felterId}/",
               new { controller = "Bestillingsfelter", action = "Edit_radio_movedown", id = UrlParameter.Optional, felterId = UrlParameter.Optional }
           );
            routes.MapRoute("BestillingsfelterEditradioMoveUp",
              "Bestillingsfelter/Edit_radio_moveup/{id}/{felterId}/",
              new { controller = "Bestillingsfelter", action = "Edit_radio_moveup", id = UrlParameter.Optional, felterId = UrlParameter.Optional }
          );

            routes.MapRoute("BestillingsfelterDelRadioDropdown",
                 "Bestillingsfelter/Delete_radio_dropdown/{id}/{felterId}/{type}/",
                 new { controller = "Bestillingsfelter", action = "Delete_radio_dropdown", id = UrlParameter.Optional, felterId = UrlParameter.Optional, type = UrlParameter.Optional }
             );
        }
    }
}