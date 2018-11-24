using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LandWeb.Models
{
    public class CAMember
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string EngFirstName { get; set; }
        public string EngLastName { get; set; }
        public string Email { get; set; }
        public string CellPhoneNo { get; set; }
        public string WorkPhoneNo { get; set; }
        public string Gender { get; set; }
        public string MarriedYN { get; set; }
        public string BirthDate { get; set; }
        public int SpouseId { get; set; }
    }
}