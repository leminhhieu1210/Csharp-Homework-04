namespace Bai3
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnThemDS = new System.Windows.Forms.Button();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.combSoLuong = new System.Windows.Forms.ComboBox();
            this.combDoUong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radbNuaNgay = new System.Windows.Forms.RadioButton();
            this.radbCaNgay = new System.Windows.Forms.RadioButton();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDS = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemDS);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.combSoLuong);
            this.groupBox1.Controls.Add(this.combDoUong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radbNuaNgay);
            this.groupBox1.Controls.Add(this.radbCaNgay);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách đặt tour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "$";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(216, 284);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(91, 37);
            this.btnThemMoi.TabIndex = 13;
            this.btnThemMoi.Text = "Thêm &mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnThemDS
            // 
            this.btnThemDS.Location = new System.Drawing.Point(40, 284);
            this.btnThemDS.Name = "btnThemDS";
            this.btnThemDS.Size = new System.Drawing.Size(118, 37);
            this.btnThemDS.TabIndex = 12;
            this.btnThemDS.Text = "&Thêm vào DS";
            this.btnThemDS.UseVisualStyleBackColor = true;
            this.btnThemDS.Click += new System.EventHandler(this.btnThemDS_Click);
            // 
            // txtTien
            // 
            this.txtTien.Enabled = false;
            this.txtTien.Location = new System.Drawing.Point(260, 221);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(56, 26);
            this.txtTien.TabIndex = 11;
            // 
            // combSoLuong
            // 
            this.combSoLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSoLuong.FormattingEnabled = true;
            this.combSoLuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.combSoLuong.Location = new System.Drawing.Point(164, 219);
            this.combSoLuong.Name = "combSoLuong";
            this.combSoLuong.Size = new System.Drawing.Size(59, 28);
            this.combSoLuong.TabIndex = 10;
            this.combSoLuong.SelectedIndexChanged += new System.EventHandler(this.combSoLuong_SelectedIndexChanged);
            // 
            // combDoUong
            // 
            this.combDoUong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combDoUong.FormattingEnabled = true;
            this.combDoUong.Items.AddRange(new object[] {
            "Coca cola",
            "Pepsi",
            "Seven up"});
            this.combDoUong.Location = new System.Drawing.Point(6, 219);
            this.combDoUong.Name = "combDoUong";
            this.combDoUong.Size = new System.Drawing.Size(119, 28);
            this.combDoUong.TabIndex = 9;
            this.combDoUong.SelectedIndexChanged += new System.EventHandler(this.combDoUong_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chọn đồ uống";
            // 
            // txtGia
            // 
            this.txtGia.Enabled = false;
            this.txtGia.Location = new System.Drawing.Point(153, 147);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(123, 26);
            this.txtGia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá du thuyền";
            // 
            // radbNuaNgay
            // 
            this.radbNuaNgay.AutoSize = true;
            this.radbNuaNgay.Location = new System.Drawing.Point(194, 93);
            this.radbNuaNgay.Name = "radbNuaNgay";
            this.radbNuaNgay.Size = new System.Drawing.Size(101, 24);
            this.radbNuaNgay.TabIndex = 3;
            this.radbNuaNgay.Text = "Nửa ngày";
            this.radbNuaNgay.UseVisualStyleBackColor = true;
            this.radbNuaNgay.CheckedChanged += new System.EventHandler(this.radbNuaNgay_CheckedChanged);
            // 
            // radbCaNgay
            // 
            this.radbCaNgay.AutoSize = true;
            this.radbCaNgay.Location = new System.Drawing.Point(40, 93);
            this.radbCaNgay.Name = "radbCaNgay";
            this.radbCaNgay.Size = new System.Drawing.Size(92, 24);
            this.radbCaNgay.TabIndex = 2;
            this.radbCaNgay.Text = "Cả ngày";
            this.radbCaNgay.UseVisualStyleBackColor = true;
            this.radbCaNgay.CheckedChanged += new System.EventHandler(this.radbCaNgay_CheckedChanged);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(109, 43);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(123, 26);
            this.txtHoten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDS);
            this.groupBox2.Location = new System.Drawing.Point(387, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng đặt tour";
            // 
            // lbDS
            // 
            this.lbDS.FormattingEnabled = true;
            this.lbDS.ItemHeight = 20;
            this.lbDS.Location = new System.Drawing.Point(6, 32);
            this.lbDS.Name = "lbDS";
            this.lbDS.Size = new System.Drawing.Size(468, 164);
            this.lbDS.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(568, 297);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 49);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "T&hoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThemDS;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.ComboBox combSoLuong;
        private System.Windows.Forms.ComboBox combDoUong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radbNuaNgay;
        private System.Windows.Forms.RadioButton radbCaNgay;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbDS;
        private System.Windows.Forms.Button btnExit;
    }
}

