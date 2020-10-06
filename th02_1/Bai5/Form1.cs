using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
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
            txtNhap.Text = "";
            txtNhap.Focus();
            btnTinh.Enabled = btnMax.Enabled = btnXoa.Enabled = false;
            labTong.Text = labMax.Text = "";
            lbDaySo.Items.Clear();
            arr.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double num = 0;
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                lbDaySo.Items.Add(num);
                arr.Add(num);

                txtNhap.Text = "";
                txtNhap.Focus();
                btnTinh.Enabled = btnMax.Enabled = btnXoa.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (arr.Count > 0)
            {
                if (lbDaySo.SelectedIndex != -1)
                {
                    arr.RemoveAt(lbDaySo.SelectedIndex);
                    lbDaySo.Items.RemoveAt(lbDaySo.SelectedIndex); 
                }
                else
                {
                    MessageBox.Show("Hãy chọn vào thuộc tính muốn xoá rồi nhấn Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xoá!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double sum = 0;
            foreach (double item in arr)
            {
                sum += item;
            }
            labTong.Text = "Tổng = " + sum.ToString();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            double Max = arr[0];
            foreach (double item in arr)
            {
                if (Max < item)
                {
                    Max = item;
                }
            }
            labMax.Text = "Max = " + Max.ToString();
        }
    }
}
