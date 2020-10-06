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

namespace Bai13
{
    public partial class Form1 : Form
    {
        List<int> arr = new List<int>();
        string s;

        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            s = "Dãy số vừa nhập là: ";
            txtInput.Text = txtK.Text = labMin.Text = labOutput.Text = "";
            btnFind.Enabled = btnMin.Enabled = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text == "")
                {
                    MessageBox.Show("Không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInput.Focus();
                }
                else
                {
                    int num = 0;
                    do
                    {
                        num = int.Parse(txtInput.Text);
                        if (num < 0)
                        {
                            MessageBox.Show("Số lượng phần tử không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtInput.Text = "";
                            txtInput.Focus();
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
                    labOutput.Text = s;
                    btnMin.Enabled = btnFind.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kiểu dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Focus();
            }
        }

        private int Min_arr(List<int> arr)
        {
            int Min = Int32.MaxValue;

            foreach (int item in arr)
            {
                if (item < Min && item > 0)
                {
                    Min = item;
                }
            }

            if (Min != Int32.MaxValue) return Min;
            return -1;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (Min_arr(arr) == -1)
            {
                labMin.Text = "Dãy không có số nguyên dương.";
            }
            else
            {
                labMin.Text = "Số dương nhỏ nhất là: " + Min_arr(arr).ToString();
            }
        }

        private List<int> Find_arr(List<int> arr, int k)
        {
            List<int> f = new List<int>();

            for (int i = 0; i < arr.Count; ++i)
            {
                if (arr[i] == k)
                {
                    f.Add(i + 1);
                }
            }

            return f;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtK.Text == "")
                {
                    MessageBox.Show("Không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtK.Focus();
                }
                else
                {
                    int k = int.Parse(txtK.Text);

                    List<int> f = new List<int>();
                    f = Find_arr(arr, k);

                    string mess;
                    if (f.Count == 0)
                    {
                        mess = "Không tìm thấy phần tử có giá trị " + txtK.Text;
                    }
                    else
                    {
                        mess = "Số phần tử có giá trị " + txtK.Text + " là " + f.Count.ToString() + " phần tử nằm ở vị trí: ";
                        for (int i = 0; i < f.Count; ++i)
                        {
                            mess += f[i].ToString();
                            if (i != f.Count - 1) mess += ", ";
                        }
                    }

                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kiểu dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtK.Focus();
            }
        }
    }
}
