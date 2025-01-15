namespace Medical_Store_Management_SoftWare
{
    partial class Store
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cBox_Search = new System.Windows.Forms.ComboBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.pharmacyDataSet3 = new Medical_Store_Management_SoftWare.PharmacyDataSet3();
            this.storageInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageInfoTableAdapter = new Medical_Store_Management_SoftWare.PharmacyDataSet3TableAdapters.StorageInfoTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(857, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // cBox_Search
            // 
            this.cBox_Search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cBox_Search.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cBox_Search.FormattingEnabled = true;
            this.cBox_Search.Location = new System.Drawing.Point(229, 101);
            this.cBox_Search.Name = "cBox_Search";
            this.cBox_Search.Size = new System.Drawing.Size(469, 24);
            this.cBox_Search.TabIndex = 3;
            this.cBox_Search.SelectedIndexChanged += new System.EventHandler(this.cBox_Search_SelectedIndexChanged);
            this.cBox_Search.TextChanged += new System.EventHandler(this.cBox_Search_TextChanged);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Update.Location = new System.Drawing.Point(367, 445);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 25);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // pharmacyDataSet3
            // 
            this.pharmacyDataSet3.DataSetName = "PharmacyDataSet3";
            this.pharmacyDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storageInfoBindingSource
            // 
            this.storageInfoBindingSource.DataMember = "StorageInfo";
            this.storageInfoBindingSource.DataSource = this.pharmacyDataSet3;
            // 
            // storageInfoTableAdapter
            // 
            this.storageInfoTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(881, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.cBox_Search);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Update;
        public System.Windows.Forms.ComboBox cBox_Search;
        private PharmacyDataSet3 pharmacyDataSet3;
        private System.Windows.Forms.BindingSource storageInfoBindingSource;
        private PharmacyDataSet3TableAdapters.StorageInfoTableAdapter storageInfoTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}