using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        List<DSMonHoc> ds = new List<DSMonHoc>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void combTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combTen.Text == "Tin học đại cương")
            {
                txtSoTinChi.Text = "2";
            }
            if (combTen.Text == "Giải tích F1")
            {
                txtSoTinChi.Text = "3";
            }
            if (combTen.Text == "Tiếng Anh A0")
            {
                txtSoTinChi.Text = "3";
            }
            if (combTen.Text == "Triết học Mác - Lênin")
            {
                txtSoTinChi.Text = "2";
            }
            if (combTen.Text == "Vật lý F1")
            {
                txtSoTinChi.Text = "3";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            double diem;
            if (txtDiem.Text == "" || combTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hết dữ liệu!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem.Focus();
            }
            else if (double.TryParse(txtDiem.Text, out diem) == false)
            {
                MessageBox.Show("Điểm không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiem.Focus();
            }
            else
            {
                if (double.Parse(txtDiem.Text) < 0)
                {
                    MessageBox.Show("Điểm không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiem.Focus();
                }
                else
                {
                    string s = combTen.Text + ", " + txtSoTinChi.Text + ", " + txtDiem.Text;
                    lbDS.Items.Add(s);
                    DSMonHoc ob = new DSMonHoc(combTen.Text, int.Parse(txtSoTinChi.Text), double.Parse(txtDiem.Text));
                    ds.Add(ob);
                }
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (combTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên môn học.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                combTen.Focus();
            }
            else
            {
                int tongTinChi = 0;
                double tongDiem = 0, diemTB = 0;

                foreach (DSMonHoc item in ds)
                {
                    tongTinChi += item.TinChi;
                    tongDiem += item.TinChi * item.Diem;
                }
                diemTB = tongDiem / tongTinChi;

                txtTongTinChi.Text = tongTinChi.ToString();
                txtTongDiem.Text = tongDiem.ToString();
                txtDiemTB.Text = diemTB.ToString();
            }
        }
    }
}
