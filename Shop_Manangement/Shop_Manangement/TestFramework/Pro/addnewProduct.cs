using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFramework
{
    public partial class addnewProduct : Form
    {
        public addnewProduct()
        {
            InitializeComponent();
        }

        private void btnpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(open.FileName);
                pic.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            PRODUCT product = new PRODUCT();
            int ms, price, amount;
            string name, description, type;
            #region Check Text
            if (checkNumber(txtid.Text.ToString())
                || checkNumber(txtprice.Text.ToString())
                || checkNumber(txtamount.Text.ToString()))
            {
                ms = Convert.ToInt32(txtid.Text);
                price = Convert.ToInt32(txtprice.Text);
                amount = Convert.ToInt32(txtamount.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ và đúng định dạng");
                return;
            }
           
            if (txtname.Text.ToString() != ""
                || txtdes.Text.ToString() != ""
                || comboBox1.SelectedItem.ToString() != "")
            {
                name = txtname.Text;
                description = txtdes.Text;
                type = comboBox1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ và đúng định dạng");
                return;
            }

            DateTime inputday = (DateTime)dtpinput.Value;
            MemoryStream picture = new MemoryStream();
            #endregion
            if (verif())
            {

                pic.Image.Save(picture, pic.Image.RawFormat);
                if (product.addProduct(ms, name, price, description, type, inputday, amount, picture))
                {
                    MessageBox.Show("New Product Added", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void exit_picture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region logic function
        bool verif()
        {
            if ((txtname.Text.Trim() == "") || (txtprice.Text.Trim() == "") || (pic.Image == null))
            {
                return false;
            }
            else return true;
        }

       
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

