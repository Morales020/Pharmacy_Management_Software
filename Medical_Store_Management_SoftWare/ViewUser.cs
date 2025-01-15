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
    public partial class ViewUser : Form
    {
        public ViewUser()
        {
            InitializeComponent();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            Credential_DB cDB = new Credential_DB();
            dataGridView1.AutoGenerateColumns = true;
            cDB.FillGrid(dataGridView1);
            cBox_Search.Items.Add("***All***");
            cDB.fillcombobox1(cBox_Search);
            DataGridViewTextBoxColumn titleColumn =
    new DataGridViewTextBoxColumn();
            titleColumn.HeaderText = "Title";
            titleColumn.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
        }

        private void cBox_Search_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBox_Search_TextChanged(object sender, EventArgs e)
        {
            Credential_DB cDB = new Credential_DB();
            dataGridView1.AutoGenerateColumns = true;

            cDB.searchFillGrid(dataGridView1, cDB, cBox_Search.Text);
        }
    }
}
