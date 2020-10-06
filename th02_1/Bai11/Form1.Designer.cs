namespace Bai11
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
            this.cobSize = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.cobFont = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chebULine = new System.Windows.Forms.CheckBox();
            this.chebItalic = new System.Windows.Forms.CheckBox();
            this.chebBold = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cobSize);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.cobFont);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(74, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu chữ";
            // 
            // cobSize
            // 
            this.cobSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobSize.FormattingEnabled = true;
            this.cobSize.Items.AddRange(new object[] {
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cobSize.Location = new System.Drawing.Point(527, 46);
            this.cobSize.Name = "cobSize";
            this.cobSize.Size = new System.Drawing.Size(61, 28);
            this.cobSize.TabIndex = 3;
            this.cobSize.SelectedIndexChanged += new System.EventHandler(this.cobSize_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(428, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(83, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Kích thước";
            // 
            // cobFont
            // 
            this.cobFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobFont.FormattingEnabled = true;
            this.cobFont.Items.AddRange(new object[] {
            "Arial",
            "Times New Roman",
            ".vnTime",
            ".vnTimeH",
            ".vnArial",
            ".vnArialH"});
            this.cobFont.Location = new System.Drawing.Point(106, 46);
            this.cobFont.Name = "cobFont";
            this.cobFont.Size = new System.Drawing.Size(164, 28);
            this.cobFont.TabIndex = 1;
            this.cobFont.SelectedIndexChanged += new System.EventHandler(this.cobFont_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Font";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chebULine);
            this.groupBox2.Controls.Add(this.chebItalic);
            this.groupBox2.Controls.Add(this.chebBold);
            this.groupBox2.Location = new System.Drawing.Point(74, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 113);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiệu ứng chữ";
            // 
            // chebULine
            // 
            this.chebULine.AutoSize = true;
            this.chebULine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chebULine.Location = new System.Drawing.Point(505, 51);
            this.chebULine.Name = "chebULine";
            this.chebULine.Size = new System.Drawing.Size(113, 24);
            this.chebULine.TabIndex = 2;
            this.chebULine.Text = "Gạch chân";
            this.chebULine.UseVisualStyleBackColor = true;
            this.chebULine.CheckedChanged += new System.EventHandler(this.chebULine_CheckedChanged);
            // 
            // chebItalic
            // 
            this.chebItalic.AutoSize = true;
            this.chebItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chebItalic.Location = new System.Drawing.Point(265, 51);
            this.chebItalic.Name = "chebItalic";
            this.chebItalic.Size = new System.Drawing.Size(94, 24);
            this.chebItalic.TabIndex = 1;
            this.chebItalic.Text = "Nghiêng";
            this.chebItalic.UseVisualStyleBackColor = true;
            this.chebItalic.CheckedChanged += new System.EventHandler(this.chebItalic_CheckedChanged);
            // 
            // chebBold
            // 
            this.chebBold.AutoSize = true;
            this.chebBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chebBold.Location = new System.Drawing.Point(41, 51);
            this.chebBold.Name = "chebBold";
            this.chebBold.Size = new System.Drawing.Size(72, 24);
            this.chebBold.TabIndex = 0;
            this.chebBold.Text = "Đậm";
            this.chebBold.UseVisualStyleBackColor = true;
            this.chebBold.CheckedChanged += new System.EventHandler(this.chebBold_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radBlack);
            this.groupBox3.Controls.Add(this.radGreen);
            this.groupBox3.Controls.Add(this.radRed);
            this.groupBox3.Location = new System.Drawing.Point(74, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(656, 113);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Màu chữ";
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Location = new System.Drawing.Point(524, 54);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(64, 24);
            this.radBlack.TabIndex = 2;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Đen";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.ForeColor = System.Drawing.Color.LimeGreen;
            this.radGreen.Location = new System.Drawing.Point(265, 54);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(116, 24);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Xanh lá cây";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(75, 54);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(55, 24);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Đỏ";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(226, 542);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 38);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Làm lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(423, 542);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtHeading);
            this.panel1.Location = new System.Drawing.Point(87, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 96);
            this.panel1.TabIndex = 6;
            // 
            // txtHeading
            // 
            this.txtHeading.BackColor = System.Drawing.Color.White;
            this.txtHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeading.Location = new System.Drawing.Point(3, 29);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(626, 37);
            this.txtHeading.TabIndex = 0;
            this.txtHeading.Text = "TIN HỌC ĐẠI CƯƠNG";
            this.txtHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.ComboBox cobSize;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cobFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chebULine;
        private System.Windows.Forms.CheckBox chebItalic;
        private System.Windows.Forms.CheckBox chebBold;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
    }
}

