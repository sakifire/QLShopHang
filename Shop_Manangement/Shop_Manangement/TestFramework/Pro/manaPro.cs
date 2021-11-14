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
using System.IO;
using System.Drawing.Imaging;

namespace TestFramework.Pro
{
    public partial class manapro : Form
    {
        public manapro()
        {
            InitializeComponent();
            btnAdd.Enabled = true;
            btnedit.Enabled = false;
            btnRemove.Enabled = false;
        }


        private void manapro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'watchShopGroupDataSet4.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.watchShopGroupDataSet4.Product);
            // TODO: This line of code loads data into the 'watchShopGroupDataSet3.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.watchShopGroupDataSet3.Product);                                  
            fillGrid(new SqlCommand("SELECT * FROM Product where state = 1"));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pctPr.Image = Image.FromFile(open.FileName);
                pctPr.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + txtms.Text);
            if (pctPr.Image == null)
            {
                MessageBox.Show("No Image In PictureBox", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (svf.ShowDialog() == DialogResult.OK)
                pctPr.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
        }
       
        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                label5.Visible = false;
            }
        }

        PRODUCT product = new PRODUCT();
        
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = product.getProducts(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[8];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Product WHERE CONCAT(id,name,type,price) LIKE N'%" + txtfind.Text + "%'");
            fillGrid(command);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PRODUCT product = new PRODUCT();
            int ms, price, amount;
            string name, type;
            #region Check text
            if (checkNumber(txtms.Text) && checkNumber(txtprice.Text) && checkNumber(txtSL.Text))
            {
                ms = Convert.ToInt32(txtms.Text);
                price = Convert.ToInt32(txtprice.Text);
                amount = Convert.ToInt32(txtSL.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ và đúng định dạng");
                return;
            }
            if ((txtname.Text != null || txtname.Text != "")
                && (comboBox1.SelectedItem.ToString() != null || comboBox1.SelectedItem.ToString() != ""))
            {
                name = txtname.Text;
                type = comboBox1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ và đúng định dạng");
                return;
            }
            string description = txtdes.Text;
            DateTime inputday = dtpinput.Value;
            MemoryStream pic = new MemoryStream();
            #endregion
            if (verif())
            {
                pctPr.Image.Save(pic, pctPr.Image.RawFormat);
                if (product.addProduct(ms, name, price, description, type, inputday, amount, pic))
                {
                    MessageBox.Show("New Product Added", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("SELECT * FROM Product where state =1"));
                    txtdes.Clear();
                    txtms.Clear();
                    txtname.Clear();
                    txtprice.Clear();
                    txtdes.Clear();
                    comboBox1.Text = "Type";
                    txtSL.Clear();
                    btnedit.Enabled = false;
                    btnRemove.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        bool verif()
        {
            if ((txtname.Text.Trim() == "") || (txtprice.Text.Trim() == "") || (pctPr.Image == null))
            {
                return false;
            }
            else return true;

        }
        private void btnedit_Click(object sender, EventArgs e)
        {
            int ms, price, amount;
            string name, type;
            #region Check text
            if (checkNumber(txtms.Text) && checkNumber(txtprice.Text) && checkNumber(txtSL.Text))
            {
                ms = Convert.ToInt32(txtms.Text);
                price = Convert.ToInt32(txtprice.Text);
                amount = Convert.ToInt32(txtSL.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ và đúng định dạng");
                return;
            }
            if ((txtname.Text != null || txtname.Text != "")
                && (comboBox1.SelectedItem.ToString() != null || comboBox1.SelectedItem.ToString() != ""))
            {
                name = txtname.Text;
                type = comboBox1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin đầy đủ và đúng định dạng");
                return;
            }
            string description = txtdes.Text;
            DateTime inputday = dtpinput.Value;
            #endregion

            MemoryStream picture = new MemoryStream();
            try
            {

                if (verif())
                {

                    pctPr.Image.Save(picture, pctPr.Image.RawFormat);
                    if (product.updateProduct(ms, name, price, description, type, inputday, amount, picture))
                    {
                        MessageBox.Show("Product Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT * FROM Product where state = 1"));
                        btnedit.Enabled = false;
                        btnRemove.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = false;
            txtms.Text = "MS";
            txtname.Text = "Name";
            txtprice.Text = "Price";
            txtdes.Text = "Description";
            comboBox1.Text = "Type";
            txtSL.Text = "Amount";
            //pctPr.Image = Properties.Resources.Circle_icons_image_svg;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int ms = Convert.ToInt32(txtms.Text);
                if (MessageBox.Show("Are you sure you want to remove this product", "Manage Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (product.deleteProduct(ms))
                    {
                        MessageBox.Show("This Product Deleted", "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        label6.Visible = false;
                        label8.Visible = false;
                        txtms.Text = "MS";
                        txtname.Text = "Name";
                        txtprice.Text = "Price";
                        txtdes.Text = "Description";
                        comboBox1.Text = "Type";
                        txtSL.Text = "Amount";
                        fillGrid(new SqlCommand("SELECT * FROM Product where state = 1"));
                        btnedit.Enabled = false;
                        btnRemove.Enabled = false;

                    }
                    else MessageBox.Show("Error", "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID", "Manage Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.manapro manapro = new Pro.manapro();
            manapro.Show();
            this.Close();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addnewProduct newpro = new addnewProduct();
            newpro.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label8.Visible = true;

            txtms.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtprice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtdes.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtpinput.Value = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;
            txtSL.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[8].Value;
            MemoryStream picture = new MemoryStream(pic);
            pctPr.Image = Image.FromStream(picture);
            pctPr.SizeMode = PictureBoxSizeMode.Zoom;

            btnAdd.Enabled = true;
            btnedit.Enabled = true;
            btnRemove.Enabled = true;
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

        #endregion


    }
}
