using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LandWeb.Models;

namespace LandWeb.Controllers
{
    [Authorize]
    public class CAController : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {
            List<CAMember> dtList = new List<CAMember>();
            ViewBag.ShowSearchResult = "display:none;";

            return View(dtList);
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Index(string Search)
        {
            List<CAMember> dtList = new List<CAMember>();

            if (!Search.Equals(""))
            {
                ViewBag.ShowSearchResult = "display:block;";
                CAMemberContext ctxt = new CAMemberContext();
                DataSet dsList = ctxt.GetMember(Search);
                dtList = dsList.Tables["members"].AsEnumerable().Select(m => new CAMember()
                {
                    Id = m.Field<int>("id"),
                    FullName = m.Field<string>("username"),
                    BirthDate = (m.Field<DateTime>("birthday")).ToString("MMM yyyy")
                }).ToList();

                if (dtList.Count == 0)
                    ViewBag.ShowSearchError = "display:block;";
                else
                    ViewBag.ShowSearchError = "display:none;";
            }
            else
            {
                ViewBag.ShowSearchError = "display:none;";
                ViewBag.ShowSearchResult = "display:none;";
            }

            ViewBag.Search = Search;
            return View(dtList);
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult CAList(string id = null)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            int nMemberId = 0;
            if (!Int32.TryParse(id, out nMemberId)) nMemberId = 0;
            List<CACourse> dtList = new List<CACourse>();
            {
                CAMemberContext ctxt = new CAMemberContext();
                DataSet dsList = ctxt.GetMember(nMemberId);
                if (dsList.Tables.Contains("members") && dsList.Tables["members"].Rows.Count == 1)
                {
                    DataRow drMember = dsList.Tables["members"].Rows[0];
                    ViewBag.MemberId = drMember["id"].ToString();
                    ViewBag.FullName = drMember["fullname"].ToString();
                    ViewBag.CellPhone = drMember["cell"].ToString();
                    ViewBag.Email = drMember["email"].ToString();
                }
            }
            {
                CACourseContext ctxt = new CACourseContext();
                DataSet dsList = ctxt.GetAvailableCourse(nMemberId);
                dtList = dsList.Tables["courses"].AsEnumerable().Select(m => new CACourse()
                {
                    Code = m.Field<int>("code"),
                    CourseCode = m.Field<string>("course_code"),
                    YearNo = m.Field<int?>("year_no"),
                    SemesterNo = m.Field<int?>("semester_no"),
                    Name = m.Field<string>("name"),
                    TeacherName = m.Field<string>("teacher_name"),
                    StartDate = m.Field<DateTime>("start_date").ToString("MM/dd/yy"),
                    StartTime = m.Field<string>("start_time"),
                    DayOfWeek = m.Field<int?>("day_of_week"),
                    DayOfWeekName = m.Field<string>("day_of_week_name"),
                    DurationHour = m.Field<decimal?>("duration_hour"),
                    LecturePeriodWeek = m.Field<int?>("lecture_period_week"),
                    EndDate = m.Field<DateTime>("end_date").ToString("MM/dd/yy"),
                    Credit = m.Field<decimal?>("credit"),
                    Difficulty = m.Field<string>("difficulty"),
                    PrerequisiteCourseId = m.Field<int?>("prerequisite_course_id"),
                    ActiveYN = m.Field<string>("active_yn"),
                    //CraeteDate = m.Field<DateTime>("create_date"),
                    //CreateBy = m.Field<string>("create_by"),
                    //UpdateDate = m.Field<DateTime>("update_date"),
                    //UpdateBy = m.Field<string>("update_by"),
                    //DeleteDate = m.Field<DateTime?>("delete_date"),
                    //DeleteBy = m.Field<string>("delete_by"),
                    Requested = m.Field<string>("requestyn").Equals("Y") ? "checked='checked'" : "",
                    //RequestDate = m.Field<DateTime?>("requestdate")
                }).ToList();
            }

            string strErrMsg = Request.QueryString["ErrMsg"] ?? "";
            if (!strErrMsg.Equals(""))
            {
                ViewBag.ShowSaveResult = "display:block;";
                ViewBag.SaveResult = strErrMsg;
            }

            return View(dtList);
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult CAList(FormCollection formCollection)
        {
            int nMemberId = 0;
            string strMemberId = (formCollection["memberid"] ?? "").ToString();
            if (!Int32.TryParse(strMemberId, out nMemberId))
            {

            }

            string strCheckedCourses = "";
            foreach (string key in formCollection.AllKeys)
            {
                int nCourseId = 0;
                if (key.StartsWith("course_") && Int32.TryParse(key.Substring(7), out nCourseId))
                {
                    strCheckedCourses += (strCheckedCourses.Equals("") ? "" : ",") + key.Substring(7);
                }
            }

            {
                CACourseContext ctxt = new CACourseContext();
                string strRetVal = ctxt.SetMemberCourse(nMemberId, strCheckedCourses);
                if (!strRetVal.Equals("OK"))
                    return RedirectToAction("CAList", new { id = nMemberId, ErrMsg = strRetVal });
            }

            List<CACourse> dtList = new List<CACourse>();
            {
                CAMemberContext ctxt = new CAMemberContext();
                DataSet dsList = ctxt.GetMember(nMemberId);
                if (dsList.Tables.Contains("members") && dsList.Tables["members"].Rows.Count == 1)
                {
                    DataRow drMember = dsList.Tables["members"].Rows[0];
                    ViewBag.MemberId = drMember["id"].ToString();
                    ViewBag.FullName = drMember["fullname"].ToString();
                    ViewBag.CellPhone = drMember["cell"].ToString();
                    ViewBag.Email = drMember["email"].ToString();
                }
            }
            {
                CACourseContext ctxt = new CACourseContext();
                DataSet dsList = ctxt.GetAvailableCourse(nMemberId);
                dtList = dsList.Tables["courses"].AsEnumerable().Select(m => new CACourse()
                {
                    Code = m.Field<int>("code"),
                    CourseCode = m.Field<string>("course_code"),
                    YearNo = m.Field<int?>("year_no"),
                    SemesterNo = m.Field<int?>("semester_no"),
                    Name = m.Field<string>("name"),
                    TeacherName = m.Field<string>("teacher_name"),
                    StartDate = m.Field<DateTime>("start_date").ToString("MM/dd/yy"),
                    StartTime = m.Field<string>("start_time"),
                    DayOfWeek = m.Field<int?>("day_of_week"),
                    DayOfWeekName = m.Field<string>("day_of_week_name"),
                    DurationHour = m.Field<decimal?>("duration_hour"),
                    LecturePeriodWeek = m.Field<int?>("lecture_period_week"),
                    EndDate = m.Field<DateTime>("end_date").ToString("MM/dd/yy"),
                    Credit = m.Field<decimal?>("credit"),
                    Difficulty = m.Field<string>("difficulty"),
                    PrerequisiteCourseId = m.Field<int?>("prerequisite_course_id"),
                    ActiveYN = m.Field<string>("active_yn"),
                    //CraeteDate = m.Field<DateTime>("create_date"),
                    //CreateBy = m.Field<string>("create_by"),
                    //UpdateDate = m.Field<DateTime>("update_date"),
                    //UpdateBy = m.Field<string>("update_by"),
                    //DeleteDate = m.Field<DateTime?>("delete_date"),
                    //DeleteBy = m.Field<string>("delete_by"),
                    //Requested = m.Field<string>("requestyn").Equals("Y") ? "checked='checked'" : "",
                    //RequestDate = m.Field<DateTime?>("requestdate")
                }).ToList();
            }
            ViewBag.ShowSaveResult = "display:block;";
            ViewBag.SaveResult = "성공적으로 저장하였습니다";
            ViewBag.SelectedCourses = strCheckedCourses;
            return View(dtList);
        }
    }
}