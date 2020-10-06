using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rabBac1.Checked = true;
            rabBac2.Checked = false;
            reset();
        }

        private void reset()
        {
            txtA.Text = txtB.Text = txtC.Text = txtResult.Text = "";
            txtA.Focus();

            if (rabBac1.Checked == true) txtC.Enabled = false;
            else txtC.Enabled = true;
            txtResult.Enabled = false;
        }

        private void rabBac1_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            txtC.Enabled = false;
        }

        private void rabBac2_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            txtC.Enabled = true;
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

        private void solve1(double a, double b, out string s1, out string s2)
        {
            s1 = s2 = "";
            if (a == 0)
            {
                if (b == 0)
                {
                    s1 = "Phương trình có vô số nghiệm.";
                }
                else
                {
                    s1 = "Phương trình vô nghiệm.";
                }
            }
            else
            {
                s1 = "Phương trình có nghiệm: ";
                s2 += "x = " + (Math.Round(-b / a, 3)).ToString();
            }
        }

        private void solve2(double a, double b, double c, out string s1, out string s2)
        {
            s1 = s2 = "";
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        s1 = "Phương trình có vô số nghiệm.";
                    }
                    else
                    {
                        s1 = "Phương trình vô nghiệm.";
                    }
                }
                else
                {
                    solve1(b, c, out s1, out s2);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    s1 = "Phương trình vô nghiệm.";
                }
                else if (delta == 0)
                {
                    s1 = "Phương trình có nghiệm kép:";
                    double x = -b / (2 * a);
                    s2 += " x = " + x.ToString();
                }
                else
                {
                    s1 = "Phương trình có 2 nghiệm phân biệt: ";
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    s2 += "x1 = " + x1.ToString() + " và x2 = " + x2.ToString();
                }
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtA.Text == "")
                {
                    MessageBox.Show("Không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtA.Focus();
                }
                else if (txtB.Text == "")
                {
                    MessageBox.Show("Không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtB.Focus();
                }
                else if (txtC.Text == "" && rabBac2.Checked == true)
                {
                    MessageBox.Show("Không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtC.Focus();
                }
                else
                {
                    string s1 = "", s2 = "", endl = Environment.NewLine;

                    if (rabBac1.Checked == true)
                    {
                        solve1(double.Parse(txtA.Text), double.Parse(txtB.Text), out s1, out s2);
                    }
                    else if (rabBac2.Checked == true)
                    {
                        solve2(double.Parse(txtA.Text), double.Parse(txtB.Text), double.Parse(txtC.Text), out s1, out s2);
                    }

                    txtResult.Text = "";
                    txtResult.AppendText(s1);
                    txtResult.AppendText(endl);
                    txtResult.AppendText(s2);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kiểu dữ liệu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }
        }
    }
}