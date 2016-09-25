using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LandWeb.Model;
using System.Web.Mvc;


namespace LandWeb.Models
{
    public class CellReportViewModel
    {
        public CellReportViewModel()
        {
            From = DateTime.Now.AddMonths(-3);
            To = DateTime.Now;
        }
        public string CellCode { get; set; }
        public SelectList CellList { get; set; }
        public IEnumerable<report_list_Result> Reports { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}