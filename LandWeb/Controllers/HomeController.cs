using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LandWeb.Model;
using LandWeb.Models;

namespace LandWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string Registration)
        {
            var tmp = Registration;
            DashboardViewModel model = new DashboardViewModel();
            DAL db = new DAL();
            switch(Registration)
            {
                case "0":
                    model.Members = db.GetMembers(DateTime.Today.AddDays(-14), DateTime.Today.AddDays(1));
                    break;
                case "1":
                    model.Members = db.GetMembers(DateTime.Today.AddDays(-28), DateTime.Today.AddDays(1));
                    break;
                case "2":
                    model.Members = db.GetMembers(DateTime.Today.AddMonths(-6), DateTime.Today.AddDays(1));
                    break;
                default:
                    model.Members = db.GetMembers(DateTime.Today.AddDays(-14), DateTime.Today.AddDays(1));
                    break;
            }
            
            //model.Members = db.GetMembers(Convert.ToDateTime("5/11/2016 12:00:00"), Convert.ToDateTime("5/26/2016 12:00:00"));

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}