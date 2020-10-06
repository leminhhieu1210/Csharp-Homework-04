namespace Bai5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDaySo = new System.Windows.Forms.ListBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.labTong = new System.Windows.Forms.Label();
            this.labMax = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(99, 39);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(100, 26);
            this.txtNhap.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 98);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(217, 58);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm vào &danh sách";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(27, 181);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(217, 58);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "&Xoá khỏi danh sách";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(27, 258);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(217, 58);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "&Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDaySo);
            this.groupBox1.Location = new System.Drawing.Point(285, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 258);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dãy số";
            // 
            // lbDaySo
            // 
            this.lbDaySo.FormattingEnabled = true;
            this.lbDaySo.ItemHeight = 20;
            this.lbDaySo.Location = new System.Drawing.Point(7, 40);
            this.lbDaySo.Name = "lbDaySo";
            this.lbDaySo.Size = new System.Drawing.Size(207, 204);
            this.lbDaySo.TabIndex = 0;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(534, 49);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(146, 63);
            this.btnTinh.TabIndex = 6;
            this.btnTinh.Text = "Tí&nh Tổng";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(534, 133);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(146, 63);
            this.btnMax.TabIndex = 7;
            this.btnMax.Text = "Tìm M&ax";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(534, 220);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(146, 63);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labTong
            // 
            this.labTong.AutoSize = true;
            this.labTong.ForeColor = System.Drawing.Color.Red;
            this.labTong.Location = new System.Drawing.Point(729, 63);
            this.labTong.Name = "labTong";
            this.labTong.Size = new System.Drawing.Size(0, 20);
            this.labTong.TabIndex = 9;
            // 
            // labMax
            // 
            this.labMax.AutoSize = true;
            this.labMax.ForeColor = System.Drawing.Color.Red;
            this.labMax.Location = new System.Drawing.Point(729, 154);
            this.labMax.Name = "labMax";
            this.labMax.Size = new System.Drawing.Size(0, 20);
            this.labMax.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.labMax);
            this.Controls.Add(this.labTong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbDaySo;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label labTong;
        private System.Windows.Forms.Label labMax;
    }
}

