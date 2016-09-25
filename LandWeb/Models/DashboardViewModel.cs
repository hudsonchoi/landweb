using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LandWeb.Model;
using System.Web.Mvc;

namespace LandWeb.Models
{
    public class DashboardViewModel
    {
        private List<SelectListItem> registrationPeriodList;
        private SelectListItem item;
        public DashboardViewModel()
        {
            registrationPeriodList = new List<SelectListItem>();
            item = new SelectListItem { Text = "Last Two Weeks", Value = "0" };
            registrationPeriodList.Add(item);
            item = new SelectListItem { Text = "Last Four Weeks", Value = "1" };
            registrationPeriodList.Add(item);
            item = new SelectListItem { Text = "Last Six Months", Value = "2" };
            registrationPeriodList.Add(item);
        }

        public IEnumerable<member_list_Result> Members { get; set; }
        public List<SelectListItem> RegistrationPeriodList {
            get
            {
                return registrationPeriodList;
            }
        } 
    }
}