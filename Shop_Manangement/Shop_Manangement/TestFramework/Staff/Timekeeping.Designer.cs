namespace TestFramework.Staff
{
    partial class Timekeeping
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtchamcong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbname = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttable = new Guna.UI2.WinForms.Guna2Button();
            this.btconfirm = new Guna.UI2.WinForms.Guna2Button();
            this.rbAbsent = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbgiora = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbgiovao = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dtchamcong);
            this.panel1.Controls.Add(this.cbname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 72);
            this.panel1.TabIndex = 0;
            // 
            // dtchamcong
            // 
            this.dtchamcong.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.dtchamcong.BorderThickness = 2;
            this.dtchamcong.CheckedState.Parent = this.dtchamcong;
            this.dtchamcong.FillColor = System.Drawing.Color.Azure;
            this.dtchamcong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtchamcong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtchamcong.HoverState.Parent = this.dtchamcong;
            this.dtchamcong.Location = new System.Drawing.Point(12, 12);
            this.dtchamcong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtchamcong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtchamcong.Name = "dtchamcong";
            this.dtchamcong.ShadowDecoration.Parent = this.dtchamcong;
            this.dtchamcong.Size = new System.Drawing.Size(311, 36);
            this.dtchamcong.TabIndex = 0;
            this.dtchamcong.Value = new System.DateTime(2021, 11, 13, 0, 0, 0, 0);
            // 
            // cbname
            // 
            this.cbname.BackColor = System.Drawing.Color.Transparent;
            this.cbname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbname.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbname.FocusedState.Parent = this.cbname;
            this.cbname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbname.HoverState.Parent = this.cbname;
            this.cbname.ItemHeight = 30;
            this.cbname.ItemsAppearance.Parent = this.cbname;
            this.cbname.Location = new System.Drawing.Point(533, 12);
            this.cbname.Name = "cbname";
            this.cbname.ShadowDecoration.Parent = this.cbname;
            this.cbname.Size = new System.Drawing.Size(402, 36);
            this.cbname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(471, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.bttable);
            this.panel2.Controls.Add(this.btconfirm);
            this.panel2.Controls.Add(this.rbAbsent);
            this.panel2.Controls.Add(this.rbgiora);
            this.panel2.Controls.Add(this.rbgiovao);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(26, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 444);
            this.panel2.TabIndex = 1;
            // 
            // bttable
            // 
            this.bttable.Animated = true;
            this.bttable.BorderColor = System.Drawing.Color.DarkRed;
            this.bttable.BorderRadius = 20;
            this.bttable.BorderThickness = 2;
            this.bttable.CheckedState.Parent = this.bttable;
            this.bttable.CustomImages.Parent = this.bttable;
            this.bttable.FillColor = System.Drawing.Color.Salmon;
            this.bttable.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bttable.ForeColor = System.Drawing.Color.DimGray;
            this.bttable.HoverState.Parent = this.bttable;
            this.bttable.Location = new System.Drawing.Point(718, 5);
            this.bttable.Name = "bttable";
            this.bttable.ShadowDecoration.Parent = this.bttable;
            this.bttable.Size = new System.Drawing.Size(190, 45);
            this.bttable.TabIndex = 8;
            this.bttable.Text = "Detail";
            this.bttable.Click += new System.EventHandler(this.bttable_Click);
            // 
            // btconfirm
            // 
            this.btconfirm.BorderColor = System.Drawing.Color.DarkCyan;
            this.btconfirm.BorderRadius = 20;
            this.btconfirm.BorderThickness = 2;
            this.btconfirm.CheckedState.Parent = this.btconfirm;
            this.btconfirm.CustomImages.Parent = this.btconfirm;
            this.btconfirm.FillColor = System.Drawing.Color.LightCyan;
            this.btconfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btconfirm.ForeColor = System.Drawing.Color.DimGray;
            this.btconfirm.HoverState.Parent = this.btconfirm;
            this.btconfirm.Location = new System.Drawing.Point(548, 5);
            this.btconfirm.Name = "btconfirm";
            this.btconfirm.ShadowDecoration.Parent = this.btconfirm;
            this.btconfirm.Size = new System.Drawing.Size(137, 45);
            this.btconfirm.TabIndex = 7;
            this.btconfirm.Text = "Confirm";
            this.btconfirm.Click += new System.EventHandler(this.btconfirm_Click);
            // 
            // rbAbsent
            // 
            this.rbAbsent.AutoSize = true;
            this.rbAbsent.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAbsent.CheckedState.BorderThickness = 0;
            this.rbAbsent.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAbsent.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAbsent.CheckedState.InnerOffset = -4;
            this.rbAbsent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAbsent.Location = new System.Drawing.Point(345, 17);
            this.rbAbsent.Name = "rbAbsent";
            this.rbAbsent.Size = new System.Drawing.Size(87, 28);
            this.rbAbsent.TabIndex = 5;
            this.rbAbsent.Text = "Absent";
            this.rbAbsent.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAbsent.UncheckedState.BorderThickness = 2;
            this.rbAbsent.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAbsent.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbgiora
            // 
            this.rbgiora.AutoSize = true;
            this.rbgiora.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbgiora.CheckedState.BorderThickness = 0;
            this.rbgiora.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbgiora.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbgiora.CheckedState.InnerOffset = -4;
            this.rbgiora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbgiora.Location = new System.Drawing.Point(206, 17);
            this.rbgiora.Name = "rbgiora";
            this.rbgiora.Size = new System.Drawing.Size(108, 28);
            this.rbgiora.TabIndex = 5;
            this.rbgiora.Text = "Checkout";
            this.rbgiora.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbgiora.UncheckedState.BorderThickness = 2;
            this.rbgiora.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbgiora.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbgiovao
            // 
            this.rbgiovao.AutoSize = true;
            this.rbgiovao.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbgiovao.CheckedState.BorderThickness = 0;
            this.rbgiovao.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbgiovao.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbgiovao.CheckedState.InnerOffset = -4;
            this.rbgiovao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rbgiovao.Location = new System.Drawing.Point(75, 17);
            this.rbgiovao.Name = "rbgiovao";
            this.rbgiovao.Size = new System.Drawing.Size(97, 28);
            this.rbgiovao.TabIndex = 5;
            this.rbgiovao.Text = "Checkin";
            this.rbgiovao.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbgiovao.UncheckedState.BorderThickness = 2;
            this.rbgiovao.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbgiovao.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(6, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(922, 384);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridView1.ThemeStyle.ReadOnly = false;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.SkyBlue;
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.label8);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(969, 118);
            this.panel14.TabIndex = 57;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DarkCyan;
            this.panel15.Location = new System.Drawing.Point(1, 111);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(970, 1);
            this.panel15.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Handwriting", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(313, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(376, 83);
            this.label8.TabIndex = 0;
            this.label8.Text = "G4WATCH";
            // 
            // Timekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 640);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Timekeeping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timekeeping";
            this.Load += new System.EventHandler(this.Timekeeping_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbname;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtchamcong;
        private Guna.UI2.WinForms.Guna2RadioButton rbAbsent;
        private Guna.UI2.WinForms.Guna2RadioButton rbgiora;
        private Guna.UI2.WinForms.Guna2RadioButton rbgiovao;
        private Guna.UI2.WinForms.Guna2Button bttable;
        private Guna.UI2.WinForms.Guna2Button btconfirm;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label8;
    }
}