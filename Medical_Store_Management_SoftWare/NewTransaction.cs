using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_Store_Management_SoftWare
{
    public partial class NewTransaction : Form
    {
        int sum = 0;
        public NewTransaction()
        {
            
            InitializeComponent();
      
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewTransaction_Load(object sender, EventArgs e)
        {

            lbl_ShowDate.Text = DateTime.Now.ToString();
            Storage_DB sDB = new Storage_DB();
            sDB.fillcombobox(cBox_Item);
          
            CurrentTransaction_DB cTR = new CurrentTransaction_DB();
            dataGridView1.AutoGenerateColumns = true;
            cTR.FillGrid(dataGridView1);
            DataGridViewTextBoxColumn titleColumn =
      new DataGridViewTextBoxColumn();
            titleColumn.HeaderText = "Title";
            titleColumn.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

        }

        private void cBox_Item_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBox_Quantity.Items.Clear();
            Storage_DB sDB = new Storage_DB();
            sDB.fillcomboboxquantity(cBox_Quantity, cBox_Item.Text);
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            CurrentTransaction_DB cTR = new CurrentTransaction_DB();
            int price = cTR.getprice(cBox_Item.Text);
            int paid = price * (Convert.ToInt32(cBox_Quantity.Text));
            cTR.Item = cBox_Item.Text;
            cTR.Quantity = cBox_Quantity.Text;
            cTR.Price = price.ToString();
            cTR.PayPrice = paid.ToString();
            cTR.addtransaction(cTR);
            dataGridView1.AutoGenerateColumns = true;
            cTR.FillGrid(dataGridView1);
            sum = sum + paid;
            lbl_ShowBill.Text = sum.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            CurrentTransaction_DB cTR = new CurrentTransaction_DB();
            cTR.deletetransaction(cTR);
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            CurrentTransaction_DB cTR = new CurrentTransaction_DB();
            Transaction_DB tr = new Transaction_DB();
            int price = cTR.getprice(cBox_Item.Text);
            int paid = price * (Convert.ToInt32(cBox_Quantity.Text));
            sum = sum + paid;
            if (radioButton1.Checked == true)
            {
                tr.Gender = "Male";
            }
            if (radioButton2.Checked == true)
            {
                tr.Gender = "Female";
            }
            tr.Name = txt_Name.Text;
            tr.Mobile = txt_Mobile.Text;
            tr.PurchaseDate = lbl_ShowDate.Text;
            tr.TotalBill = sum.ToString();
            tr.addtransaction(tr);
            Bill b = new Bill();
            b.label5.Text = tr.Name;
            b.label6.Text = tr.Mobile;
            b.label7.Text = tr.PurchaseDate;
            b.label8.Text = tr.TotalBill;  

            string query = String.Format("UPDATE StorageInfo\r\nSET Quantity = StorageInfo.Quantity - CurrentTransaction.Quantity\r\nFROM CurrentTransaction\r\nJOIN StorageInfo ON CurrentTransaction.Item = StorageInfo.Item and CurrentTransaction.Quantity <= StorageInfo.Quantity");
            Business_Logic BL = new Business_Logic();
            BL.NonQuery(query);


            this.Close();
            b.Show();
            cTR.empty();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
