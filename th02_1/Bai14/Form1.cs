using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai14
{
    public partial class Form1 : Form
    {
        List<SinhVien> sv = new List<SinhVien>();
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

        private void reset()
        {
            txtName.Text = "";
            cboKhoa.SelectedIndex = cboK.SelectedIndex = -1;
            lstDS.Items.Clear();
            lstBooks.SelectedIndex = -1;
            sv.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || cboKhoa.Text == "" || cboK.Text == "" || lstBooks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string str;
                str = sv.Count.ToString() + ". " + txtName.Text + " " + cboKhoa.Text + " K" + cboK.Text + " ĐK: ";

                List<string> f = new List<string>();
                foreach (var item in lstBooks.SelectedItems)
                {
                    f.Add(item.ToString());
                    str += item.ToString() + ", ";
                }

                lstDS.Items.Add(str);
                SinhVien s = new SinhVien(sv.Count, txtName.Text, cboKhoa.Text, int.Parse(cboK.Text), f);
                sv.Add(s);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstDS.SelectedIndex;
            if (sv.Count > 0)
            {
                if (i != -1)
                {
                    DialogResult h = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (h == DialogResult.Yes)
                    {
                        sv.RemoveAt(i);
                        lstDS.Items.Clear();

                        string str = "";
                        for (int j = 0; j < sv.Count; ++j)
                        {
                            sv[j].ID = j; //Cập nhập lại id
                            str = j.ToString() + ". " + sv[j].Hoten + " " + sv[j].Khoa + " K" + sv[j].K + " ĐK: ";
                            foreach (var item in sv[j].GiaoTrinh1)
                            {
                                str += item.ToString() + ", ";
                            }
                            lstDS.Items.Add(str); //Thêm vào listBox
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn phần tử để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có phần tử để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
