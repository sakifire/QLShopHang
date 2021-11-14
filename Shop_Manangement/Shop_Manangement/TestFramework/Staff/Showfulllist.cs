using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFramework.Staff
{
    public partial class Showfulllist : Form
    {
        public Showfulllist()
        {
            InitializeComponent();
        }
        Class.Chamcong cong = new Class.Chamcong();

        private void btsearch_Click(object sender, EventArgs e)
        {
            DateTime ngay = dtchamcong.Value;
            grid.DataSource = cong.Loadfulllistdk(ngay);
        }

        private void Showfulllist_Load(object sender, EventArgs e)
        {
            grid.DataSource = cong.Loadfulllist();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            grid.DataSource = cong.Loadfulllist();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timekeepingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statisticToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
