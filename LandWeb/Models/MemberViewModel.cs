using LandWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LandWeb.Models
{
    public class MemberViewModel
    {
        public IEnumerable<family_get_Result> Photos { get; set; }
        public member_get_Result Member { get; set; }
        public string SubDivision { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RegDate { get; set; }
        public string Sex { get; set; }
        public string Married { get; set; }
        public string Baptism { get; set; }
        public string BaptismDate { get; set; }
        public string JobType { get; set; }

        //Address information 
        public address_get_Result Address { get; set; }

        //Additional Information
        public string Status { get; set; }
        public DateTime StatusChanged { get; set; }

        public string EntryType { get; set;}

        public string Fellowship { get; set;}

        public bool ShowVisits { get; set; }

        public IEnumerable<visits_Result> Visits { get; set; }

        public IEnumerable<member_get1_Result> Fellowships { get; set; }

        public IEnumerable<member_get2_Result> Cells { get; set; }

        public IEnumerable<comment_list_Result> Comments { get; set; }

        public IEnumerable<member_get11_Result> Courses { get; set; }

        public IEnumerable<member_get4_Result> Ministries { get; set; }

        //public int colCtrl
        //{
        //    get {
        //        switch (Photos.Count())
        //        {
        //            case 1: return 12;
        //                break;
        //            case 2: return 6;
        //                break;
        //            case 3: return 4;
        //                break;
        //            case 4: return 3;
        //                break;
        //            default: return 2;
        //        }
        //    }
        //}
    }
}