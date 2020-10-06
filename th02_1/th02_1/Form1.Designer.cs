namespace th02_1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemDS = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbPhatLoc = new System.Windows.Forms.RadioButton();
            this.rdbThuong = new System.Windows.Forms.RadioButton();
            this.cbxThoiGianGui = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgayGui = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoTienGui = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDSKH = new System.Windows.Forms.ListBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemDS);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cbxThoiGianGui);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNgayGui);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoTienGui);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 480);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "(tháng)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "(VNĐ)";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(227, 412);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(98, 50);
            this.btnThemMoi.TabIndex = 5;
            this.btnThemMoi.Text = "Thêm &mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThemDS
            // 
            this.btnThemDS.Location = new System.Drawing.Point(36, 412);
            this.btnThemDS.Name = "btnThemDS";
            this.btnThemDS.Size = new System.Drawing.Size(98, 50);
            this.btnThemDS.TabIndex = 4;
            this.btnThemDS.Text = "&Thêm vào danh sách";
            this.btnThemDS.UseVisualStyleBackColor = true;
            this.btnThemDS.Click += new System.EventHandler(this.btnThemDS_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbPhatLoc);
            this.groupBox3.Controls.Add(this.rdbThuong);
            this.groupBox3.Location = new System.Drawing.Point(20, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại tiết kiệm";
            // 
            // rdbPhatLoc
            // 
            this.rdbPhatLoc.AutoSize = true;
            this.rdbPhatLoc.Location = new System.Drawing.Point(179, 50);
            this.rdbPhatLoc.Name = "rdbPhatLoc";
            this.rdbPhatLoc.Size = new System.Drawing.Size(91, 24);
            this.rdbPhatLoc.TabIndex = 1;
            this.rdbPhatLoc.Text = "Phát lộc";
            this.rdbPhatLoc.UseVisualStyleBackColor = true;
            // 
            // rdbThuong
            // 
            this.rdbThuong.AutoSize = true;
            this.rdbThuong.Checked = true;
            this.rdbThuong.Location = new System.Drawing.Point(16, 50);
            this.rdbThuong.Name = "rdbThuong";
            this.rdbThuong.Size = new System.Drawing.Size(88, 24);
            this.rdbThuong.TabIndex = 0;
            this.rdbThuong.TabStop = true;
            this.rdbThuong.Text = "Thường";
            this.rdbThuong.UseVisualStyleBackColor = true;
            // 
            // cbxThoiGianGui
            // 
            this.cbxThoiGianGui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxThoiGianGui.FormattingEnabled = true;
            this.cbxThoiGianGui.Location = new System.Drawing.Point(127, 243);
            this.cbxThoiGianGui.Name = "cbxThoiGianGui";
            this.cbxThoiGianGui.Size = new System.Drawing.Size(141, 28);
            this.cbxThoiGianGui.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thời gian gửi";
            // 
            // txtNgayGui
            // 
            this.txtNgayGui.Location = new System.Drawing.Point(127, 210);
            this.txtNgayGui.Name = "txtNgayGui";
            this.txtNgayGui.Size = new System.Drawing.Size(141, 26);
            this.txtNgayGui.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày gửi";
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.Location = new System.Drawing.Point(127, 169);
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(141, 26);
            this.txtSoTienGui.TabIndex = 7;
            this.txtSoTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienGui_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số tiền gửi";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(127, 124);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(141, 26);
            this.txtDiaChi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(127, 81);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(141, 26);
            this.txtHoTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(127, 40);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(141, 26);
            this.txtMaKH.TabIndex = 1;
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDSKH);
            this.groupBox2.Location = new System.Drawing.Point(430, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 356);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // lbDSKH
            // 
            this.lbDSKH.FormattingEnabled = true;
            this.lbDSKH.ItemHeight = 20;
            this.lbDSKH.Location = new System.Drawing.Point(6, 29);
            this.lbDSKH.Name = "lbDSKH";
            this.lbDSKH.Size = new System.Drawing.Size(687, 304);
            this.lbDSKH.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(656, 434);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(98, 50);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm &kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(834, 434);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 50);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 514);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemDS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbPhatLoc;
        private System.Windows.Forms.RadioButton rdbThuong;
        private System.Windows.Forms.ComboBox cbxThoiGianGui;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgayGui;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoTienGui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbDSKH;
    }
}

