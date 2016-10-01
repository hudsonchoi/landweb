using LandWeb.Model;
using LandWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LandWeb.Controllers
{
    public class CellReportController : Controller
    {
        // GET: CellReport
        public ActionResult Index()
        {
            CellReportViewModel model = new CellReportViewModel();
            model.CellList = DropDownHelper.GetCellList();
            //TempData["CellList"] = model.CellList;
            ViewBag.Back = false;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(CellReportViewModel model)
        {
            ViewBag.Back = true;
            return View(GetReportViewModel(model));
        }

        public ActionResult Get(int? cellCode)
        {
            ViewBag.Back = true;
            CellReportViewModel model = new CellReportViewModel();
            model.CellCode = cellCode.ToString();
            return View("Index", GetReportViewModel(model));
        }

        private CellReportViewModel GetReportViewModel(CellReportViewModel model)
        {
            SelectList cellList = DropDownHelper.GetCellList();
            foreach (var c in cellList)
            {
                if (c.Value == model.CellCode)
                    c.Selected = true;
            }
            model.CellList = cellList;
            DAL dal = new DAL();
            model.Reports = dal.GetReportList(Convert.ToInt32(model.CellCode), model.From, model.To).ToList();
            return model;
        }

        public ActionResult Detail(int? cellCode)
        {
            DAL dal = new DAL();
            CellReportDetailViewModel model = new CellReportDetailViewModel();
            model.Report = dal.GetReportDetail((int)cellCode);
            model.Members = dal.GetReportDetailMembers((int)cellCode);
            return View(model);
        }

        public ActionResult Dev()
        {
            CellReportViewModel model = new CellReportViewModel();
            model.CellList = DropDownHelper.GetCellList();
            //TempData["CellList"] = model.CellList;
            ViewBag.Back = false;
            return View();
        }

        public ActionResult Dev2()
        {
            CellReportViewModel model = new CellReportViewModel();
            model.CellList = DropDownHelper.GetCellList();
            //TempData["CellList"] = model.CellList;
            ViewBag.Back = false;
            return View();
        }
    }
}