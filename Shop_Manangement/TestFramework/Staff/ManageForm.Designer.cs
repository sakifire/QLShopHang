namespace TestFramework.Staff
{
    partial class ManageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridNhanvien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btadd = new Guna.UI2.WinForms.Guna2Button();
            this.btrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btexport = new Guna.UI2.WinForms.Guna2Button();
            this.btsearch = new Guna.UI2.WinForms.Guna2Button();
            this.tbsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.exitbtn = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.watchShopGroupDataSet2 = new TestFramework.WatchShopGroupDataSet2();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new TestFramework.WatchShopGroupDataSet2TableAdapters.StaffTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.idposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanvien)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchShopGroupDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridNhanvien
            // 
            this.gridNhanvien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridNhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridNhanvien.AutoGenerateColumns = false;
            this.gridNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNhanvien.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridNhanvien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridNhanvien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridNhanvien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridNhanvien.ColumnHeadersHeight = 30;
            this.gridNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addrDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn,
            this.idposDataGridViewTextBoxColumn});
            this.gridNhanvien.DataSource = this.staffBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridNhanvien.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridNhanvien.EnableHeadersVisualStyles = false;
            this.gridNhanvien.GridColor = System.Drawing.Color.Blue;
            this.gridNhanvien.Location = new System.Drawing.Point(29, 240);
            this.gridNhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.gridNhanvien.Name = "gridNhanvien";
            this.gridNhanvien.RowHeadersVisible = false;
            this.gridNhanvien.RowHeadersWidth = 51;
            this.gridNhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNhanvien.Size = new System.Drawing.Size(1240, 537);
            this.gridNhanvien.TabIndex = 1;
            this.gridNhanvien.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridNhanvien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridNhanvien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridNhanvien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridNhanvien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridNhanvien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridNhanvien.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.gridNhanvien.ThemeStyle.GridColor = System.Drawing.Color.Blue;
            this.gridNhanvien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridNhanvien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridNhanvien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridNhanvien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridNhanvien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridNhanvien.ThemeStyle.HeaderStyle.Height = 30;
            this.gridNhanvien.ThemeStyle.ReadOnly = false;
            this.gridNhanvien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridNhanvien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridNhanvien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gridNhanvien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridNhanvien.ThemeStyle.RowsStyle.Height = 22;
            this.gridNhanvien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridNhanvien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridNhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNhanvien_CellContentClick);
            // 
            // btadd
            // 
            this.btadd.BorderColor = System.Drawing.Color.DarkCyan;
            this.btadd.BorderThickness = 2;
            this.btadd.CheckedState.Parent = this.btadd;
            this.btadd.CustomImages.Parent = this.btadd;
            this.btadd.FillColor = System.Drawing.Color.Aquamarine;
            this.btadd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.ForeColor = System.Drawing.Color.DimGray;
            this.btadd.HoverState.Parent = this.btadd;
            this.btadd.Location = new System.Drawing.Point(40, 20);
            this.btadd.Margin = new System.Windows.Forms.Padding(4);
            this.btadd.Name = "btadd";
            this.btadd.ShadowDecoration.Parent = this.btadd;
            this.btadd.Size = new System.Drawing.Size(195, 48);
            this.btadd.TabIndex = 2;
            this.btadd.Text = "ADD";
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btrefresh
            // 
            this.btrefresh.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btrefresh.BorderThickness = 2;
            this.btrefresh.CheckedState.Parent = this.btrefresh;
            this.btrefresh.CustomImages.Parent = this.btrefresh;
            this.btrefresh.FillColor = System.Drawing.Color.PaleTurquoise;
            this.btrefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrefresh.ForeColor = System.Drawing.Color.DimGray;
            this.btrefresh.HoverState.Parent = this.btrefresh;
            this.btrefresh.Location = new System.Drawing.Point(256, 20);
            this.btrefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.ShadowDecoration.Parent = this.btrefresh;
            this.btrefresh.Size = new System.Drawing.Size(195, 48);
            this.btrefresh.TabIndex = 3;
            this.btrefresh.Text = "REFRESH";
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // btexport
            // 
            this.btexport.BorderColor = System.Drawing.Color.Olive;
            this.btexport.BorderThickness = 2;
            this.btexport.CheckedState.Parent = this.btexport;
            this.btexport.CustomImages.Parent = this.btexport;
            this.btexport.FillColor = System.Drawing.Color.Gold;
            this.btexport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexport.ForeColor = System.Drawing.Color.DimGray;
            this.btexport.HoverState.Parent = this.btexport;
            this.btexport.Location = new System.Drawing.Point(475, 20);
            this.btexport.Margin = new System.Windows.Forms.Padding(4);
            this.btexport.Name = "btexport";
            this.btexport.ShadowDecoration.Parent = this.btexport;
            this.btexport.Size = new System.Drawing.Size(195, 48);
            this.btexport.TabIndex = 4;
            this.btexport.Text = "EXPORT";
            this.btexport.Click += new System.EventHandler(this.btexport_Click);
            // 
            // btsearch
            // 
            this.btsearch.CheckedState.Parent = this.btsearch;
            this.btsearch.CustomImages.Parent = this.btsearch;
            this.btsearch.FillColor = System.Drawing.Color.DarkGray;
            this.btsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btsearch.ForeColor = System.Drawing.Color.White;
            this.btsearch.HoverState.Parent = this.btsearch;
            this.btsearch.Location = new System.Drawing.Point(1073, 20);
            this.btsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btsearch.Name = "btsearch";
            this.btsearch.ShadowDecoration.Parent = this.btsearch;
            this.btsearch.Size = new System.Drawing.Size(195, 48);
            this.btsearch.TabIndex = 5;
            this.btsearch.Text = "SEARCH";
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // tbsearch
            // 
            this.tbsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbsearch.DefaultText = "is, name, phone";
            this.tbsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbsearch.DisabledState.Parent = this.tbsearch;
            this.tbsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbsearch.FocusedState.Parent = this.tbsearch;
            this.tbsearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbsearch.HoverState.Parent = this.tbsearch;
            this.tbsearch.Location = new System.Drawing.Point(705, 20);
            this.tbsearch.Margin = new System.Windows.Forms.Padding(5);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.PasswordChar = '\0';
            this.tbsearch.PlaceholderText = "";
            this.tbsearch.SelectedText = "";
            this.tbsearch.SelectionStart = 15;
            this.tbsearch.ShadowDecoration.Parent = this.tbsearch;
            this.tbsearch.Size = new System.Drawing.Size(360, 44);
            this.tbsearch.TabIndex = 6;
            this.tbsearch.Enter += new System.EventHandler(this.tbsearch_Enter);
            this.tbsearch.Leave += new System.EventHandler(this.tbsearch_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tbsearch);
            this.panel1.Controls.Add(this.btadd);
            this.panel1.Controls.Add(this.btsearch);
            this.panel1.Controls.Add(this.btrefresh);
            this.panel1.Controls.Add(this.btexport);
            this.panel1.Location = new System.Drawing.Point(1, 144);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 89);
            this.panel1.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Azure;
            this.panel14.Controls.Add(this.exitbtn);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.label8);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1292, 145);
            this.panel14.TabIndex = 56;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.FillColor = System.Drawing.Color.Blue;
            this.exitbtn.Image = global::TestFramework.Properties.Resources.PIC6;
            this.exitbtn.Location = new System.Drawing.Point(1240, 4);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.ShadowDecoration.Parent = this.exitbtn;
            this.exitbtn.Size = new System.Drawing.Size(37, 38);
            this.exitbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitbtn.TabIndex = 38;
            this.exitbtn.TabStop = false;
            this.exitbtn.UseTransparentBackground = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click_1);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DarkCyan;
            this.panel15.Location = new System.Drawing.Point(1, 137);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1293, 1);
            this.panel15.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Handwriting", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(417, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(371, 104);
            this.label8.TabIndex = 0;
            this.label8.Text = "Jelwery";
            // 
            // watchShopGroupDataSet2
            // 
            this.watchShopGroupDataSet2.DataSetName = "WatchShopGroupDataSet2";
            this.watchShopGroupDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.watchShopGroupDataSet2;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // addrDataGridViewTextBoxColumn
            // 
            this.addrDataGridViewTextBoxColumn.DataPropertyName = "addr";
            this.addrDataGridViewTextBoxColumn.HeaderText = "addr";
            this.addrDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addrDataGridViewTextBoxColumn.Name = "addrDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // idposDataGridViewTextBoxColumn
            // 
            this.idposDataGridViewTextBoxColumn.DataPropertyName = "idpos";
            this.idposDataGridViewTextBoxColumn.HeaderText = "idpos";
            this.idposDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idposDataGridViewTextBoxColumn.Name = "idposDataGridViewTextBoxColumn";
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 825);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.gridNhanvien);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageForm";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNhanvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watchShopGroupDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView gridNhanvien;
        private Guna.UI2.WinForms.Guna2Button btadd;
        private Guna.UI2.WinForms.Guna2Button btrefresh;
        private Guna.UI2.WinForms.Guna2Button btexport;
        private Guna.UI2.WinForms.Guna2Button btsearch;
        private Guna.UI2.WinForms.Guna2TextBox tbsearch;
        private System.Windows.Forms.Panel panel14;
        private Guna.UI2.WinForms.Guna2PictureBox exitbtn;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label8;
        private WatchShopGroupDataSet2 watchShopGroupDataSet2;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private WatchShopGroupDataSet2TableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idposDataGridViewTextBoxColumn;
    }
}