namespace PBL3_QuanLyTiemSach.View.ShifManageUI
{
    partial class FormSMDangKiCa
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
            this.dtChonNgayLam = new System.Windows.Forms.DateTimePicker();
            this.cbbGioBatDau = new System.Windows.Forms.ComboBox();
            this.cbbGioKetThuc = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnThoat = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnDangKi = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // dtChonNgayLam
            // 
            this.dtChonNgayLam.Location = new System.Drawing.Point(209, 129);
            this.dtChonNgayLam.Name = "dtChonNgayLam";
            this.dtChonNgayLam.Size = new System.Drawing.Size(295, 26);
            this.dtChonNgayLam.TabIndex = 0;
            // 
            // cbbGioBatDau
            // 
            this.cbbGioBatDau.FormattingEnabled = true;
            this.cbbGioBatDau.Location = new System.Drawing.Point(209, 199);
            this.cbbGioBatDau.Name = "cbbGioBatDau";
            this.cbbGioBatDau.Size = new System.Drawing.Size(295, 28);
            this.cbbGioBatDau.TabIndex = 1;
            this.cbbGioBatDau.SelectedIndexChanged += new System.EventHandler(this.cbbGioBatDau_SelectedIndexChanged);
            // 
            // cbbGioKetThuc
            // 
            this.cbbGioKetThuc.FormattingEnabled = true;
            this.cbbGioKetThuc.Location = new System.Drawing.Point(209, 255);
            this.cbbGioKetThuc.Name = "cbbGioKetThuc";
            this.cbbGioKetThuc.Size = new System.Drawing.Size(295, 28);
            this.cbbGioKetThuc.TabIndex = 1;
            this.cbbGioKetThuc.SelectedIndexChanged += new System.EventHandler(this.cbbGioKetThuc_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(58, 136);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Ngày Làm";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(58, 208);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Giờ Bắt Đầu";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(55, 264);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Giờ Kết Thúc";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(343, 314);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(161, 33);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseSelectable = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(84, 386);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "* Ca 1: 6h -14h";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(341, 386);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(103, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "* Ca 2: 14h -22h";
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(58, 314);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(161, 33);
            this.btnDangKi.TabIndex = 5;
            this.btnDangKi.Text = "Đăng Kí";
            this.btnDangKi.UseSelectable = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // FormSMDangKiCa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 460);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbbGioKetThuc);
            this.Controls.Add(this.cbbGioBatDau);
            this.Controls.Add(this.dtChonNgayLam);
            this.Name = "FormSMDangKiCa";
            this.Text = "Đăng Kí Ca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtChonNgayLam;
        private System.Windows.Forms.ComboBox cbbGioBatDau;
        private System.Windows.Forms.ComboBox cbbGioKetThuc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnThoat;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnDangKi;
    }
}