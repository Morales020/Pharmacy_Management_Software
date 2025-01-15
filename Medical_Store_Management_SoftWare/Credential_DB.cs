using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Medical_Store_Management_SoftWare
{

    class Credential_DB
    {
        public string User_ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public string UserType
        {
            get;
            set;
        }
        public string DateOfBirth
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }
        public string Phone
        {
            get;
            set;
        }
        public bool Authenticate(Credential_DB cDB)
        {
            string query = String.Format("select * from UserDetails where UserName = '{0}' and Password ='{1}' and UserType ='{2}'", cDB.UserName, cDB.Password, cDB.UserType);
            Business_Logic BL = new Business_Logic();
            SqlDataReader rec = BL.SelectQuery(query);
            if (rec.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void createnewuser(Credential_DB cDB)
        {
            string query = String.Format("Insert into UserDetails Values('{0}','{1}','{2}', '{3}','{4}','{5}',{6})", cDB.Name, cDB.UserName, cDB.Password, cDB.UserType, cDB.DateOfBirth, cDB.Gender,cDB.Phone);
            Business_Logic BL = new Business_Logic();
            BL.NonQuery(query);
            }
            public void changemypassword(Credential_DB cDB)
            {
                string query = String.Format("UPDATE UserDetails SET Password = '{0}' WHERE UserName = '{1}' AND UserType = '{2}' ", cDB.Password, cDB.UserName, cDB.UserType);
                Business_Logic BL = new Business_Logic();
                BL.NonQuery(query);

            }
            public void fillcombobox(ComboBox CB)
            {
                string query = "select UserName from UserDetails where UserType= 'Staff'"; //direct query so , simply used.
                Business_Logic BL = new Business_Logic();
                SqlDataReader rec = BL.SelectQuery(query); // datareader only fetches one record at a time, so loop used.
                while (rec.Read())
                {
                    CB.Items.Add(rec[0].ToString());
                }


            }
        public void fillcombobox1(ComboBox CB)
        {
            string query = "select UserName from UserDetails";
            Business_Logic BL = new Business_Logic();
            SqlDataReader rec = BL.SelectQuery(query);
            while (rec.Read())
            {
                CB.Items.Add(rec[0].ToString());
            }
        }
        public void deleteuser(Credential_DB cDB)
            {
                string query = String.Format("delete from UserDetails where UserName = '{0}'", cDB.UserName);
                Business_Logic BL = new Business_Logic();
                BL.NonQuery(query);
            }

            public void FillGrid(DataGridView GV)
            {
                string query = "select * from UserDetails";
                Business_Logic BBL = new Business_Logic();
                DataSet ds = BBL.Adapter(query);
                GV.DataSource = ds.Tables[0];
            }
        public void searchFillGrid(DataGridView GV, Credential_DB cDB, String se)
        {
            if (se == "***All***")
            {
                string query = "select * from UserDetails";
                Business_Logic BBL = new Business_Logic();
                DataSet ds = BBL.Adapter(query);
                GV.DataSource = ds.Tables[0];
            }
            else
            {

                string query = String.Format("select * from UserDetails where UserName like '%"+se+"%' or Name like '%"+se+"%'");
                Business_Logic BBL = new Business_Logic();
                DataSet ds = BBL.Adapter(query);
                GV.DataSource = ds.Tables[0];
            }
        }

    }
    }

