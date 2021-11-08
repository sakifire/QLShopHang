using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFramework.Class;
using System.IO;
using System.Data.SqlClient;

namespace TestFramework.Staff
{
    public partial class DetailsNV : Form
    {
        public DetailsNV()
        {
            InitializeComponent();
        }
        NV staff = new NV();
       
        private void btnpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                picstaff.BackgroundImage = Image.FromFile(opf.FileName);
                picstaff.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            string manv = tbmanv.Text.Trim();
            string holot = tbholot.Text;
            string ten = tbten.Text;
            string gioitinh = "Male";
            if (rbnu.Checked)
            {
                gioitinh = "Female";
            }
            string diachi = tbdiachi.Text;
            int sodienthoai, machucvu;
            if (checkNumber(tbsdt.Text) && checkNumber(tbmacv.Text))
            {
                sodienthoai = Convert.ToInt32(tbsdt.Text);
                machucvu = Convert.ToInt32(tbmacv.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
                return;
            }
            MemoryStream pic = new MemoryStream();
            if (verif())
            {
                try
                {
                    manv = tbmanv.Text;
                    picstaff.BackgroundImage.Save(pic, picstaff.BackgroundImage.RawFormat);
                    if (staff.updateStaff(manv, holot, ten, gioitinh, diachi, pic, sodienthoai, machucvu))
                    {
                        MessageBox.Show("Successfully!", "Update staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Update staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Update staff", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Update staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        bool verif()
        {
            if ((tbmanv.Text.Trim() == "")
                || (tbholot.Text.Trim() == "")
                || (tbten.Text.Trim() == "")
                || (tbdiachi.Text.Trim() == "")
                || (tbdiachi.Text.Trim() == "")
                || (tbsdt.Text.Trim() == "")
                || (tbmacv.Text.Trim() == "")
                || (picstaff.BackgroundImage == null))

            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btremove_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = tbmanv.Text;
                if ((MessageBox.Show("Are you sure you want to delete this staff?", "Delete Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (staff.deleteStaff(manv))
                    {
                        MessageBox.Show("Successfully!", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbmanv.Text = "";
                        tbholot.Text = "";
                        tbten.Text = "";
                        tbdiachi.Text = "";
                        tbsdt.Text = "";
                        tbmacv.Text = "";
                        picstaff.BackgroundImage = null;

                    }
                    else
                    {
                        MessageBox.Show("Staff not deleted", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
     
        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {         
            this.Close();
        }

        #region logic function

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        bool checkNumber(string text)
        {
            if (text != "" && IsNumber(text))
            {
                return true;
            }
            else return false;
        }




        #endregion logic function
    }
}
