using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Medical_Store_Management_SoftWare
{
    class Business_Logic
    {
        SqlConnection cn;
        SqlCommand cmd;
        public void OpenConnection()
        {
            string constring = ConfigurationManager.ConnectionStrings["constr"].ToString();
            //"Provider=Microsoft.ACE.Sql.12.0;Data Source=E:/Dotnet_DataBase/Database.accdb";
            cn = new SqlConnection(constring);
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }
        public void CloseConnection()
        {
            if (cn.State != ConnectionState.Closed)
            {
                cn.Close();
            }
        }
        public SqlDataReader SelectQuery(string query)
        {
            OpenConnection();
            cmd = new SqlCommand(query, cn);             // we can pass queries
            SqlDataReader rec = cmd.ExecuteReader();
            return rec;
        }
        public void NonQuery(string query)
        {
            OpenConnection();
            cmd = new SqlCommand(query, cn);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public DataSet Adapter(string query)
        {
            OpenConnection();
            cmd = new SqlCommand(query, cn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            CloseConnection();  //"disconnected database access". database only connected when used.
            return ds;
        }
    }
}
