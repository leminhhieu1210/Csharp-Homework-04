namespace Bai13
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
            this.labOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labMin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử:";
            // 
            // labOutput
            // 
            this.labOutput.AutoSize = true;
            this.labOutput.Location = new System.Drawing.Point(32, 99);
            this.labOutput.Name = "labOutput";
            this.labOutput.Size = new System.Drawing.Size(151, 20);
            this.labOutput.TabIndex = 1;
            this.labOutput.Text = "Dãy số vừa nhập là: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập một số k = ";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(168, 31);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 26);
            this.txtInput.TabIndex = 3;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(168, 302);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 26);
            this.txtK.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(392, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Nhập dãy";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(36, 149);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(199, 46);
            this.btnMin.TabIndex = 6;
            this.btnMin.Text = "Tìm số dương nhỏ nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(392, 302);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(96, 35);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "&Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(270, 383);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 35);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Làm lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(429, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "T&hoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Location = new System.Drawing.Point(32, 224);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(169, 20);
            this.labMin.TabIndex = 10;
            this.labMin.Text = "Số dương nhỏ nhất là: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.labMin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labOutput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labMin;
    }
}

