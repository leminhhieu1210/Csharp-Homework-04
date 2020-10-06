using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        List<double> arr = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            btnXoa.Enabled = false;

            arr.Clear();
            arr.Add(4);
            arr.Add(46.8);
            arr.Add(95);
            lbDS.Items.Clear();
            lbDS.Items.Add("4");
            lbDS.Items.Add("46.8");
            lbDS.Items.Add("95");

            labGT.Text = txtNhap.Text = "";
            txtNhap.Focus();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double num = 0;
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhap.Focus();
            }
            else if (double.TryParse(txtNhap.Text, out num) == false)
            {
                MessageBox.Show("Lỗi định dạng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhap.Focus();
            }
            else
            {
                num = double.Parse(txtNhap.Text);
                lbDS.Items.Add(num);
                arr.Add(num);

                txtNhap.Text = "";
                txtNhap.Focus();
            }
        }

        private void lbDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void removeList(List<double> arr)
        {
            if (arr.Count > 1)
            {
                if (lbDS.SelectedIndex != -1)
                {
                    arr.RemoveAt(lbDS.SelectedIndex);
                    lbDS.Items.RemoveAt(lbDS.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Hãy chọn vào thuộc tính muốn xoá rồi nhấn Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNhap.Focus();
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xoá!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (h == DialogResult.Yes)
            {
                removeList(arr);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            double Max = arr[0];
            foreach (double item in arr)
            {
                if (Max < item)
                {
                    Max = item;
                }
            }
            labGT.Text = "Giá trị lớn nhất của dãy là: " + Max.ToString();
        }
    }
}
