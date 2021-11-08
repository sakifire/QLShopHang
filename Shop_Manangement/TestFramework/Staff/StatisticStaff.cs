using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace TestFramework.Staff
{
    public partial class StatisticStaff : Form
    {
        public StatisticStaff()
        {
            InitializeComponent();
        }
        Color panTotalcolor;
        Color panMalecolor;
        Color panFemalecolor;
        MyData mydb = new MyData();
        private void fullChart()
        {
            SqlCommand command = new SqlCommand("select gender, count(gender) as amount from Staff group by gender", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            mydb.openConnection();
            chart1.DataSource = dataset;
            chart1.Series["Staff rate"].XValueMember = "gender";
            chart1.Series["Staff rate"].YValueMembers = "amount";
            chart1.Titles.Add("Staff Rate");
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            mydb.closeConnection();
        }

        private void StatisticStaff_Load(object sender, EventArgs e)
        {
            panTotalcolor = panTotal.BackColor;
            panMalecolor = panNam.BackColor;
            panFemalecolor = panNu.BackColor;
            Class.NV nv = new Class.NV();
            double total = Convert.ToDouble(nv.totalStaff());
            double totalmale = Convert.ToDouble(nv.totalNamStaff());
            double totalfemale = Convert.ToDouble(nv.totalNuStaff());
            double maleper = Math.Round((totalmale * (100 / total)));
            double femaleper = Math.Round((totalfemale * (100 / total)));
            label2.Text = ("Total Staff: " + total.ToString() + " (100%)");
            label3.Text = ("Nam: " + totalmale.ToString() + "(" + maleper.ToString() + "%)");
            label4.Text = ("Nữ: " + totalfemale.ToString() + "(" + femaleper.ToString() + "%)");
            fullChart();
        }

        private void panTotal_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
            panTotal.BackColor = Color.DarkOrange;
        }

        private void panTotal_MouseLeave(object sender, EventArgs e)
        {
            panTotal.BackColor = panTotalcolor;
            label2.ForeColor = Color.Black;
        }

        private void panNam_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
            panNam.BackColor = Color.IndianRed;
        }

        private void panNam_MouseLeave(object sender, EventArgs e)
        {
            panNam.BackColor = panMalecolor;
            label3.ForeColor = Color.Black;
        }

        private void panNu_MouseEnter(object sender, EventArgs e)
        {

            label4.ForeColor = Color.Black;
            panNu.BackColor = Color.CornflowerBlue;

        }

        private void panNu_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
            panNu.BackColor = panFemalecolor;
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
