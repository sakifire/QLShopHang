namespace TestFramework.Staff
{
    partial class StatisticStaff
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panTKNV = new System.Windows.Forms.Panel();
            this.panTotal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panNam = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panNu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panTKNV.SuspendLayout();
            this.panTotal.SuspendLayout();
            this.panNam.SuspendLayout();
            this.panNu.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(465, 234);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Staff rate";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(439, 346);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // panTKNV
            // 
            this.panTKNV.Controls.Add(this.panTotal);
            this.panTKNV.Controls.Add(this.panNam);
            this.panTKNV.Controls.Add(this.panNu);
            this.panTKNV.Location = new System.Drawing.Point(13, 275);
            this.panTKNV.Margin = new System.Windows.Forms.Padding(4);
            this.panTKNV.Name = "panTKNV";
            this.panTKNV.Size = new System.Drawing.Size(445, 261);
            this.panTKNV.TabIndex = 8;
            // 
            // panTotal
            // 
            this.panTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panTotal.Controls.Add(this.label2);
            this.panTotal.Location = new System.Drawing.Point(4, 4);
            this.panTotal.Margin = new System.Windows.Forms.Padding(4);
            this.panTotal.Name = "panTotal";
            this.panTotal.Size = new System.Drawing.Size(435, 123);
            this.panTotal.TabIndex = 0;
            this.panTotal.MouseEnter += new System.EventHandler(this.panTotal_MouseEnter);
            this.panTotal.MouseLeave += new System.EventHandler(this.panTotal_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(115, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Staff: ";
            // 
            // panNam
            // 
            this.panNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panNam.Controls.Add(this.label3);
            this.panNam.Location = new System.Drawing.Point(4, 130);
            this.panNam.Margin = new System.Windows.Forms.Padding(4);
            this.panNam.Name = "panNam";
            this.panNam.Size = new System.Drawing.Size(207, 123);
            this.panNam.TabIndex = 1;
            this.panNam.MouseEnter += new System.EventHandler(this.panNam_MouseEnter);
            this.panNam.MouseLeave += new System.EventHandler(this.panNam_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(32, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Male:";
            // 
            // panNu
            // 
            this.panNu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panNu.Controls.Add(this.label4);
            this.panNu.Location = new System.Drawing.Point(219, 130);
            this.panNu.Margin = new System.Windows.Forms.Padding(4);
            this.panNu.Name = "panNu";
            this.panNu.Size = new System.Drawing.Size(220, 123);
            this.panNu.TabIndex = 2;
            this.panNu.MouseEnter += new System.EventHandler(this.panNu_MouseEnter);
            this.panNu.MouseLeave += new System.EventHandler(this.panNu_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(25, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Female:";
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
            // StatisticStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 640);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panTKNV);
            this.Controls.Add(this.chart1);
            this.Name = "StatisticStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticStaff";
            this.Load += new System.EventHandler(this.StatisticStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panTKNV.ResumeLayout(false);
            this.panTotal.ResumeLayout(false);
            this.panTotal.PerformLayout();
            this.panNam.ResumeLayout(false);
            this.panNam.PerformLayout();
            this.panNu.ResumeLayout(false);
            this.panNu.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panTKNV;
        private System.Windows.Forms.Panel panTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panNu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label8;
    }
}