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
        public ActionResult Index(int? cellCode)
        {
            ViewBag.Back = true;
            return View(GetReportViewModel((int)cellCode));
        }

        public ActionResult Get(int? cellCode)
        {
            ViewBag.Back = true;
            return View("Index", GetReportViewModel((int)cellCode));
        }

        private CellReportViewModel GetReportViewModel(int cellCode)
        {
            CellReportViewModel model = new CellReportViewModel();
            SelectList cellList = DropDownHelper.GetCellList();
            foreach (var c in cellList)
            {
                if (c.Value == cellCode.ToString())
                    c.Selected = true;
            }
            model.CellList = cellList;
            DAL dal = new DAL();
            model.Reports = dal.GetReportList((int)cellCode).ToList();
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