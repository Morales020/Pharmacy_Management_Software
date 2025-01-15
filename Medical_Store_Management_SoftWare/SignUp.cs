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
    public partial class SignUp : Form
    {
        String A, B, C;
        bool D, E;

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void txt_confirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "yyyy-mm-dd")
            {
                textBox1.Text= string.Empty;
            }
        }


        public SignUp(String a,String b,String c, bool d, bool e)
        {
            InitializeComponent();
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            Credential_DB cDB = new Credential_DB();
            cDB.Name = A;
            cDB.UserName = B;
            if (C == txt_confirmpassword.Text)
            {
                cDB.Password = C;
            }
            if (D == true)
            {
                cDB.UserType = "Owner";
            }
            else if (E == true)
            {
                cDB.UserType = "Staff";
            }
            if(radioButton1.Checked == true)
            {
                cDB.Gender = "Male";
            }
            else if (radioButton2.Checked == true)
            {
                cDB.Gender = "Female";

            }
            if(textBox1.Text !=" ")
            {
                cDB.DateOfBirth = textBox1.Text;
            }
            if (C == txt_confirmpassword.Text)
            {
                cDB.createnewuser(cDB);
                MessageBox.Show("New User Created");
            }
            else
            {
                MessageBox.Show("Re-Enter! Password Does Not Match");
                
            }
            this.Dispose();
        }
    }
}
