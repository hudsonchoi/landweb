using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace LandWeb.Models
{
    public class CACourseContext
    {
        public DataSet GetAvailableCourse(int MemberId)
        {
            SqlConnection cnn = new SqlConnection(WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            cnn.Open();

            DataSet ds = new DataSet();
            try
            {
                {
                    string strSql = string.Format(@"
select c.code, c.course_code, c.year_no, c.semester_no, c.name, c.teacher_name, c.start_date, c.start_time,
       c.day_of_week,
       case c.day_of_week when 1 then N'일' when 2 then N'월' when 3 then N'화' when 4 then N'수' when 5 then N'목' when 6 then N'금'  when 7 then N'토' end as day_of_week_name,
       c.duration_hour, c.lecture_period_week, c.end_date, c.credit, c.difficulty, c.prerequisite_course_id,
       c.active_yn, c.create_date, c.create_by, c.update_date, c.update_by, c.delete_date, c.delete_by, c.lastchanged,
       case when mc.memberid is not null then 'Y' else 'N' end as requestyn
  from courses c
  left outer join member_course mc on mc.memberid = @MemberId and mc.course_code = c.code
 where c.end_date > getdate()
   and c.delete_date is null;");
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(strSql, cnn);
                    dataAdapter.SelectCommand.Parameters.Add("@MemberId", SqlDbType.Int).Value = MemberId;
                    dataAdapter.SelectCommand.CommandTimeout = 600;
                    dataAdapter.Fill(ds, "courses");
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                cnn.Close();
            }

            return ds;
        }

        public string SetMemberCourse(int nMemberId, string strCheckedCourses)
        {
            SqlConnection cnn = new SqlConnection(WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            cnn.Open();
            SqlTransaction stCNN = cnn.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                {
                    string strSql = string.Format(@"
update mc
   set delete_date = getdate(), delete_by = m.last_name + ' ' + m.first_name
  from member_course mc
 inner join members m on m.id = mc.memberid
 where mc.memberid = @MemberId
   and ',' + @CheckedCourses + ',' not like '%,' + convert(varchar, mc.course_code) + ',%'
   and mc.delete_date is null");
                    SqlCommand cmd = new SqlCommand(strSql, cnn, stCNN);
                    cmd.Parameters.Add("@MemberId", SqlDbType.Int).Value = nMemberId;
                    cmd.Parameters.Add("@CheckedCourses", SqlDbType.VarChar).Value = strCheckedCourses;
                    cmd.CommandTimeout = 300;
                    int nExec = cmd.ExecuteNonQuery();
                }
                foreach (string strCheckedCourse in strCheckedCourses.Split(','))
                {
                    int nCourseId = 0;
                    if (!Int32.TryParse(strCheckedCourse, out nCourseId)) continue;

                    string strSql = @"
update mc
   set update_date = getdate(), update_by = m.last_name + ' ' + m.first_name, delete_date = null, delete_by = null
  from member_course mc
 inner join members m on m.id = mc.memberid
 where mc.memberid = @MemberId and mc.course_code = @CourseId and mc.delete_date is not null;
insert into member_course (memberid, course_code, create_date, create_by, update_date, update_by, graduated)
select @MemberId, @CourseId,
       getdate() as create_date, m.last_name + ' ' + m.first_name as create_by,
       getdate() as update_date, m.last_name + ' ' + m.first_name as update_by,
       '1900-1-1'
  from members m
 where m.id = @MemberId
   and not exists (select * from member_course where memberid = @MemberId and course_code = @CourseId)";
                    SqlCommand cmd = new SqlCommand(strSql, cnn, stCNN);
                    cmd.Parameters.Add("@MemberId", SqlDbType.Int).Value = nMemberId;
                    cmd.Parameters.Add("@CourseId", SqlDbType.Int).Value = nCourseId;
                    cmd.CommandTimeout = 300;
                    int nExec = cmd.ExecuteNonQuery();
                }
                stCNN.Commit();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                cnn.Close();
            }
            return "OK";
        }
    }
}