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
    class Storage_DB
    {
        public string Item
        {
            get;
            set;
        }
        public string Manufacturer
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
        public string MonthOfProduction
        {
            get;
            set;
        }
        public string YearOfProduction
        {
            get;
            set;
        }
        public string MonthOfExpiration
        {
            get;
            set;
        }
        public string YearOfExpiration
        {
            get;
            set;
        }
        public void addproduct(Storage_DB sDB)
        {
            string query = String.Format("Insert into StorageInfo Values('{0}','{1}',{2}, {3},'{4}','{5}','{6}','{7}')",sDB.Item, sDB.Manufacturer, sDB.Quantity, sDB.Price,sDB.MonthOfProduction,sDB.YearOfProduction,sDB.MonthOfExpiration,sDB.YearOfExpiration);
            Business_Logic BL = new Business_Logic();
            BL.NonQuery(query);
        }
        public void deleteproduct(Storage_DB sDB)
        {
            string query = String.Format("delete from StorageInfo where Item = '{0}'", sDB.Item);
            Business_Logic BL = new Business_Logic();
            BL.NonQuery(query);
        }
        public void fillcombobox(ComboBox CB)
        {
            string query = "select Item from StorageInfo";
            Business_Logic BL = new Business_Logic();
            SqlDataReader rec = BL.SelectQuery(query);
            while (rec.Read())
            {
                CB.Items.Add(rec[0].ToString());
            }
        }

             public void fillcomboboxquantity(ComboBox CB,String item)
        {
            string query = String.Format("select Quantity from StorageInfo where Item= '{0}'", item ); 
            Business_Logic BL = new Business_Logic();
            SqlDataReader rec = BL.SelectQuery(query); 
            while (rec.Read())
            {
                CB.Items.Add(rec[0].ToString());
            }


        }
        public void searchFillGrid(DataGridView GV, Storage_DB sDB,String se)
        {
            if (se == "***All***")
            {
                string query = "select * from StorageInfo";
                Business_Logic BBL = new Business_Logic();
                DataSet ds = BBL.Adapter(query);
                GV.DataSource = ds.Tables[0];
            }
            else
            {

                string query = String.Format("select * from StorageInfo where Item  like '%"+ se +"%'");
                Business_Logic BBL = new Business_Logic();
                DataSet ds = BBL.Adapter(query);
                GV.DataSource = ds.Tables[0];
            }
        }

        public void FillGrid(DataGridView GV)
        {
            string query = "select * from StorageInfo";
            Business_Logic BBL = new Business_Logic();
            DataSet ds = BBL.Adapter(query);
            GV.DataSource = ds.Tables[0];
        }
        public void updateFillGrid(DataGridView GV)
        {
            string query = "select * from StorageInfo";
            Business_Logic BBL = new Business_Logic();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommandBuilder build = new SqlCommandBuilder(adapter);
            DataSet ds = BBL.Adapter(query);
            adapter.Update(ds);
            GV.DataSource = ds.Tables[0];
        }
    }
}
