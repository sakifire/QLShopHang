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
using System.Data.Sql;
using System.IO;
using TestFramework.Class;

namespace TestFramework.Staff
{
    public partial class Timekeeping : Form
    {
        public Timekeeping()
        {
            InitializeComponent();
        }
        NV nv = new NV();
        Chamcong cong = new Chamcong();

        private void Timekeeping_Load(object sender, EventArgs e)
        {
            dtchamcong.Value = DateTime.Now;
            cbname.DataSource = nv.getName();
            cbname.ValueMember = "id";
            cbname.DisplayMember = "FullName";
            int manv = Convert.ToInt32(cbname.SelectedValue);
            DateTime ngaylam = dtchamcong.Value;
            int thang = dtchamcong.Value.Month;
            dataGridView1.DataSource = cong.LoadCCthang(thang, manv);
        }

        private void btconfirm_Click(object sender, EventArgs e)
        {
            DateTime ngay = dtchamcong.Value;
            int manv = Convert.ToInt32(cbname.SelectedValue);
            string trangthai = "P";
            DateTime checkin = dtchamcong.Value;
            if (rbgiovao.Checked == true)
            {
                if (cong.ktcheckin(ngay, manv) && cong.ktcheckout(ngay, manv))
                {

                    cong.checkin(ngay, manv, trangthai, checkin);
                    MessageBox.Show("Checkin", "Timekeeping", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Had checkin", "Timekeeping", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rbgiora.Checked == true)
            {
                if (!cong.ktcheckin(ngay, manv) && cong.ktcheckout(ngay, manv))
                {
                    DateTime checkout = dtchamcong.Value;
                    cong.checkout(ngay, manv, checkout);
                    //dataGridView3.DataSource = cong.Laysongaycong(ngay, manv);
                    MessageBox.Show("Checkout", "Timekeeping", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Had Checkout", "Timekeeping", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rbAbsent.Checked == true)
            {
                trangthai = "A";
                cong.insertchamcongA(ngay, manv, trangthai);
                MessageBox.Show("Absent", "Timekeeping", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            int thang = dtchamcong.Value.Month;
            dataGridView1.DataSource = cong.LoadCCthang(thang, manv);
        }

        private void bttable_Click(object sender, EventArgs e)
        {
            Showfulllist show = new Showfulllist();
            show.Show();
            this.Close();
            
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

    }
}
