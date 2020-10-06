using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Bai7
{
    public partial class Form1 : Form
    {
        List<int> arr = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            s = "Dãy số vừa nhập là: ";
            txtNhap.Text = labNhap.Text = labRes.Text =  "";
            combChon.Text = "";
            combChon.Enabled = false;
            arr.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
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
            reset();
        }

        string s;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNhap.Text == "")
                {
                    MessageBox.Show("Không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNhap.Focus();
                }
                else
                {
                    int num = 0;
                    do
                    {
                        num = int.Parse(txtNhap.Text);
                        if (num < 0)
                        {
                            MessageBox.Show("Số lượng phần tử không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtNhap.Text = "";
                            txtNhap.Focus();
                        }
                    } while (num < 0);

                    while (num != 0)
                    {
                        string fstring = Interaction.InputBox("Nhập 1 giá trị của dãy: ", "Thêm", "", 430, 400);
                        int value = 0;
                        if (fstring == "" || int.TryParse(fstring, out value) == false)
                        {
                            MessageBox.Show("Lỗi định dạng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            value = int.Parse(fstring);
                            arr.Add(value);
                            s += fstring + " ";
                            num--;
                        }
                    }
                    labNhap.Text = s;
                    combChon.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kiểu dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhap.Focus();
            }
        }

        private double TBC(List<int> arr)
        {
            double sum = 0;
            foreach(int item in arr)
            {
                sum += item;
            }
            return Math.Round(sum / arr.Count, 3);
        }

        private double Count_arr(List<int> arr)
        {
            int count = 0;
            foreach (int item in arr)
            {
                if (item < 0) count++;
            }
            return count;
        }

        private void combChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combChon.Text == "Trung bình cộng của dãy")
            {
                labRes.Text = "TBC của dãy số là: " + TBC(arr).ToString();
            }
            else if (combChon.Text == "Đếm số phần tử âm")
            {
                labRes.Text = "Số phần tử âm của dãy số là: " + Count_arr(arr).ToString();
            }
        }
    }
}
