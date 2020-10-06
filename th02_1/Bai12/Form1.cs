using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai12
{
    public partial class Form1 : Form
    {
        List<int> arr = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput.Text = labResult.Text = "";
            lbArr.Items.Clear();
            arr.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập số nguyên vào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtInput.Focus();
                }
                else
                {
                    int num = int.Parse(txtInput.Text);

                    lbArr.Items.Add(txtInput.Text);
                    arr.Add(num);

                    txtInput.Text = "";
                    txtInput.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập số nguyên vào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInput.Text = "";
                txtInput.Focus();
            }
        }

        private void delete(List<int> arr)
        {
            int id = lbArr.SelectedIndex;
            if (arr.Count > 0)
            {
                if (id != -1)
                {
                    DialogResult h = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (h == DialogResult.Yes)
                    {
                        arr.RemoveAt(id);
                        lbArr.Items.RemoveAt(id);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn phần tử để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có phần tử để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete(arr);
        }

        private bool isPrime(int n)
        {
            if (n == 2) return true;
            if (n < 2 || n % 2 == 0) return false;

            int h = (int)Math.Sqrt((double)n);
            for (int i = 3; i <= h; i += 2)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int id = lbArr.SelectedIndex;
            if (arr.Count > 0)
            {
                if (id != -1)
                {
                    if (isPrime(arr[id]) == true)
                        labResult.Text = arr[id].ToString() + " là số nguyên tố.";
                    else
                        labResult.Text = arr[id].ToString() + " không là số nguyên tố.";
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn phần tử để kiểm tra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có phần tử để kiểm tra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
