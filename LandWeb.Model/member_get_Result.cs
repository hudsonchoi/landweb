//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LandWeb.Model
{
    using System;
    
    public partial class member_get_Result
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string en_first_name { get; set; }
        public string en_last_name { get; set; }
        public string email { get; set; }
        public string cell { get; set; }
        public string work_phone { get; set; }
        public bool sex { get; set; }
        public Nullable<bool> married { get; set; }
        public Nullable<int> family_code { get; set; }
        public Nullable<byte> family_relationship { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public Nullable<System.DateTime> regdate { get; set; }
        public Nullable<int> address_id { get; set; }
        public Nullable<int> subdiv_id { get; set; }
        public Nullable<int> baptism_id { get; set; }
        public Nullable<System.DateTime> baptism_year { get; set; }
        public string job { get; set; }
        public Nullable<int> entrytype { get; set; }
        public Nullable<int> jobtype { get; set; }
        public Nullable<int> spouse { get; set; }
        public Nullable<bool> active { get; set; }
        public string row_status { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public string create_by { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public string update_by { get; set; }
        public byte[] lastchanged { get; set; }
        public int MemberId { get; set; }
        public Nullable<int> FellowshipCode { get; set; }
        public Nullable<int> CellCode { get; set; }
        public string FamilyName { get; set; }
        public Nullable<System.DateTime> FellowshipStartdate { get; set; }
        public Nullable<int> StatusCode { get; set; }
        public Nullable<System.DateTime> StatusChanged { get; set; }
        public string StatusName { get; set; }
        public string CellName { get; set; }
        public string FellowshipName { get; set; }
        public string Relationship { get; set; }
        public Nullable<int> CellRoleCode { get; set; }
        public string ministry { get; set; }
    }
}
