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

namespace th02_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxThoiGianGui.Items.Add("1");
            cbxThoiGianGui.Items.Add("3");
            cbxThoiGianGui.Items.Add("6");
            cbxThoiGianGui.Items.Add("12");
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = txtHoTen.Text = txtDiaChi.Text = txtSoTienGui.Text = txtNgayGui.Text = "";
            rdbThuong.Checked = rdbPhatLoc.Checked = false;
            cbxThoiGianGui.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
                this.Close();
        }

        List<KhachHang> lKH = new List<KhachHang>();
        private void btnThemDS_Click(object sender, EventArgs e)
        {
            DateTime ngaygui;
            long sotiengui;
            int thoigiangui;

            if (txtMaKH.Text.Length != 6)
            {
                MessageBox.Show("Mã khách hàng phải chứa 6 ký tự.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
            }
            else if (txtHoTen.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
            }
            else if (DateTime.TryParse(txtNgayGui.Text, out ngaygui) == false)
            {
                MessageBox.Show("Nhập sai định dạng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgayGui.Focus();
            }
            else if (long.TryParse(txtSoTienGui.Text, out sotiengui) == false)
            {
                MessageBox.Show("Nhập sai định dạng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTienGui.Focus();
            }
            else if (rdbThuong.Checked == false && rdbPhatLoc.Checked == false)
            {
                MessageBox.Show("Chưa chọn loại tiết kiệm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (int.TryParse(cbxThoiGianGui.Text, out thoigiangui) == false)
            {
                MessageBox.Show("Nhập sai định dạng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxThoiGianGui.Focus();
            }
            else
            {
                string s, loai = "Thường";
                float ls = 0.0F, lai;
                switch(int.Parse(cbxThoiGianGui.Text))
                {
                    case 1:
                        {
                            ls = 0.06F;
                            break;
                        }
                    case 3:
                        {
                            ls = 0.07F;
                            break;
                        }
                    case 6:
                        {
                            ls = 0.08F;
                            break;
                        }
                    case 12:
                        {
                            ls = 0.09F;
                            break;
                        }
                }
                if (rdbPhatLoc.Checked == true)
                {
                    ls += 0.01F;
                    loai = "Phát Lộc";
                }

                lai = ls * sotiengui;
                s = txtMaKH.Text + " | " + txtHoTen.Text + " | " + txtDiaChi.Text + " | " + txtSoTienGui.Text + " | " + txtNgayGui.Text + " | " + cbxThoiGianGui.Text + " tháng | " + loai + " | " + lai.ToString();
                lbDSKH.Items.Add(s);
                KhachHang k = new KhachHang(txtHoTen.Text, txtDiaChi.Text, loai, txtNgayGui.Text, int.Parse(txtMaKH.Text), int.Parse(cbxThoiGianGui.Text), long.Parse(txtSoTienGui.Text), lai);
                lKH.Add(k);
            }
        }

        //ten project --> Add --> Reference --> Microsoft.VisualBasic
        private void btnTim_Click(object sender, EventArgs e)
        {
            string fstring = Interaction.InputBox("Nhập mã khách hàng", "Tìm kiếm", "", 430, 400);
            int check = 0, ma;

            if (int.TryParse(fstring, out ma) == true)
            {
                foreach (KhachHang item in lKH)
                {
                    if (item.MaKH1 == ma)
                    {
                        lbDSKH.Items.Clear();
                        lbDSKH.Items.Add(item.MaKH1.ToString() + " | " + item.SoTienLai1.ToString());
                        check = 1;
                        break;
                    }
                }
            }
            if (check == 0)
            {
                MessageBox.Show("Khách hàng có mã " + fstring + " hiện chưa có trong danh sách.", "Tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
