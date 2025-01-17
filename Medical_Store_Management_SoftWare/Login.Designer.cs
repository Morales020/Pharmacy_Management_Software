﻿namespace Medical_Store_Management_SoftWare
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_login = new System.Windows.Forms.Button();
            this.rbtn_staff = new System.Windows.Forms.RadioButton();
            this.rbtn_owner = new System.Windows.Forms.RadioButton();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.Hallmark = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-3, 84);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.splitContainer1.Panel2.Controls.Add(this.btn_login);
            this.splitContainer1.Panel2.Controls.Add(this.rbtn_staff);
            this.splitContainer1.Panel2.Controls.Add(this.rbtn_owner);
            this.splitContainer1.Panel2.Controls.Add(this.btn_reset);
            this.splitContainer1.Panel2.Controls.Add(this.txt_password);
            this.splitContainer1.Panel2.Controls.Add(this.txt_username);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_username);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_password);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(748, 393);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_login.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.Location = new System.Drawing.Point(168, 301);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(160, 54);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // rbtn_staff
            // 
            this.rbtn_staff.AutoSize = true;
            this.rbtn_staff.ForeColor = System.Drawing.Color.Indigo;
            this.rbtn_staff.Location = new System.Drawing.Point(312, 220);
            this.rbtn_staff.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_staff.Name = "rbtn_staff";
            this.rbtn_staff.Size = new System.Drawing.Size(64, 22);
            this.rbtn_staff.TabIndex = 4;
            this.rbtn_staff.TabStop = true;
            this.rbtn_staff.Text = "Staff";
            this.rbtn_staff.UseVisualStyleBackColor = true;
            // 
            // rbtn_owner
            // 
            this.rbtn_owner.AutoSize = true;
            this.rbtn_owner.ForeColor = System.Drawing.Color.Indigo;
            this.rbtn_owner.Location = new System.Drawing.Point(110, 220);
            this.rbtn_owner.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_owner.Name = "rbtn_owner";
            this.rbtn_owner.Size = new System.Drawing.Size(78, 22);
            this.rbtn_owner.TabIndex = 3;
            this.rbtn_owner.TabStop = true;
            this.rbtn_owner.Text = "Owner";
            this.rbtn_owner.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_reset.Location = new System.Drawing.Point(24, 348);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(109, 29);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(218, 142);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '@';
            this.txt_password.Size = new System.Drawing.Size(200, 24);
            this.txt_password.TabIndex = 9;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(218, 55);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(200, 24);
            this.txt_username.TabIndex = 8;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_username.Location = new System.Drawing.Point(20, 55);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(145, 24);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "User Name :";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_password.Location = new System.Drawing.Point(35, 142);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(130, 24);
            this.lbl_password.TabIndex = 5;
            this.lbl_password.Text = "Password :";
            this.lbl_password.Click += new System.EventHandler(this.lbl_password_Click);
            // 
            // Hallmark
            // 
            this.Hallmark.AutoSize = true;
            this.Hallmark.BackColor = System.Drawing.Color.Transparent;
            this.Hallmark.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hallmark.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Hallmark.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Hallmark.Location = new System.Drawing.Point(13, 9);
            this.Hallmark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hallmark.Name = "Hallmark";
            this.Hallmark.Size = new System.Drawing.Size(681, 62);
            this.Hallmark.TabIndex = 2;
            this.Hallmark.Text = "    Natural Medical Hall    ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(745, 474);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Hallmark);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label Hallmark;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_reset;
        public System.Windows.Forms.RadioButton rbtn_staff;
        public System.Windows.Forms.RadioButton rbtn_owner;
        public System.Windows.Forms.TextBox txt_password;
        public System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}