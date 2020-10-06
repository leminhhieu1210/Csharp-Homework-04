using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        List<Book> lb = new List<Book>();
        Book b = new Book();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cobBook.Focus();
            btnMoney.Enabled = btnDelete.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cobBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            b.Name = cobBook.Text;
            switch (cobBook.SelectedIndex)
            {
                case 0:
                    txtPrice.Text = "22000";
                    break;
                case 1:
                    txtPrice.Text = "27000";
                    break;
                case 2:
                    txtPrice.Text = "25000";
                    break;
                case 3:
                    txtPrice.Text = "26000";
                    break;
            }
            b.Price = int.Parse(txtPrice.Text);
        }

        private void radCash_CheckedChanged(object sender, EventArgs e)
        {
            txtSale.Text = "5";
            b.Sale = double.Parse(txtSale.Text);
        }

        private void radATM_CheckedChanged(object sender, EventArgs e)
        {
            txtSale.Text = "10";
            b.Sale = double.Parse(txtSale.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text == "" || cobBook.Text == "" || (radATM.Checked == false && radCash.Checked == false))
                {
                    MessageBox.Show("Bạn chưa nhập hết dữ liệu!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cobBook.Focus();
                }
                else
                {
                    int num = int.Parse(txtAmount.Text);

                    if (num < 0)
                    {
                        MessageBox.Show("Lỗi kiểu dữ liệu!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAmount.Focus();
                    }
                    else
                    {
                        b.Amount = num;
                        b.Prices = b.Amount * b.Price * (1 - b.Sale / 100);
                        
                        lbBooks.Items.Add(b.Name + ", " + b.Amount.ToString() + " - " + b.Prices.ToString());
                        lb.Add(b);

                        btnDelete.Enabled = btnMoney.Enabled = true;
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Lỗi kiểu dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lb.Count > 0)
            {
                int id = lbBooks.SelectedIndex;
                if (id != -1)
                {
                    DialogResult h = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (h == DialogResult.Yes)
                    {
                        lb.RemoveAt(id);
                        lbBooks.Items.RemoveAt(id);
                    }
                    if (lb.Count == 0)
                    {
                        btnMoney.Enabled = false;
                        rtbResult.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Bạn hãy chọn phần tử để xoá!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có sách để xoá!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private double sumMoney(List<Book> arr)
        {
            double sum = 0;
            foreach(Book item in arr)
            {
                sum += item.Prices;
            }
            return sum;
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            rtbResult.Text = "";
            if (lb.Count > 0) rtbResult.Text = sumMoney(lb).ToString();
            else btnMoney.Enabled = false;
        }
    }
}
