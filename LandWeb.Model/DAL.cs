using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LandWeb.Model;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;

namespace LandWeb.Model
{
    public class DAL
    {
        UnitOfWork unitOfWork;
        ChodaeEntities context;
        ObjectParameter frk_n4ErrorCode;
        ObjectParameter frk_strErrorText;

        public DAL()
        {
            context = new ChodaeEntities();
            frk_n4ErrorCode = new ObjectParameter("frk_n4ErrorCode", typeof(int));
            frk_strErrorText = new ObjectParameter("frk_strErrorText", typeof(String));
        }

        public bool Login(string username, string password)
        {
            unitOfWork = new UnitOfWork();
            var results = unitOfWork.UserRepository.Get();
            return (results.Where(a => a.username == username && a.password == password).Count() > 0);

        }
        public IEnumerable<member_list_Result> GetMembers(DateTime? start = null, DateTime? end = null, int id = 0, string name = null)
        {
            //unitOfWork = new UnitOfWork();
            //return unitOfWork.MemberRepository.Get()
            
            //var results = context.member_list(frk_n4ErrorCode, frk_strErrorText, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (start != null)
            {
                return context.member_list(frk_n4ErrorCode, frk_strErrorText, false, 0, null, null, null, null, null, 0, 0, null, null, 0, -1, 0, null, null, ((DateTime)start).Date, ((DateTime)end).Date, 0, 0, null, null, -1, 0, 0, -1, null, null);
            }
            else if (id != 0)
            {
                return context.member_list(frk_n4ErrorCode, frk_strErrorText, false, id, null, null, null, null, null, 0, 0, null, null, 0, -1, 0, null, null, null, null, 0, 0, null, null, -1, 0, 0, -1, null, null);
            }
            else if (name != null)
            {
                return context.member_list(frk_n4ErrorCode, frk_strErrorText, false, 0, name, null, null, null, null, 0, 0, null, null, 0, -1, 0, null, null, null, null, 0, 0, null, null, -1, 0, 0, -1, null, null);
            }
            else
            {
                return context.member_list(frk_n4ErrorCode, frk_strErrorText, false, 0, null, null, null, null, null, 0, 0, null, null, 0, -1, 0, null, null, null, null, 0, 0, null, null, -1, 0, 0, -1, null, null);
            }
        }

        public IEnumerable<justdates_Result> GetMembersTest(DateTime? start = null, DateTime? end = null)
        {
            return context.justdates(((DateTime)start).Date, ((DateTime)end).Date);
        }

        public IEnumerable<family_get_Result> GetFamily(int id)
        {

            return context.family_get(frk_n4ErrorCode, frk_strErrorText, null, id);
        }

        public IEnumerable<member_get_Result> GetMember(int id)
        {
            return context.member_get(frk_n4ErrorCode, frk_strErrorText, null, id);
        }

        public IEnumerable<subdivision_list_Result> GetSubDivisions()
        {;
            return context.subdivision_list(frk_n4ErrorCode, frk_strErrorText, null);
        }

        public IEnumerable<type_baptism_list_Result> GetBaptismTypes()
        {
            return context.type_baptism_list(frk_n4ErrorCode, frk_strErrorText, null);
        }

        public IEnumerable<type_job_list_Result> GetJobTypes()
        {
            return context.type_job_list(frk_n4ErrorCode, frk_strErrorText, null);
        }

        public IEnumerable<address_get_Result> GetAddress(int addressID)
        {
            return context.address_get(frk_n4ErrorCode, frk_strErrorText, null, addressID);
        }

        public IEnumerable<type_status_get_Result> GetStatus()
        {
            return context.type_status_get(frk_n4ErrorCode, frk_strErrorText, null);
        }

        public IEnumerable<type_entry_list_Result> GetEntryTypes()
        {
            return context.type_entry_list(frk_n4ErrorCode, frk_strErrorText, null);
        }

        public IEnumerable<visits_Result> GetVisits(int memberID)
        {
            return context.visits(frk_n4ErrorCode, frk_strErrorText, memberID);
        }

        public IEnumerable<member_get1_Result> GetFellowships(int memberID)
        {
            return context.member_get1(frk_n4ErrorCode, frk_strErrorText, null, (int)memberID);
        }

        public IEnumerable<member_get2_Result> GetCells(int memberID)
        {
            return context.member_get2(frk_n4ErrorCode, frk_strErrorText, null, (int)memberID);
        }

        public IEnumerable<comment_list_Result> GetComments(int memberID)
        {
            return context.comment_list(frk_n4ErrorCode, frk_strErrorText, null, (int)memberID);
        }

        public IEnumerable<member_get11_Result> GetCourses(int memberID)
        {
            var courses = context.member_get11(frk_n4ErrorCode, frk_strErrorText, null, (int)memberID).ToList();
            var courseList = context.course_list(frk_n4ErrorCode, frk_strErrorText, null).ToList();

            foreach (var c in courses)
            {
                c.CourseName = courseList.Where(a => a.code == c.course_code).FirstOrDefault().name;
            }

            return courses;
        }

        public IEnumerable<member_get4_Result> GetMinistries(int memberID)
        {
            var ministries = context.member_get4(frk_n4ErrorCode, frk_strErrorText, null, (int)memberID).ToList();
            var ministryList = context.ministry_get(frk_n4ErrorCode, frk_strErrorText, null).ToList();
            var roleList = context.ministry_role_get(frk_n4ErrorCode, frk_strErrorText, null).ToList();


            foreach (var m in ministries)
            {
                m.MinistryName = ministryList.Where(a => a.code == m.ministry_code).FirstOrDefault().name;
                m.MinistryRole = roleList.Where(a => a.code == m.role_code).FirstOrDefault().name;
            }
            return ministries;
        }

        public IEnumerable<cell_list_Result> GetCellList()
        {
            return context.cell_list(frk_n4ErrorCode, frk_strErrorText, null);
        }

        public IEnumerable<report_list_Result> GetReportList(int code)
        {
            return context.report_list(frk_n4ErrorCode, frk_strErrorText, null, code, null, null, null);
        }

        public report_get_Result GetReportDetail(int ID)
        {
            return context.report_get(frk_n4ErrorCode, frk_strErrorText, null, ID).FirstOrDefault();
        }

        public IEnumerable<reportdetailweb_get_Result> GetReportDetailMembers(int ID)
        {
            return context.reportdetailweb_get(frk_n4ErrorCode, frk_strErrorText, null, ID, null);
        }

        //public IEnumerable<login_Result> Login(string username, string password)
        //{
        //    return context.login(frk_n4ErrorCode, frk_strErrorText, null, username, password);
        //}
    }
}
