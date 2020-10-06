using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        List<int> arr = new List<int>();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdd.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập số nguyên vào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAdd.Focus();
                }
                else
                {
                    int num = int.Parse(txtAdd.Text);

                    lbDS.Items.Add(txtAdd.Text);
                    arr.Add(num);

                    txtAdd.Text = "";
                    txtAdd.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập số nguyên vào.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAdd.Text = "";
                txtAdd.Focus();
            }
        }

        private void delete(List<int> arr)
        {
            int id = lbDS.SelectedIndex;
            if (arr.Count > 0)
            {
                if (id != -1)
                {
                    DialogResult h = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (h == DialogResult.Yes)
                    {
                        arr.RemoveAt(id);
                        lbDS.Items.RemoveAt(id);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn phần tử để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có phần tử để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete(arr);
        }

        private void add3Arr(List<int> arr, int value)
        {
            //foreach(int item in arr)
            //{
            //    item = item + value;
            //}
            lbDS.Items.Clear();
            for (int i = 0; i < arr.Count; ++i)
            {
                arr[i] += value;
                lbDS.Items.Add(arr[i]);
            }
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            if (arr.Count > 0) add3Arr(arr, 3);
            else MessageBox.Show("Không có phần tử.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEven_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (arr.Count > 0)
            {
                for (int i = 0; i < arr.Count; ++i)
                {
                    if (arr[i] % 2 == 0)
                    {
                        id = i;
                        break;
                    }
                }
                if (id == -1)
                {
                    MessageBox.Show("Không có phần tử chẵn để chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lbDS.SelectedIndex = id;
                }
            }
            else
            {
                MessageBox.Show("Không có phần tử để chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
