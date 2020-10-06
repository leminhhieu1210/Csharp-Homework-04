namespace Bai8
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
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.btnEven = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbDS = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập một số: ";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(141, 27);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(106, 26);
            this.txtAdd.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(72, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 53);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd3
            // 
            this.btnAdd3.Location = new System.Drawing.Point(72, 174);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(175, 53);
            this.btnAdd3.TabIndex = 3;
            this.btnAdd3.Text = "Tăng mỗi số lên 3";
            this.btnAdd3.UseVisualStyleBackColor = true;
            this.btnAdd3.Click += new System.EventHandler(this.btnAdd3_Click);
            // 
            // btnEven
            // 
            this.btnEven.Location = new System.Drawing.Point(72, 262);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(175, 53);
            this.btnEven.TabIndex = 4;
            this.btnEven.Text = "Chọn số chẵn đầu";
            this.btnEven.UseVisualStyleBackColor = true;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lbDS);
            this.groupBox1.Location = new System.Drawing.Point(399, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 303);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dãy số";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(41, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 46);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "&Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbDS
            // 
            this.lbDS.FormattingEnabled = true;
            this.lbDS.ItemHeight = 20;
            this.lbDS.Location = new System.Drawing.Point(18, 34);
            this.lbDS.Name = "lbDS";
            this.lbDS.Size = new System.Drawing.Size(165, 184);
            this.lbDS.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(501, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 42);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "T&hoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEven);
            this.Controls.Add(this.btnAdd3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbDS;
        private System.Windows.Forms.Button btnExit;
    }
}

