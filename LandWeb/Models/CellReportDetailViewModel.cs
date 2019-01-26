using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LandWeb.Model;

namespace LandWeb.Models
{
    public class CellReportDetailViewModel
    {
        public report_get_Result Report { get; set; }
        public IEnumerable<reportdetailweb_get1_Result> Members { get; set; }
    }
}