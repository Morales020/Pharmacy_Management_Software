﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_Store_Management_SoftWare
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Credential_DB cDB = new Credential_DB();
            cDB.Name = txt_Name.Text;
            cDB.UserName = txt_UserName.Text;
            cDB.Phone = textBox1.Text;
            if (txt_Password.Text == txt_ConfirmPassword.Text)
            {
                cDB.Password = txt_Password.Text;
            }
            cDB.UserType = cBox_UserType.Text;
            if(radioButton1.Checked == true)
            {
                cDB.Gender = "Male";
            }
            else if (radioButton2.Checked == true)
            {
                cDB.Gender = "Female";
            }
            if (txt_Password.Text == txt_ConfirmPassword.Text)
            {
                cDB.createnewuser(cDB);
                MessageBox.Show("New User Created");
            }
            else
            {
                MessageBox.Show("Re-Enter! Password Does Not Match");
            }
        }

        private void cBox_UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
