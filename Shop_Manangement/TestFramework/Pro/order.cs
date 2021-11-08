
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFramework.Class;
using TestFramework.Staff;

namespace TestFramework.Pro
{
    public partial class order : Form
    {
        MyData mydb = new MyData();
        public void getImageAndUsername()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Select * from Staff where id = @manv", mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = GlobalsMaNV.GlobalMaNV;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0][6];
                MemoryStream picture = new MemoryStream(pic);
                avatar.Image = Image.FromStream(picture);
                avatar.SizeMode = PictureBoxSizeMode.Zoom;
                lblname.Text = table.Rows[0][1].ToString() + " " + table.Rows[0][2].ToString();

            }
        }
        public order()
        {
            InitializeComponent();
        }
        PRODUCT products = new PRODUCT();
        CTSALES sa = new CTSALES();
        NV nv = new NV();
        KH kh = new KH();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Order myorder = new Order();
            NV nv = new NV();
            int id, amount, price, total;
            if(checkNumber(txtid.Text)
                && checkNumber(txtamount.Text)
                && checkNumber(txtprice.Text)
                && checkNumber(txttotal.Text))
            {
                id = Convert.ToInt32(txtid.Text); 
                amount = Convert.ToInt32(txtamount.Text);
                price = Convert.ToInt32(txtprice.Text);
                total = Convert.ToInt32(txttotal.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
                return;
            }
            string phone;
            string product;
            if(txtphone.Text != null && txtphone.Text != "" && txtPr.Text !="" && txtPr != null)
            {
                phone = txtphone.Text;
                product = txtPr.Text;
            }  else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
                return;
            }  
            DateTime date = datetime.Value;
            int sale = (int)listSales.SelectedValue;
            int manv = GlobalsMaNV.GlobalMaNV;
            int idpro = Globals.GlobalProductId;
            if (verif())
            {
                if (myorder.addbill(id, phone, amount, product, price, total, date, sale ,manv,idpro))
                {
                    
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    SqlCommand command = new SqlCommand("select * from dbo.getPhone()", mydb.GetConnection);
                    adapter.SelectCommand = command;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        string phoneid = table.Rows[0][0].ToString();
                        GlobalsPhone.SetGlobalsPhone(phoneid);
                        addCus addCus = new addCus();
                        addCus.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("New Order Added", "Add Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Error", "Add Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //products.updateSLsale(Globals.GlobalProductId, amount);
            
           

        
        bool verif()
        {
            if (txtPr.Text.Trim() == "" || txtPr.Text.Trim() == "")
            {
                return false;
            }
            else return true;
        }
        }
      
        private void txtPr_Click(object sender, EventArgs e)
        {
            txtPr.Clear();
            label6.Visible = true;
            formMain listPruduct = new formMain();
            listPruduct.Show(this);
            this.Hide();

            

        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PRODUCT product = new PRODUCT();
                DataTable table = product.getProductById(Globals.GlobalProductId);
                int price = Convert.ToInt32(table.Rows[0][3]);
                label5.Visible = true;
                //txtprice.Text = price.ToString();
                txttotal.Text = (Convert.ToInt32(txtamount.Text) * price).ToString();
            }
            catch { }
        }

        public float valuesale(int id)
        {
            DataTable table = sa.getInf(id);
            int sale = Convert.ToInt32(table.Rows[0][0].ToString());
            float kq = (float)((100 - sale) * 0.01);
            return kq;
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        CTSALES sal = new CTSALES();
        private void order_Load(object sender, EventArgs e)
        {
            getImageAndUsername();
            listSales.DataSource = sal.getall();
            listSales.ValueMember = "saleid";
            listSales.DisplayMember = "name";
        }

        private void listSales_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                label10.Visible = true;
                int bandau = Convert.ToInt32(txttotal.Text);
                int id = Convert.ToInt32(listSales.SelectedValue.ToString());
                float heso = valuesale(id);
                float gia = (float)((float)Convert.ToInt32(bandau) * heso);
                txttotal.Text = gia.ToString();
            }
            catch { }
        }

        private void lblname_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DetailsNV detailnv = new DetailsNV();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("Select * from Staff where id =@uid", mydb.GetConnection);
            command.Parameters.Add("@uid", SqlDbType.NChar).Value = GlobalsMaNV.GlobalMaNV;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            detailnv.tbmanv.Text = table.Rows[0][0].ToString();
            detailnv.tbholot.Text = table.Rows[0][1].ToString();
            detailnv.tbten.Text = table.Rows[0][2].ToString();
            if ((table.Rows[0][4].ToString() == "Nam"))
            {
                detailnv.rbnam.Checked = true;
            }
            else
            {
                detailnv.rbnu.Checked = true;
            }
            detailnv.tbdiachi.Text = table.Rows[0][5].ToString();
            detailnv.tbsdt.Text = table.Rows[0][3].ToString();
            detailnv.tbmacv.Text = table.Rows[0][7].ToString();
            byte[] pic;
            pic = (byte[])table.Rows[0][6];
            MemoryStream picture = new MemoryStream(pic);
            detailnv.picstaff.BackgroundImage = Image.FromStream(picture);
            detailnv.picstaff.BackgroundImageLayout = ImageLayout.Stretch;
            detailnv.Show();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pro.order ord = new order();
            ord.Show();
            this.Close();

        }

        private void manageOrderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Pro.manaOrder manaord = new manaOrder();
            manaord.Show();
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
