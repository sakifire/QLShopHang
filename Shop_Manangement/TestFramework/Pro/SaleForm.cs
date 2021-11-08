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
//using System.Data;

namespace TestFramework.Pro
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
            btnedit.Enabled = false;
            btnremove.Enabled = false;
        }

        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = salect.getAllSales(command);
            dataGridView1.AllowUserToAddRows = false;
        }
        CTSALES salect = new CTSALES();

        private void btnadd_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int id = rand.Next(0, 100);
            DateTime start = startd.Value;
            DateTime finish = finishd.Value;
            string name;
            if (txtname.Text != "" && txtname != null)
            {
                name = txtname.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin");
                return;
            }
            int sale;
            if(checkNumber(txtsale.Text))
            {
                sale = Convert.ToInt32(txtsale.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin");
                return;
            }

            if (verif())
            {
                if (salect.insertsale(id, start, finish, name, sale))
                {

                    MessageBox.Show("This Sales Promotion Added", "Add new Promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("  select startdate as 'Start Day', finishdate as 'Finish Day', sales.name as 'Name', sale as 'Sale (%)' from sales"));
                    txtname.Text = "";
                    txtsale.Text = "";
                }
                else
                    MessageBox.Show("Error", "Add new Promotion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool verif()
        {
            if (txtname.Text.Trim() == "" || txtsale.Text.Trim() == "" )
            {
                return false;
            }
            return true;
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("  select startdate as 'Start Day', finishdate as 'Finish Day', sales.name as 'Name', sale as 'Sale (%)' from sales"));

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            DateTime start = startd.Value;
            DateTime finish = finishd.Value;
            string name;
            if (txtname.Text != "" && txtname != null)
            {
                name = txtname.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin");
                return;
            }
            int sale;
            if (checkNumber(txtsale.Text))
            {
                sale = Convert.ToInt32(txtsale.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng thông tin");
                return;
            }
            if (verif())
            {
                if (salect.updatesale(start, finish, name, sale))
                {

                    MessageBox.Show("This Sales Promotion Edited", "Edit Promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("  select startdate as 'Start Day', finishdate as 'Finish Day', sales.name as 'Name', sale as 'Sale (%)' from sales"));
                    btnremove.Enabled = false;
                    btnedit.Enabled = false;
                }
                else
                    MessageBox.Show("Error", "Edit Promotion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtname.Text;
                if (MessageBox.Show("Are you sure you want to remove this promotion ?", "Delete Promotion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (salect.deleteProduct(name))
                    {
                        MessageBox.Show("This Promotion Deleted", "Delete Promotion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("  select startdate as 'Start Day', finishdate as 'Finish Day', sales.name as 'Name', sale as 'Sale (%)' from sales"));
                        btnremove.Enabled = false;
                        btnedit.Enabled = false;
                    }
                    else
                        MessageBox.Show("Error", "Delete Promotion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            startd.Value = (DateTime)dataGridView1.CurrentRow.Cells[0].Value;
            finishd.Value = (DateTime)dataGridView1.CurrentRow.Cells[1].Value;
            txtname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsale.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            label4.Visible = true;
            label7.Visible = true;
            btnedit.Enabled = true;
            btnremove.Enabled = true;
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Manaform mana = new Manaform();
            mana.ShowDialog();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
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

