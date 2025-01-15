using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_Store_Management_SoftWare
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet3.StorageInfo' table. You can move, or remove it, as needed.
            this.storageInfoTableAdapter.Fill(this.pharmacyDataSet3.StorageInfo);
            Storage_DB cDB = new Storage_DB();
            dataGridView1.AutoGenerateColumns = true;
            cDB.FillGrid(dataGridView1);
            cBox_Search.Items.Add("***All***");
            cDB.fillcombobox(cBox_Search);
            DataGridViewTextBoxColumn titleColumn =
            new DataGridViewTextBoxColumn();
            titleColumn.HeaderText = "Title";
            titleColumn.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
               
                MessageBox.Show("Record Updated");
            }
        }

        private void cBox_Search_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cBox_Search_TextChanged(object sender, EventArgs e)
        {

            Storage_DB sDB = new Storage_DB();
            dataGridView1.AutoGenerateColumns = true;
            sDB.searchFillGrid(dataGridView1, sDB, cBox_Search.Text);
        }
    }
}
