using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LandWeb.Models
{
    public class CACourse
    {
        public int Code { get; set; }
        [Display(Name = "Course Code")]
        public string CourseCode { get; set; }
        [Display(Name = "Year")]
        public int? YearNo { get; set; }
        [Display(Name = "Semester")]
        public int? SemesterNo { get; set; }
        [Display(Name = "Course Name")]
        public string Name { get; set; }
        [Display(Name = "Teacher")]
        public string TeacherName { get; set; }
        [Display(Name = "Start Date")]
        public string StartDate { get; set; }
        [Display(Name = "Start Time")]
        public string StartTime { get; set; }
        [Display(Name = "Day Of Week")]
        public int? DayOfWeek { get; set; }
        [Display(Name = "Weekday Name")]
        public string DayOfWeekName { get; set; }
        [Display(Name = "Duration")]
        public decimal? DurationHour { get; set; }
        [Display(Name = "Period")]
        public int? LecturePeriodWeek { get; set; }
        [Display(Name = "End Date")]
        public string EndDate { get; set; }
        [Display(Name = "Credit")]
        public decimal? Credit { get; set; }
        [Display(Name = "Difficulty")]
        public string Difficulty { get; set; }
        [Display(Name = "Prerequisite Course")]
        public int? PrerequisiteCourseId { get; set; }
        [Display(Name = "Active")]
        public string ActiveYN { get; set; }
        [Display(Name = "Craete Date")]
        public DateTime CraeteDate { get; set; }
        [Display(Name = "Create By")]
        public string CreateBy { get; set; }
        [Display(Name = "Update Date")]
        public DateTime UpdateDate { get; set; }
        [Display(Name = "Update By")]
        public string UpdateBy { get; set; }
        [Display(Name = "Delete Date")]
        public DateTime? DeleteDate { get; set; }
        [Display(Name = "Delete By")]
        public string DeleteBy { get; set; }
        [Display(Name = "Request")]
        public string Requested { get; set; }
        [Display(Name = "Request Date")]
        public DateTime? RequestDate { get; set; }
    }
}