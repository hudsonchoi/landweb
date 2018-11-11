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
            var sSubject = "LandWeb Error";
            string strHandledMessage = String.Empty;
            HttpBrowserCapabilities br = Request.Browser;

            if (Server.GetLastError().InnerException != null)
                strHandledMessage =
                "GetLastError.InnerException.Message: " + Server.GetLastError().InnerException.Message.ToString() +
                Environment.NewLine + Environment.NewLine +
                "GetLastError.InnerException.StackTrace: " + Server.GetLastError().InnerException.StackTrace.ToString() +
                Environment.NewLine + Environment.NewLine;
            strHandledMessage +=
                "The client ip: " + Request.ServerVariables["REMOTE_ADDR"] +
                Environment.NewLine + Environment.NewLine +
                "GetLastError.Message: " + Server.GetLastError().Message.ToString() +
                Environment.NewLine + Environment.NewLine +
                "GetLastError.StackTrace: " + Server.GetLastError().StackTrace.ToString() +
                Environment.NewLine + Environment.NewLine +
                "Page: " + Request.ServerVariables["SCRIPT_NAME"] +
                Environment.NewLine + Environment.NewLine +
                "Server: " + Request.ServerVariables["SERVER_NAME"] +
                Environment.NewLine + Environment.NewLine +
                "Local Address: " + Request.ServerVariables["LOCAL_ADDR"] +
                 Environment.NewLine + Environment.NewLine +
                "Browser: " + br.Browser.ToString() + " : " + br.Version.ToString();

            if (Request.UrlReferrer != null)
            {
                strHandledMessage += Environment.NewLine + Environment.NewLine +
               "Referrer: " + Request.UrlReferrer.ToString();
            }

            if (Request.QueryString != null)
            {
                strHandledMessage += Environment.NewLine + Environment.NewLine +
               "Query String: " + Request.QueryString.ToString();
            }

            strHandledMessage += Environment.NewLine + Environment.NewLine;

            using (MailMessage mail = new MailMessage())
            {
                SmtpClient SmtpServer = new SmtpClient();
                SmtpServer.Host = "192.168.9.3";
                mail.From = new MailAddress("hudsonchoi@njchodae.org");
                mail.To.Add("hudsonchoi@gmail.com");
                mail.Subject = sSubject;
                mail.Body = strHandledMessage;
                //mail.IsBodyHtml = true;
                SmtpServer.UseDefaultCredentials = true;
                SmtpServer.Send(mail);
            }
            Response.Redirect("/Home/Error");
        }
    }
}
