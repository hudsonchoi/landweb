using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace LandWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalFilters.Filters.Add(new MyPropertyActionFilter(), 0);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            
            //HttpContext.Current.Session["AppVersion"] = ver.Substring(0, ver.LastIndexOf("."));
        }

        public class MyPropertyActionFilter : ActionFilterAttribute
        {
            public override void OnResultExecuting(ResultExecutingContext filterContext)
            {
                Assembly asm = Assembly.GetExecutingAssembly();
                string[] parts = asm.FullName.Split(',');
                var ver = parts[1].Replace("Version=", "v");
                filterContext.Controller.ViewBag.Version = ver.Substring(0, ver.LastIndexOf(".")); ;
            }
        }
    }
}
