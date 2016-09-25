using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LandWeb.Model;
using LandWeb.Models;

namespace LandWeb.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            DashboardViewModel model = new DashboardViewModel();
            DAL dal = new DAL();
            return View(model);

        }

        [HttpPost]
        public ActionResult Index(int? ID = 0, string Name = null)
        {
            DashboardViewModel model = new DashboardViewModel();
            DAL dal = new DAL();
            model.Members = dal.GetMembers(null, null, (int)ID, Name);
            //model.Members = dal.GetMembers(Convert.ToDateTime("5/11/2016 12:00:00"), Convert.ToDateTime("5/26/2016 12:00:00"));

            return View(model);
        }

        public ActionResult Detail(int? ID)
        {
            MemberViewModel model = new MemberViewModel();
            DAL dal = new DAL();
            model.Photos = dal.GetFamily((int)ID).ToList();
            model.Member = dal.GetMember((int)ID).ToList().FirstOrDefault();
            model.SubDivision = dal.GetSubDivisions().ToList().Where(a => a.id == model.Member.subdiv_id).FirstOrDefault().name;
            model.RegDate = (DateTime)model.Member.regdate;
            model.Birthday = (DateTime)model.Member.birthday;
            model.Sex = model.Member.sex ? "남자" : "여자";
            model.Married = (bool)model.Member.married ? "기혼" : "미혼";
            if (model.Member.baptism_id != null && model.Member.baptism_id > 0)
                model.Baptism = dal.GetBaptismTypes().ToList().Where(a => a.id == model.Member.baptism_id).FirstOrDefault().name;
            if (model.Member.baptism_year != null)
                model.BaptismDate = ((DateTime)model.Member.baptism_year).ToShortDateString();
            if (model.Member.jobtype != null && model.Member.jobtype > 0)
                model.JobType = dal.GetJobTypes().ToList().Where(a => a.id == (int)model.Member.jobtype).FirstOrDefault().name;
            model.Address = dal.GetAddress(((int)model.Member.address_id)).ToList().FirstOrDefault();
            model.Status = dal.GetStatus().ToList().Where(a => a.id == (int)model.Member.StatusCode).FirstOrDefault().name;
            model.StatusChanged = (DateTime)model.Member.StatusChanged;
            if (model.Member.entrytype != null && model.Member.entrytype > 0)
                model.EntryType = dal.GetEntryTypes().ToList().Where(a => a.id == (int)model.Member.entrytype).FirstOrDefault().name;
            model.Visits = dal.GetVisits((int)ID).ToList();
            //int tmp = model.Visits.Count();
            model.Fellowships = dal.GetFellowships((int)ID).ToList();
            model.Cells = dal.GetCells((int)ID).ToList();
            model.Comments = dal.GetComments((int)ID).ToList();
            model.Courses = dal.GetCourses((int)ID).ToList();
            model.Ministries = dal.GetMinistries((int)ID).ToList();
            return View(model);

        }
    }
}