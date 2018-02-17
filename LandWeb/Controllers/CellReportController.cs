using LandWeb.Model;
using LandWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HiQPdf;
using System.IO;

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
            return View(GetReport(cellCode));
        }

        public ActionResult ExportToPDF(int? cellCode)
        {

            string htmlToConvert = RenderViewAsString("ExportTOPDF", GetReport(cellCode));

            HtmlToPdf htmlToPdfConverter = new HtmlToPdf();

            byte[] pdfBuffer = htmlToPdfConverter.ConvertHtmlToMemory(htmlToConvert, null);

            FileResult fileResult = new FileContentResult(pdfBuffer, "application/pdf");
            fileResult.FileDownloadName = "AboutMvcViewToPdf.pdf";

            return fileResult;

            //return View(GetReport(cellCode));
        }

        public string RenderViewAsString(string viewName, object model)
        {
            // create a string writer to receive the HTML code
            StringWriter stringWriter = new StringWriter();

            // get the view to render
            ViewEngineResult viewResult = ViewEngines.Engines.FindView(ControllerContext, viewName, null);
            // create a context to render a view based on a model
            ViewContext viewContext = new ViewContext(
                    ControllerContext,
                    viewResult.View,
                    new ViewDataDictionary(model),
                    new TempDataDictionary(),
                    stringWriter
                    );

            // render the view to a HTML code
            viewResult.View.Render(viewContext, stringWriter);

            // return the HTML code
            return stringWriter.ToString();
        }

        public CellReportDetailViewModel GetReport (int? cellCode = null)
        {
            DAL dal = new DAL();
            CellReportDetailViewModel model = new CellReportDetailViewModel();
            model.Report = dal.GetReportDetail((int)cellCode);
            model.Members = dal.GetReportDetailMembers((int)cellCode);
            return model;
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