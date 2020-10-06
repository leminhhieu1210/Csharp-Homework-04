namespace Bai4
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
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combTen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDS = new System.Windows.Forms.ListBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTinChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.txtSoTinChi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm của sinh viên";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(95, 235);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 47);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm vào &DS";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(121, 164);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(100, 26);
            this.txtDiem.TabIndex = 5;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Enabled = false;
            this.txtSoTinChi.Location = new System.Drawing.Point(121, 122);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(100, 26);
            this.txtSoTinChi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số tín chỉ";
            // 
            // combTen
            // 
            this.combTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combTen.FormattingEnabled = true;
            this.combTen.Items.AddRange(new object[] {
            "Tin học đại cương",
            "Giải tích F1",
            "Tiếng Anh A0",
            "Triết học Mác - Lênin",
            "Vật lý F1"});
            this.combTen.Location = new System.Drawing.Point(38, 74);
            this.combTen.Name = "combTen";
            this.combTen.Size = new System.Drawing.Size(252, 28);
            this.combTen.TabIndex = 1;
            this.combTen.SelectedIndexChanged += new System.EventHandler(this.combTen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn học";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(482, 385);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(148, 41);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "&Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDS);
            this.groupBox2.Location = new System.Drawing.Point(387, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các môn học";
            // 
            // lbDS
            // 
            this.lbDS.FormattingEnabled = true;
            this.lbDS.ItemHeight = 20;
            this.lbDS.Location = new System.Drawing.Point(7, 26);
            this.lbDS.Name = "lbDS";
            this.lbDS.Size = new System.Drawing.Size(515, 184);
            this.lbDS.TabIndex = 0;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(557, 341);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(132, 26);
            this.txtDiemTB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điểm trung bình";
            // 
            // txtTongTinChi
            // 
            this.txtTongTinChi.Location = new System.Drawing.Point(512, 291);
            this.txtTongTinChi.Name = "txtTongTinChi";
            this.txtTongTinChi.Size = new System.Drawing.Size(100, 26);
            this.txtTongTinChi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tổng số tín chỉ";
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Location = new System.Drawing.Point(794, 294);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.Size = new System.Drawing.Size(100, 26);
            this.txtTongDiem.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tổng số điểm";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(711, 385);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 41);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtDiemTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTongTinChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbDS;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTinChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
    }
}

