using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            radbCaNgay.Checked = radbNuaNgay.Checked = false;
            combDoUong.Text = combSoLuong.Text = "";
            txtHoten.Text = txtGia.Text = txtTien.Text = "";
            txtHoten.Focus();
        }

        private void radbCaNgay_CheckedChanged(object sender, EventArgs e)
        {
            txtGia.Text = "200";
        }

        private void radbNuaNgay_CheckedChanged(object sender, EventArgs e)
        {
            txtGia.Text = "100";
        }

        double doUong = 0;
        private void combSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combDoUong.Text.Equals("") == false) //kiểm tra comboBox DoUong có rỗng không
            {
                if (combDoUong.Text == "Coca cola")
                {
                    doUong = 0.5 * int.Parse(combSoLuong.Text);
                }
                else if (combDoUong.Text == "Pepsi")
                {
                    doUong = 0.8 * int.Parse(combSoLuong.Text);
                }
                else
                {
                    doUong = 1 * int.Parse(combSoLuong.Text);
                }
                txtTien.Text = doUong.ToString();
            }

        }

        private void combDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combSoLuong.Text.Equals("") == false) //kiểm tra comboBox SoLuong có rỗng không
            {
                if (combDoUong.Text == "Coca cola")
                {
                    doUong = 0.5 * int.Parse(combSoLuong.Text);
                }
                else if (combDoUong.Text == "Pepsi")
                {
                    doUong = 0.8 * int.Parse(combSoLuong.Text);
                }
                else
                {
                    doUong = 1 * int.Parse(combSoLuong.Text);
                }
                txtTien.Text = doUong.ToString();
            }
        }

        private void btnThemDS_Click(object sender, EventArgs e)
        {
            string gia = "", s;
            double tongTien = 0;

            if (radbCaNgay.Checked == true)
            {
                gia = "Cả ngày 200$";
                tongTien += 200;
            }
            if (radbNuaNgay.Checked == true)
            {
                gia = "Nửa ngày 100$";
                tongTien += 100;
            }
            tongTien += doUong;

            s = txtHoten.Text + " | " + gia + " | Đồ uống " + txtTien.Text + " $ | Tổng " + tongTien.ToString() + " $";
            lbDS.Items.Add(s);
        }
    }
}
