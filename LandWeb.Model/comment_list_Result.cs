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
    
    public partial class comment_list_Result
    {
        public int id { get; set; }
        public string comment { get; set; }
        public System.DateTime regdate { get; set; }
        public int memberid { get; set; }
        public string create_by { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public byte[] lastchanged { get; set; }
        public string row_status { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public string update_by { get; set; }
    }
}