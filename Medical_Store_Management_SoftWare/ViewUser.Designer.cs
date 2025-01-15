namespace Medical_Store_Management_SoftWare
{
    partial class ViewUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUser));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userPhoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyDataSet4 = new Medical_Store_Management_SoftWare.PharmacyDataSet4();
            this.user_PhoneTableAdapter = new Medical_Store_Management_SoftWare.PharmacyDataSet4TableAdapters.User_PhoneTableAdapter();
            this.cBox_Search = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 290);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(856, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // userPhoneBindingSource
            // 
            this.userPhoneBindingSource.DataMember = "User_Phone";
            this.userPhoneBindingSource.DataSource = this.pharmacyDataSet4;
            // 
            // pharmacyDataSet4
            // 
            this.pharmacyDataSet4.DataSetName = "PharmacyDataSet4";
            this.pharmacyDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_PhoneTableAdapter
            // 
            this.user_PhoneTableAdapter.ClearBeforeFill = true;
            // 
            // cBox_Search
            // 
            this.cBox_Search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cBox_Search.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cBox_Search.FormattingEnabled = true;
            this.cBox_Search.Location = new System.Drawing.Point(365, 259);
            this.cBox_Search.Name = "cBox_Search";
            this.cBox_Search.Size = new System.Drawing.Size(565, 24);
            this.cBox_Search.TabIndex = 4;
            this.cBox_Search.SelectedIndexChanged += new System.EventHandler(this.cBox_Search_SelectedIndexChanged);
            this.cBox_Search.TextChanged += new System.EventHandler(this.cBox_Search_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(1393, 679);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cBox_Search);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewUser";
            this.Load += new System.EventHandler(this.ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PharmacyDataSet4 pharmacyDataSet4;
        private System.Windows.Forms.BindingSource userPhoneBindingSource;
        private PharmacyDataSet4TableAdapters.User_PhoneTableAdapter user_PhoneTableAdapter;
        public System.Windows.Forms.ComboBox cBox_Search;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}