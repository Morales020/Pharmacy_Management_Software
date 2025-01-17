﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data; 


namespace Medical_Store_Management_SoftWare
{
    class CurrentTransaction_DB
    {
        public string Item
        {
            get;
            set;
        }
        public string Quantity
        {
            get;
            set;
        }
        public string Price
        {
            get;
            set;
        }
        public string PayPrice
        {
            get;
            set;
        }
        public int Item_ID
        {
            get;
            set;
        }
        public int Customer_ID
        {
            get;
            set;
        }


        public int getprice(string item)
        {
            string query = String.Format("select Price from StorageInfo where Item= '{0}'", item); 
            Business_Logic BL = new Business_Logic();
            SqlDataReader rec = BL.SelectQuery(query); // datareader only fetches one record at a time, so loop used.
            while (rec.Read())
            {
                return Convert.ToInt32(rec[0].ToString());
            }
            return 0;
        }


        public void addtransaction(CurrentTransaction_DB sDB)
        {
           
            string query = String.Format("Insert into CurrentTransaction Values({0},{1},{2},'{3}')",sDB.Quantity, sDB.Price, sDB.PayPrice, sDB.Item);
            Business_Logic BL = new Business_Logic();
            BL.NonQuery(query);
        }
        public void deletetransaction(CurrentTransaction_DB sDB)
        {
            string query = String.Format("delete CurrentTransaction", sDB.Item);
            Business_Logic BL = new Business_Logic();
            BL.NonQuery(query);
        }
        public int summer()
        {
            string query = "select SUM(PayPrice) from CurrentTransaction";
            Business_Logic BL = new Business_Logic();
            SqlDataReader rec = BL.SelectQuery(query); // datareader only fetches one record at a time, so loop used.
            while (rec.Read())
            {
                return Convert.ToInt32(rec[0].ToString());
               
            }

            return 0;

        }
        public void empty()
        {
            string query = "DELETE  FROM CurrentTransaction";
            Business_Logic BL = new Business_Logic();
            BL.NonQuery(query);
        }

        public void FillGrid(DataGridView GV)
        {
            string query = "select * from CurrentTransaction";
            Business_Logic BBL = new Business_Logic();
            DataSet ds = BBL.Adapter(query);
            GV.DataSource = ds.Tables[0];
        }
       
    }
}

