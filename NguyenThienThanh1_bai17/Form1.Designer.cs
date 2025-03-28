namespace NguyenThienThanh1_bai17
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
            this.btThoat = new System.Windows.Forms.Button();
            this.ckDam = new System.Windows.Forms.CheckBox();
            this.ckNghien = new System.Windows.Forms.CheckBox();
            this.ckChan = new System.Windows.Forms.CheckBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.raBlack = new System.Windows.Forms.RadioButton();
            this.raBlue = new System.Windows.Forms.RadioButton();
            this.raGreen = new System.Windows.Forms.RadioButton();
            this.raRed = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLapTrinh = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(261, 238);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // ckDam
            // 
            this.ckDam.AutoSize = true;
            this.ckDam.Location = new System.Drawing.Point(6, 19);
            this.ckDam.Name = "ckDam";
            this.ckDam.Size = new System.Drawing.Size(48, 17);
            this.ckDam.TabIndex = 1;
            this.ckDam.Text = "Đậm";
            this.ckDam.UseVisualStyleBackColor = true;
            this.ckDam.CheckedChanged += new System.EventHandler(this.ckDam_CheckedChanged);
            // 
            // ckNghien
            // 
            this.ckNghien.AutoSize = true;
            this.ckNghien.Location = new System.Drawing.Point(6, 42);
            this.ckNghien.Name = "ckNghien";
            this.ckNghien.Size = new System.Drawing.Size(60, 17);
            this.ckNghien.TabIndex = 2;
            this.ckNghien.Text = "Nghiên";
            this.ckNghien.UseVisualStyleBackColor = true;
            this.ckNghien.CheckedChanged += new System.EventHandler(this.ckNghien_CheckedChanged);
            // 
            // ckChan
            // 
            this.ckChan.AutoSize = true;
            this.ckChan.Location = new System.Drawing.Point(6, 65);
            this.ckChan.Name = "ckChan";
            this.ckChan.Size = new System.Drawing.Size(80, 17);
            this.ckChan.TabIndex = 3;
            this.ckChan.Text = "Gạch Chân";
            this.ckChan.UseVisualStyleBackColor = true;
            this.ckChan.CheckedChanged += new System.EventHandler(this.ckChan_CheckedChanged);
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.LemonChiffon;
            this.gb1.Controls.Add(this.ckDam);
            this.gb1.Controls.Add(this.ckChan);
            this.gb1.Controls.Add(this.ckNghien);
            this.gb1.Location = new System.Drawing.Point(250, 75);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(110, 127);
            this.gb1.TabIndex = 4;
            this.gb1.TabStop = false;
            this.gb1.Text = "form";

            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox2.Controls.Add(this.raBlack);
            this.groupBox2.Controls.Add(this.raBlue);
            this.groupBox2.Controls.Add(this.raGreen);
            this.groupBox2.Controls.Add(this.raRed);
            this.groupBox2.Location = new System.Drawing.Point(90, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 127);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "color";
            // 
            // raBlack
            // 
            this.raBlack.AutoSize = true;
            this.raBlack.Location = new System.Drawing.Point(7, 89);
            this.raBlack.Name = "raBlack";
            this.raBlack.Size = new System.Drawing.Size(52, 17);
            this.raBlack.TabIndex = 3;
            this.raBlack.TabStop = true;
            this.raBlack.Text = "Black";
            this.raBlack.UseVisualStyleBackColor = true;
            this.raBlack.CheckedChanged += new System.EventHandler(this.raBlack_CheckedChanged);
            // 
            // raBlue
            // 
            this.raBlue.AutoSize = true;
            this.raBlue.Location = new System.Drawing.Point(7, 66);
            this.raBlue.Name = "raBlue";
            this.raBlue.Size = new System.Drawing.Size(46, 17);
            this.raBlue.TabIndex = 2;
            this.raBlue.TabStop = true;
            this.raBlue.Text = "Blue";
            this.raBlue.UseVisualStyleBackColor = true;
            this.raBlue.CheckedChanged += new System.EventHandler(this.raBlue_CheckedChanged);
            // 
            // raGreen
            // 
            this.raGreen.AutoSize = true;
            this.raGreen.Location = new System.Drawing.Point(7, 43);
            this.raGreen.Name = "raGreen";
            this.raGreen.Size = new System.Drawing.Size(54, 17);
            this.raGreen.TabIndex = 1;
            this.raGreen.TabStop = true;
            this.raGreen.Text = "Green";
            this.raGreen.UseVisualStyleBackColor = true;
            this.raGreen.CheckedChanged += new System.EventHandler(this.raGreen_CheckedChanged);
            // 
            // raRed
            // 
            this.raRed.AutoSize = true;
            this.raRed.Location = new System.Drawing.Point(7, 20);
            this.raRed.Name = "raRed";
            this.raRed.Size = new System.Drawing.Size(45, 17);
            this.raRed.TabIndex = 0;
            this.raRed.TabStop = true;
            this.raRed.Text = "Red";
            this.raRed.UseVisualStyleBackColor = true;
            this.raRed.CheckedChanged += new System.EventHandler(this.raRed_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập tên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(147, 34);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 7;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lập Trình Bởi:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.AutoSize = true;
            this.lblLapTrinh.Location = new System.Drawing.Point(176, 243);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(0, 13);
            this.lblLapTrinh.TabIndex = 6;
            this.lblLapTrinh.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 327);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblLapTrinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.btThoat);
            this.Name = "Form1";
            this.Text = "Form1";

            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.CheckBox ckDam;
        private System.Windows.Forms.CheckBox ckNghien;
        private System.Windows.Forms.CheckBox ckChan;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton raBlack;
        private System.Windows.Forms.RadioButton raBlue;
        private System.Windows.Forms.RadioButton raGreen;
        private System.Windows.Forms.RadioButton raRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLapTrinh;
    }
}

