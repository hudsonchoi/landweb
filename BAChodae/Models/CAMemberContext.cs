using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace LandWeb.Models
{
    public class CAMemberContext
    {
        public DataSet GetMember(string strSearch)
        {
            if (strSearch.Trim().Equals("")) return new DataSet();

            SqlConnection cnn = new SqlConnection(WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            cnn.Open();

            DataSet ds = new DataSet();
            try
            {
                {
                    string strSql = string.Format(@"
select m.id, m.first_name, m.last_name, m.last_name + ' ' + m.first_name as username, m.birthday
  from members m
  left outer join members sp on sp.id = m.spouse and m.sex = 0
 where (m.id = (case when try_parse(@Search as int using 'en-US') is not null then try_parse(@Search as int using 'en-US') end) or
        m.last_name + m.first_name = replace(@Search, ' ', '') or
        m.first_name + m.last_name = replace(@Search, ' ', '') or
        m.last_name + m.en_first_name = replace(@Search, ' ', '') or
        m.en_first_name + m.last_name = replace(@Search, ' ', '') or
        m.en_last_name + m.first_name = replace(@Search, ' ', '') or
        m.first_name + m.en_last_name = replace(@Search, ' ', '') or
        m.en_last_name + m.en_first_name = replace(@Search, ' ', '') or
        m.en_first_name + m.en_last_name = replace(@Search, ' ', '') or
        sp.last_name + m.first_name = replace(@Search, ' ', '') or
        m.first_name + sp.last_name = replace(@Search, ' ', '') or
        sp.last_name + m.en_first_name = replace(@Search, ' ', '') or
        m.en_first_name + sp.last_name = replace(@Search, ' ', '') or
        sp.en_last_name + m.first_name = replace(@Search, ' ', '') or
        m.first_name + sp.en_last_name = replace(@Search, ' ', '') or
        sp.en_last_name + m.en_first_name = replace(@Search, ' ', '') or
        m.en_first_name + sp.en_last_name = replace(@Search, ' ', ''));");
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(strSql, cnn);
                    dataAdapter.SelectCommand.Parameters.Add("@Search", SqlDbType.NVarChar).Value = strSearch;
                    dataAdapter.SelectCommand.CommandTimeout = 600;
                    dataAdapter.Fill(ds, "members");
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
        public DataSet GetMember(int Id)
        {
            SqlConnection cnn = new SqlConnection(WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            cnn.Open();

            DataSet ds = new DataSet();
            try
            {
                {
                    string strSql = string.Format(@"
select m.id, m.first_name, m.last_name, m.last_name + ' ' + m.first_name as fullname,
       m.en_first_name, m.en_last_name, m.email, m.cell, m.work_phone, m.sex, m.married, m.family_code, m.family_relationship,
       m.birthday, m.regdate, m.address_id, m.subdiv_id, m.baptism_id, m.baptism_year, m.job, m.entrytype, m.jobtype, m.spouse, m.active, m.row_status,
       m.create_date, m.create_by, m.update_date, m.update_by, m.lastchanged
  from members m
 where m.id = @Id;");
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(strSql, cnn);
                    dataAdapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                    dataAdapter.SelectCommand.CommandTimeout = 600;
                    dataAdapter.Fill(ds, "members");
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
    }
}