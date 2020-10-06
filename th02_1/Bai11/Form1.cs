using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.L)
            {
                btnReset.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.T)
            {
                btnExit.PerformClick();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHeading.Text = "TIN HỌC ĐẠI CƯƠNG";
            txtHeading.Font = new Font("Microsoft Sans Serif", 16);
            cobFont.Text = cobSize.Text = "";
            chebBold.Checked = chebItalic.Checked = chebULine.Checked = false;
            radRed.Checked = radGreen.Checked = radBlack.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cobFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cobFont.SelectedIndex)
            {
                case 0:
                    txtHeading.Font =  new Font(cobFont.Text, 12);
                    break;
                case 1:
                    txtHeading.Font = new Font(cobFont.Text, 12);
                    break;
                case 2:
                    txtHeading.Font = new Font(cobFont.Text, 12);
                    break;
                case 3:
                    txtHeading.Font = new Font(cobFont.Text, 12);
                    break;
                case 4:
                    txtHeading.Font = new Font(cobFont.Text, 12);
                    break;
                case 5:
                    txtHeading.Font = new Font(cobFont.Text, 12);
                    break;
            }
        }

        private void cobSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobFont.Text != "")
            {
                txtHeading.Font = new Font(cobFont.Text, int.Parse(cobSize.Text));
            }
        }

        private void chebBold_CheckedChanged(object sender, EventArgs e)
        {
            if (cobFont.Text != "")
            {
                txtHeading.Font = new Font(txtHeading.Font, FontStyle.Bold);
            }
        }

        private void chebItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (cobFont.Text != "")
            {
                txtHeading.Font = new Font(txtHeading.Font, FontStyle.Italic);
            }
        }

        private void chebULine_CheckedChanged(object sender, EventArgs e)
        {
            if (cobFont.Text != "")
            {
                txtHeading.Font = new Font(txtHeading.Font, FontStyle.Underline);
            }
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (cobFont.Text != "")
            {
                txtHeading.ForeColor = Color.Red;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (cobFont.Text != "")
            {
                txtHeading.ForeColor = Color.Green;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (cobFont.Text != "")
            {
                txtHeading.ForeColor = Color.Black;
            }
        }
    }
}
