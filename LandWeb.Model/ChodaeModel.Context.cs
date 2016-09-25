﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ChodaeEntities : DbContext
    {
        public ChodaeEntities()
            : base("name=ChodaeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<member> members { get; set; }
        public virtual DbSet<users_master> users_master { get; set; }
    
        public virtual ObjectResult<member_list_Result> member_list(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> memberid, string fullname, string firstName, string lastName, string enFirstName, string enLastName, Nullable<int> agefrom, Nullable<int> ageto, string city, string state, Nullable<int> baptismId, Nullable<int> sex, Nullable<int> subDivision, Nullable<System.DateTime> baptismFrom, Nullable<System.DateTime> baptismTo, Nullable<System.DateTime> regfrom, Nullable<System.DateTime> regto, Nullable<int> status, Nullable<int> jobtype, Nullable<System.DateTime> birthfrom, Nullable<System.DateTime> birthto, Nullable<int> married, Nullable<int> relationship, Nullable<int> fellowship, Nullable<int> active, string home, string cellPhone)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var memberidParameter = memberid.HasValue ?
                new ObjectParameter("memberid", memberid) :
                new ObjectParameter("memberid", typeof(int));
    
            var fullnameParameter = fullname != null ?
                new ObjectParameter("fullname", fullname) :
                new ObjectParameter("fullname", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var enFirstNameParameter = enFirstName != null ?
                new ObjectParameter("enFirstName", enFirstName) :
                new ObjectParameter("enFirstName", typeof(string));
    
            var enLastNameParameter = enLastName != null ?
                new ObjectParameter("enLastName", enLastName) :
                new ObjectParameter("enLastName", typeof(string));
    
            var agefromParameter = agefrom.HasValue ?
                new ObjectParameter("agefrom", agefrom) :
                new ObjectParameter("agefrom", typeof(int));
    
            var agetoParameter = ageto.HasValue ?
                new ObjectParameter("ageto", ageto) :
                new ObjectParameter("ageto", typeof(int));
    
            var cityParameter = city != null ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            var baptismIdParameter = baptismId.HasValue ?
                new ObjectParameter("baptismId", baptismId) :
                new ObjectParameter("baptismId", typeof(int));
    
            var sexParameter = sex.HasValue ?
                new ObjectParameter("sex", sex) :
                new ObjectParameter("sex", typeof(int));
    
            var subDivisionParameter = subDivision.HasValue ?
                new ObjectParameter("subDivision", subDivision) :
                new ObjectParameter("subDivision", typeof(int));
    
            var baptismFromParameter = baptismFrom.HasValue ?
                new ObjectParameter("baptismFrom", baptismFrom) :
                new ObjectParameter("baptismFrom", typeof(System.DateTime));
    
            var baptismToParameter = baptismTo.HasValue ?
                new ObjectParameter("baptismTo", baptismTo) :
                new ObjectParameter("baptismTo", typeof(System.DateTime));
    
            var regfromParameter = regfrom.HasValue ?
                new ObjectParameter("regfrom", regfrom) :
                new ObjectParameter("regfrom", typeof(System.DateTime));
    
            var regtoParameter = regto.HasValue ?
                new ObjectParameter("regto", regto) :
                new ObjectParameter("regto", typeof(System.DateTime));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(int));
    
            var jobtypeParameter = jobtype.HasValue ?
                new ObjectParameter("jobtype", jobtype) :
                new ObjectParameter("jobtype", typeof(int));
    
            var birthfromParameter = birthfrom.HasValue ?
                new ObjectParameter("birthfrom", birthfrom) :
                new ObjectParameter("birthfrom", typeof(System.DateTime));
    
            var birthtoParameter = birthto.HasValue ?
                new ObjectParameter("birthto", birthto) :
                new ObjectParameter("birthto", typeof(System.DateTime));
    
            var marriedParameter = married.HasValue ?
                new ObjectParameter("married", married) :
                new ObjectParameter("married", typeof(int));
    
            var relationshipParameter = relationship.HasValue ?
                new ObjectParameter("relationship", relationship) :
                new ObjectParameter("relationship", typeof(int));
    
            var fellowshipParameter = fellowship.HasValue ?
                new ObjectParameter("fellowship", fellowship) :
                new ObjectParameter("fellowship", typeof(int));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("active", active) :
                new ObjectParameter("active", typeof(int));
    
            var homeParameter = home != null ?
                new ObjectParameter("home", home) :
                new ObjectParameter("home", typeof(string));
    
            var cellPhoneParameter = cellPhone != null ?
                new ObjectParameter("cellPhone", cellPhone) :
                new ObjectParameter("cellPhone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<member_list_Result>("member_list", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, memberidParameter, fullnameParameter, firstNameParameter, lastNameParameter, enFirstNameParameter, enLastNameParameter, agefromParameter, agetoParameter, cityParameter, stateParameter, baptismIdParameter, sexParameter, subDivisionParameter, baptismFromParameter, baptismToParameter, regfromParameter, regtoParameter, statusParameter, jobtypeParameter, birthfromParameter, birthtoParameter, marriedParameter, relationshipParameter, fellowshipParameter, activeParameter, homeParameter, cellPhoneParameter);
        }
    
        public virtual ObjectResult<test_Result> test()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<test_Result>("test");
        }
    
        public virtual ObjectResult<justdates_Result> justdates(Nullable<System.DateTime> regfrom, Nullable<System.DateTime> regto)
        {
            var regfromParameter = regfrom.HasValue ?
                new ObjectParameter("regfrom", regfrom) :
                new ObjectParameter("regfrom", typeof(System.DateTime));
    
            var regtoParameter = regto.HasValue ?
                new ObjectParameter("regto", regto) :
                new ObjectParameter("regto", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<justdates_Result>("justdates", regfromParameter, regtoParameter);
        }
    
        public virtual ObjectResult<family_get_Result> family_get(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> memberid)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var memberidParameter = memberid.HasValue ?
                new ObjectParameter("memberid", memberid) :
                new ObjectParameter("memberid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<family_get_Result>("family_get", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, memberidParameter);
        }
    
        public virtual ObjectResult<member_get_Result> member_get(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> id)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<member_get_Result>("member_get", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, idParameter);
        }
    
        public virtual ObjectResult<subdivision_list_Result> subdivision_list(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<subdivision_list_Result>("subdivision_list", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter);
        }
    
        public virtual ObjectResult<type_baptism_list_Result> type_baptism_list(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<type_baptism_list_Result>("type_baptism_list", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter);
        }
    
        public virtual ObjectResult<type_job_list_Result> type_job_list(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<type_job_list_Result>("type_job_list", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter);
        }
    
        public virtual ObjectResult<address_get_Result> address_get(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> id)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<address_get_Result>("address_get", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, idParameter);
        }
    
        public virtual ObjectResult<type_status_list_Result> type_status_list(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<type_status_list_Result>("type_status_list", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter);
        }
    
        public virtual ObjectResult<type_status_get_Result> type_status_get(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<type_status_get_Result>("type_status_get", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter);
        }
    
        public virtual ObjectResult<type_entry_list_Result> type_entry_list(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<type_entry_list_Result>("type_entry_list", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter);
        }
    
        public virtual ObjectResult<fellowship_member_get_Result> fellowship_member_get(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> code, Nullable<bool> withHistory, Nullable<System.DateTime> from, Nullable<System.DateTime> to)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var codeParameter = code.HasValue ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(int));
    
            var withHistoryParameter = withHistory.HasValue ?
                new ObjectParameter("withHistory", withHistory) :
                new ObjectParameter("withHistory", typeof(bool));
    
            var fromParameter = from.HasValue ?
                new ObjectParameter("from", from) :
                new ObjectParameter("from", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("to", to) :
                new ObjectParameter("to", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<fellowship_member_get_Result>("fellowship_member_get", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, codeParameter, withHistoryParameter, fromParameter, toParameter);
        }
    
        public virtual ObjectResult<member_get1_Result> member_get1(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> memberid)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var memberidParameter = memberid.HasValue ?
                new ObjectParameter("memberid", memberid) :
                new ObjectParameter("memberid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<member_get1_Result>("member_get1", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, memberidParameter);
        }
    
        public virtual ObjectResult<visit_list_Result> visit_list(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> memberid, Nullable<int> cellCode, Nullable<int> visitType, Nullable<System.DateTime> from, Nullable<System.DateTime> to, string username)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var memberidParameter = memberid.HasValue ?
                new ObjectParameter("memberid", memberid) :
                new ObjectParameter("memberid", typeof(int));
    
            var cellCodeParameter = cellCode.HasValue ?
                new ObjectParameter("cellCode", cellCode) :
                new ObjectParameter("cellCode", typeof(int));
    
            var visitTypeParameter = visitType.HasValue ?
                new ObjectParameter("visitType", visitType) :
                new ObjectParameter("visitType", typeof(int));
    
            var fromParameter = from.HasValue ?
                new ObjectParameter("from", from) :
                new ObjectParameter("from", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("to", to) :
                new ObjectParameter("to", typeof(System.DateTime));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<visit_list_Result>("visit_list", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, memberidParameter, cellCodeParameter, visitTypeParameter, fromParameter, toParameter, usernameParameter);
        }
    
        public virtual ObjectResult<visit_list_web_Result> visit_list_web(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> memberid, Nullable<int> cellCode, Nullable<int> visitType, Nullable<System.DateTime> from, Nullable<System.DateTime> to, string username)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var memberidParameter = memberid.HasValue ?
                new ObjectParameter("memberid", memberid) :
                new ObjectParameter("memberid", typeof(int));
    
            var cellCodeParameter = cellCode.HasValue ?
                new ObjectParameter("cellCode", cellCode) :
                new ObjectParameter("cellCode", typeof(int));
    
            var visitTypeParameter = visitType.HasValue ?
                new ObjectParameter("visitType", visitType) :
                new ObjectParameter("visitType", typeof(int));
    
            var fromParameter = from.HasValue ?
                new ObjectParameter("from", from) :
                new ObjectParameter("from", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("to", to) :
                new ObjectParameter("to", typeof(System.DateTime));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<visit_list_web_Result>("visit_list_web", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, memberidParameter, cellCodeParameter, visitTypeParameter, fromParameter, toParameter, usernameParameter);
        }
    
        public virtual ObjectResult<visits_Result> visits(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<int> memberid)
        {
            var memberidParameter = memberid.HasValue ?
                new ObjectParameter("memberid", memberid) :
                new ObjectParameter("memberid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<visits_Result>("visits", frk_n4ErrorCode, frk_strErrorText, memberidParameter);
        }
    
        public virtual ObjectResult<member_get2_Result> member_get2(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> memberid)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var memberidParameter = memberid.HasValue ?
                new ObjectParameter("memberid", memberid) :
                new ObjectParameter("memberid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<member_get2_Result>("member_get2", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, memberidParameter);
        }
    
        public virtual ObjectResult<member_get11_Result> member_get11(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> memberid)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var memberidParameter = memberid.HasValue ?
                new ObjectParameter("memberid", memberid) :
                new ObjectParameter("memberid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<member_get11_Result>("member_get11", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, memberidParameter);
        }
    
        public virtual ObjectResult<comment_list_Result> comment_list(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> memberid)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var memberidParameter = memberid.HasValue ?
                new ObjectParameter("memberid", memberid) :
                new ObjectParameter("memberid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<comment_list_Result>("comment_list", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, memberidParameter);
        }
    
        public virtual ObjectResult<member_get4_Result> member_get4(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> memberid)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var memberidParameter = memberid.HasValue ?
                new ObjectParameter("memberid", memberid) :
                new ObjectParameter("memberid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<member_get4_Result>("member_get4", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, memberidParameter);
        }
    
        public virtual ObjectResult<course_get_Result> course_get(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<bool> active)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("active", active) :
                new ObjectParameter("active", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<course_get_Result>("course_get", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, activeParameter);
        }
    
        public virtual ObjectResult<course_get1_Result> course_get1(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<bool> active)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("active", active) :
                new ObjectParameter("active", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<course_get1_Result>("course_get1", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, activeParameter);
        }
    
        public virtual ObjectResult<course_get2_Result> course_get2(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<bool> active)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var activeParameter = active.HasValue ?
                new ObjectParameter("active", active) :
                new ObjectParameter("active", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<course_get2_Result>("course_get2", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, activeParameter);
        }
    
        public virtual ObjectResult<course_list_Result> course_list(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<course_list_Result>("course_list", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter);
        }
    
        public virtual ObjectResult<ministry_get_Result> ministry_get(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ministry_get_Result>("ministry_get", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter);
        }
    
        public virtual ObjectResult<ministry_role_get_Result> ministry_role_get(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ministry_role_get_Result>("ministry_role_get", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter);
        }
    
        public virtual ObjectResult<cell_list_Result> cell_list(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<cell_list_Result>("cell_list", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter);
        }
    
        public virtual ObjectResult<report_list_Result> report_list(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> code, Nullable<System.DateTime> from, Nullable<System.DateTime> to, string createby)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var codeParameter = code.HasValue ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(int));
    
            var fromParameter = from.HasValue ?
                new ObjectParameter("from", from) :
                new ObjectParameter("from", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("to", to) :
                new ObjectParameter("to", typeof(System.DateTime));
    
            var createbyParameter = createby != null ?
                new ObjectParameter("createby", createby) :
                new ObjectParameter("createby", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<report_list_Result>("report_list", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, codeParameter, fromParameter, toParameter, createbyParameter);
        }
    
        public virtual ObjectResult<report_get_Result> report_get(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> id)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<report_get_Result>("report_get", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, idParameter);
        }
    
        public virtual ObjectResult<reportdetail_get_Result> reportdetail_get(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> code, Nullable<bool> isNew)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var codeParameter = code.HasValue ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(int));
    
            var isNewParameter = isNew.HasValue ?
                new ObjectParameter("isNew", isNew) :
                new ObjectParameter("isNew", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<reportdetail_get_Result>("reportdetail_get", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, codeParameter, isNewParameter);
        }
    
        public virtual ObjectResult<reportdetailweb_get_Result> reportdetailweb_get(ObjectParameter frk_n4ErrorCode, ObjectParameter frk_strErrorText, Nullable<bool> frk_isRequiresNewTransaction, Nullable<int> code, Nullable<bool> isNew)
        {
            var frk_isRequiresNewTransactionParameter = frk_isRequiresNewTransaction.HasValue ?
                new ObjectParameter("frk_isRequiresNewTransaction", frk_isRequiresNewTransaction) :
                new ObjectParameter("frk_isRequiresNewTransaction", typeof(bool));
    
            var codeParameter = code.HasValue ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(int));
    
            var isNewParameter = isNew.HasValue ?
                new ObjectParameter("isNew", isNew) :
                new ObjectParameter("isNew", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<reportdetailweb_get_Result>("reportdetailweb_get", frk_n4ErrorCode, frk_strErrorText, frk_isRequiresNewTransactionParameter, codeParameter, isNewParameter);
        }
    }
}
