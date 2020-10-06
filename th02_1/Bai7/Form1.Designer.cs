namespace Bai7
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
            this.labNhap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labRes = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.combChon = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử của dãy: ";
            // 
            // labNhap
            // 
            this.labNhap.AutoSize = true;
            this.labNhap.Location = new System.Drawing.Point(28, 99);
            this.labNhap.Name = "labNhap";
            this.labNhap.Size = new System.Drawing.Size(151, 20);
            this.labNhap.TabIndex = 1;
            this.labNhap.Text = "Dãy số vừa nhập là: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn chức năng";
            // 
            // labRes
            // 
            this.labRes.AutoSize = true;
            this.labRes.Location = new System.Drawing.Point(28, 247);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(48, 20);
            this.labRes.TabIndex = 3;
            this.labRes.Text = "result";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(239, 29);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(100, 26);
            this.txtNhap.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(436, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 52);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Nhập dãy";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // combChon
            // 
            this.combChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combChon.FormattingEnabled = true;
            this.combChon.Items.AddRange(new object[] {
            "Trung bình cộng của dãy",
            "Đếm số phần tử âm"});
            this.combChon.Location = new System.Drawing.Point(171, 182);
            this.combChon.Name = "combChon";
            this.combChon.Size = new System.Drawing.Size(211, 28);
            this.combChon.TabIndex = 6;
            this.combChon.SelectedIndexChanged += new System.EventHandler(this.combChon_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(388, 247);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(79, 52);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Làm lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(548, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 52);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 360);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.combChon);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.labRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labNhap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labRes;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox combChon;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

