
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFramework.Pro;

namespace TestFramework
{
    public partial class InfProduct : Form
    {
        public InfProduct()
        {
            InitializeComponent();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            order ord = new order();

            ord.label3.Visible = true;
            ord.label6.Visible = true;
            ord.label5.Visible = true;

            ord.txtprice.Text = lblprice.Text.ToString();
            ord.txtamount.Text = nsl.Value.ToString();
            ord.txtPr.Text = lblname.Text;
            ord.txttotal.Text = (Convert.ToInt32(lblprice.Text.ToString()) * Convert.ToInt32(nsl.Value.ToString())).ToString();
            ord.Show(this);
           
        }
    }
}
