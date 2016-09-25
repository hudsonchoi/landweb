using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LandWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "CellReport",
                url: "CellReport/Index/{cellCode}",
                defaults: new { controller = "CellReport", action = "Get", cellCode = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "CellReportDetail",
                url: "CellReport/Detail/{cellCode}",
                defaults: new { controller = "CellReport", action = "Detail", cellCode = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
