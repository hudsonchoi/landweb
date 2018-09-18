using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

        protected void Application_Error()
        {
            var exception = Server.GetLastError();

            var sSubject = "LandWeb Error";
            string sHTML = "" +
                "<html><head><style>body, td {font-size:10pt;font-family: \"Open Sans\", \"Helvetica Neue\", Helvetica, Arial, sans-serif;}</style></head>" +
                "<body><h3>" + sSubject + "</h3><p>" + DateTime.Now.ToLongTimeString() + "</p>";
            if (exception.InnerException != null)
                sHTML += "<p><b>" + exception.InnerException.Source + "</b></p>" +
                    "<p>" + exception.InnerException.Message + "</p>"; 
            sHTML +=
                "<p>" + exception.Message + "</p>" +
                "<p>" + exception.StackTrace + "</p>" +
                "</body></html>";
            using (MailMessage mail = new MailMessage())
            {
                SmtpClient SmtpServer = new SmtpClient();
                SmtpServer.Host = "192.168.9.3";
                mail.From = new MailAddress("hudsonchoi@njchodae.org");
                mail.To.Add("hudsonchoi@gmail.com");
                mail.Subject = sSubject;
                mail.Body = sHTML;
                mail.IsBodyHtml = true;
                SmtpServer.UseDefaultCredentials = true;
                SmtpServer.Send(mail);
            }
            Response.Redirect("/Home/Error");
            //EMailBuilder message1 = new EMailBuilder(sSubject, sHTML);
            //message1.Recipients.AddTo("Hudson Choi", "hchoi@blueskymls.com");
            //message1.Recipients.AddTo("Hudson Choi", "hudsonchoi@gmail.com");
            //message1.Send();

            //File.AppendAllText(Server.MapPath("/error.txt"), "\n\r" + DateTime.Now.ToLongTimeString() + ":" + exception.Message + "\n\r" +
            //    exception.StackTrace + "\n\r\n\r");
            //Response.Redirect("/Home/Error");//TODO:Log error
        }
    }
}
