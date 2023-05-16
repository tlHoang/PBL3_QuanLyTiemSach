namespace PBL3_QuanLyTiemSach.View.ShifManageUI
{
    partial class UpdateSMForm
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
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cbbCaLam = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnThoat = new MetroFramework.Controls.MetroButton();
            this.btnLuu = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // dtChonNgayLam
            // 
            this.dtChonNgayLam.Location = new System.Drawing.Point(205, 112);
            this.dtChonNgayLam.Margin = new System.Windows.Forms.Padding(2);
            this.dtChonNgayLam.Name = "dtChonNgayLam";
            this.dtChonNgayLam.Size = new System.Drawing.Size(145, 20);
            this.dtChonNgayLam.TabIndex = 1;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Cyan;
            this.metroLabel9.Location = new System.Drawing.Point(74, 112);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(69, 19);
            this.metroLabel9.TabIndex = 3;
            this.metroLabel9.Text = "Ngày Làm";
            // 
            // cbbCaLam
            // 
            this.cbbCaLam.FormattingEnabled = true;
            this.cbbCaLam.Location = new System.Drawing.Point(205, 170);
            this.cbbCaLam.Margin = new System.Windows.Forms.Padding(2);
            this.cbbCaLam.Name = "cbbCaLam";
            this.cbbCaLam.Size = new System.Drawing.Size(145, 21);
            this.cbbCaLam.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Cyan;
            this.metroLabel1.Location = new System.Drawing.Point(74, 170);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Ca Làm";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(224, 290);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 21);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseSelectable = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(74, 290);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 21);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseSelectable = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(218, 210);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(103, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "* Ca 2: 14h -22h";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(74, 243);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(152, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "* 1 Ca chỉ có 2 nhân viên";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(74, 210);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "* Ca 1: 6h -14h";
            // 
            // UpdateSMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 348);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cbbCaLam);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.dtChonNgayLam);
            this.Name = "UpdateSMForm";
            this.Text = "Chỉnh Sửa";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtChonNgayLam;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.ComboBox cbbCaLam;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnThoat;
        private MetroFramework.Controls.MetroButton btnLuu;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}