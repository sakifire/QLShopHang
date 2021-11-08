using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFramework.Class;
using Microsoft.Office.Interop.Excel;
using appp = Microsoft.Office.Interop.Excel.Application;



namespace TestFramework.Pro
{
    public partial class manaOrder : Form
    {
        public manaOrder()
        {
            InitializeComponent();
            btneditor.Enabled = false;
            btnremoveor.Enabled = false;
        }
        Order order = new Order();

        private void manaOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diamondGroupDataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.diamondGroupDataSet.Bill);

        }
        private void btneditor_Click(object sender, EventArgs e)
        {
            #region check logic
            int id, phone, amount, price, total, sale;
            if(checkNumber(txtidor.Text)
                && checkNumber(txtphoneor.Text)
                && checkNumber(txtamountor.Text)
                && checkNumber(txtpriceor.Text)
                && checkNumber(txttotalor.Text)
                && checkNumber(txtsaleor.Text))
            {
                id = Convert.ToInt32(txtidor.Text);
                phone = Convert.ToInt32(txtphoneor.Text);
                amount = Convert.ToInt32(txtamountor.Text);
                price = Convert.ToInt32(txtpriceor.Text);
                total = Convert.ToInt32(txttotalor.Text);
                sale = Convert.ToInt32(txtsaleor.Text);
            }
            else 
            {
                MessageBox.Show("Xin vui lòng nhập đúng định dạng");
                return;
            }
            
            DateTime date = datetimeor.Value;
            int manv = GlobalsMaNV.GlobalMaNV;
            string product;
            if(txtproductor.Text != null && txtproductor.Text != "")
            {
                product = txtproductor.Text;
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập đúng định dạng");
                return;
            }
            #endregion 
            try
            {
                    if (order.editbill(id, phone, amount, product, price, total, date, sale, manv))
                    {
                        MessageBox.Show("This Order Edited", "Manage Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGridOr(new SqlCommand("select * from Bill"));
                        btnremoveor.Enabled = false;
                        btneditor.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error", "Manage Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Manage Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        public void fillGridOr(SqlCommand command)
        {
            data.ReadOnly = true;
            data.RowTemplate.Height = 80;
            data.DataSource = order.getOrders(command);
        }
        private void btnremoveor_Click(object sender, EventArgs e)
        {
            int id;
            if (checkNumber(txtidor.Text))
            { id = Convert.ToInt32(txtidor.Text); }
            else
            {
                MessageBox.Show("ID sản phẩm chưa có");
                return;
            }
            if (MessageBox.Show("Are you sure you want to remove this order ?", "Manage Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (order.delteBill(id))
                {
                    MessageBox.Show("This order removed", "Manage Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fillGridOr(new SqlCommand("select * from Bill"));
                    lbelidor.Visible = false;
                    lbelproductor.Visible = false;
                    lblamountor.Visible = false;
                    lblphoneor.Visible = false;
                    lblsaleor.Visible = false;
                    lblpriceor.Visible = false;
                    lbltotalor.Visible = false;
                    txtidor.Text = "ID";          
                    txtphoneor.Text = "Phone";
                    txtproductor.Text = "Name's Product";
                    txtamountor.Text = "Amount";
                    txtpriceor.Text = "Price";
                    txttotalor.Text = "Total";
                    txtsaleor.Text = "Sales";
                    btnremoveor.Enabled = false;
                    btneditor.Enabled = false;
                }
                else MessageBox.Show("Error", "Manage Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnresetor_Click(object sender, EventArgs e)
        {
            lbelidor.Visible = false;         
            lbelproductor.Visible = false;  
            lblamountor.Visible = false;
            lblphoneor.Visible = false;
            lblsaleor.Visible = false;
            lblpriceor.Visible = false;
            lbltotalor.Visible = false;
            txtidor.Text = "ID";
            txtphoneor.Text = "Phone";
            txtproductor.Text = "Name's Product";
            txtamountor.Text = "Amount";
            txtpriceor.Text = "Price";
            txttotalor.Text = "Total";
            txtsaleor.Text = "Sales";
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveex = new SaveFileDialog();
            if (saveex.ShowDialog() == DialogResult.OK)
            {
                appp obj = new appp();
                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 15;
                for (int i = 1; i < data.Columns.Count + 1; i++)
                {
                    obj.Cells[1, i] = data.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    for (int j = 0; j < data.Columns.Count; j++)
                    {
                        if (data.Rows[i].Cells[j].Value != null)
                        {
                            obj.Cells[i + 2, j + 1] = data.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                obj.ActiveWorkbook.SaveCopyAs(saveex.FileName + ".xlsx");
                obj.ActiveWorkbook.Saved = true;
                MessageBox.Show("Data Saved", "Print Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Not Saved", "Print Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
     
        private void txtsaleor_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btneditor.Enabled = true;
            btnremoveor.Enabled = true;
            lbelidor.Visible = true;         
            lbelproductor.Visible = true;         
            lblamountor.Visible = true;
            lblphoneor.Visible = true;
            lblsaleor.Visible = true;
            lblpriceor.Visible = true;
            lbltotalor.Visible = true;
            txtidor.Text = data.CurrentRow.Cells[0].Value.ToString();        
            txtphoneor.Text = data.CurrentRow.Cells[1].Value.ToString();
            txtproductor.Text = data.CurrentRow.Cells[3].Value.ToString();
            txtamountor.Text = data.CurrentRow.Cells[2].Value.ToString();
            txtpriceor.Text = data.CurrentRow.Cells[4].Value.ToString();
            txttotalor.Text = data.CurrentRow.Cells[5].Value.ToString();
            datetimeor.Value = (DateTime)data.CurrentRow.Cells[6].Value;
            txtsaleor.Text = data.CurrentRow.Cells[7].Value.ToString();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
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
