using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFramework.Pro
{
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            loadchart1();
            loadchart2();
            loadchart3();
            loadchart4();
            loadchart7();
        }
        PRODUCT product = new PRODUCT();
        public void loadchart1()
        {
            DataTable table = product.getProducts(new System.Data.SqlClient.SqlCommand("select type, sum(curnumber) as Amount from Product group by type"));
            chart1.DataSource = table;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Type";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Amount";
            chart1.Series["Type"].XValueMember = "type";
            chart1.Series["Type"].YValueMembers = "Amount";
        }
        public void loadchart2() //Đồng hồ nam
        {
            DataTable table = product.getProducts(new System.Data.SqlClient.SqlCommand("select name, sum(curnumber) as Amount from Product where type = N'Đồng hồ nam' group by name"));
            chart2.DataSource = table;
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "Name";
            chart2.ChartAreas["ChartArea1"].AxisY.Title = "Amount";
            chart2.Series["Đồng hồ nam"].XValueMember = "name";
            chart2.Series["Đồng hồ nam"].YValueMembers = "Amount";
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
        }
        public void loadchart3() //Đồng hồ nữ
        {
            DataTable table = product.getProducts(new System.Data.SqlClient.SqlCommand("select name, sum(curnumber) as Amount from Product where type = N'Đồng hồ nữ' group by name"));
            chart3.DataSource = table;
            chart3.ChartAreas["ChartArea1"].AxisX.Title = "Name";
            chart3.ChartAreas["ChartArea1"].AxisY.Title = "Amount";
            chart3.Series["Đồng hồ nữ"].XValueMember = "name";
            chart3.Series["Đồng hồ nữ"].YValueMembers = "Amount";
            chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

        }
        public void loadchart4() //Đồng hồ trẻ em
        {
            DataTable table = product.getProducts(new System.Data.SqlClient.SqlCommand("select name, sum(curnumber) as Amount from Product where type = N'Đồng hồ trẻ em' group by name"));
            chart4.DataSource = table;
            chart4.ChartAreas["ChartArea1"].AxisX.Title = "Name";
            chart4.ChartAreas["ChartArea1"].AxisY.Title = "Amount";
            chart4.Series["Đồng hồ trẻ em"].XValueMember = "name";
            chart4.Series["Đồng hồ trẻ em"].YValueMembers = "Amount";
            chart4.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;

        }
        public void loadchart7() 
        {
            DataTable table = product.getProducts(new System.Data.SqlClient.SqlCommand("select name, sum(amount) as Amount from Product  group by name"));
            chart7.DataSource = table;
            chart7.ChartAreas["ChartArea1"].AxisX.Title = "Name";
            chart7.ChartAreas["ChartArea1"].AxisY.Title = "Amount";
            chart7.Series["Product"].XValueMember = "name";
            chart7.Series["Product"].YValueMembers = "Amount";
            chart7.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void btn2_CheckedChanged(object sender, EventArgs e)
        {
            if (btn2.Checked == true)
            {
                chart7.Visible = true;
                btnTreEm.Visible = true;
                btnNu.Visible = true;
                btnNam.Visible = true;
            }
            else
            {
                chart7.Visible = false;
            }
            if (btn1.Checked == true)
            {
                btnTreEm.Visible = false;
                btnNu.Visible = false;
                btnNam.Visible = false;
            }
        }

        private void btnNam_CheckedChanged(object sender, EventArgs e)
        {
            if (btnNam.Checked == true)
            {
                chart2.Visible = true;
            }
            else
            {
                chart2.Visible = false;
            }
        }

        private void btn1_CheckedChanged(object sender, EventArgs e)
        {
            if (btn1.Checked == true)
            {
                chart1.Visible = true;
                btnTreEm.Visible = false;
                btnNu.Visible = false;
                btnNam.Visible = false;
            }
            else
            {
                chart1.Visible = false;
            }
        }

        private void btnNu_CheckedChanged(object sender, EventArgs e)
        {
            if (btnNu.Checked == true)
            {
                chart3.Visible = true;
            }
            else
            {
                chart3.Visible = false;
            }
        }

        private void btnTreEm_CheckedChanged(object sender, EventArgs e)
        {
            if (btnTreEm.Checked == true)
            {
                chart4.Visible = true;
            }
            else
            {
                chart4.Visible = false;
            }
        }


    }
}
