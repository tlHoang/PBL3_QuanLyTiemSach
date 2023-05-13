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
            this.cbbgbd = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbbgkt = new System.Windows.Forms.ComboBox();
            this.btnThoat = new MetroFramework.Controls.MetroButton();
            this.btnLuu = new MetroFramework.Controls.MetroButton();
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
            // cbbgbd
            // 
            this.cbbgbd.FormattingEnabled = true;
            this.cbbgbd.Location = new System.Drawing.Point(205, 170);
            this.cbbgbd.Margin = new System.Windows.Forms.Padding(2);
            this.cbbgbd.Name = "cbbgbd";
            this.cbbgbd.Size = new System.Drawing.Size(145, 21);
            this.cbbgbd.TabIndex = 4;
            this.cbbgbd.SelectedIndexChanged += new System.EventHandler(this.cbbgbd_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Cyan;
            this.metroLabel1.Location = new System.Drawing.Point(74, 170);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Giờ Bắt Đầu";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Cyan;
            this.metroLabel2.Location = new System.Drawing.Point(74, 227);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Giờ Kết Thúc";
            // 
            // cbbgkt
            // 
            this.cbbgkt.FormattingEnabled = true;
            this.cbbgkt.Location = new System.Drawing.Point(205, 227);
            this.cbbgkt.Margin = new System.Windows.Forms.Padding(2);
            this.cbbgkt.Name = "cbbgkt";
            this.cbbgkt.Size = new System.Drawing.Size(145, 21);
            this.cbbgkt.TabIndex = 4;
            this.cbbgkt.SelectedIndexChanged += new System.EventHandler(this.cbbgkt_SelectedIndexChanged);
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
            // UpdateSMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 348);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cbbgkt);
            this.Controls.Add(this.cbbgbd);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.dtChonNgayLam);
            this.Name = "UpdateSMForm";
            this.Text = "Chỉnh Sửa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtChonNgayLam;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.ComboBox cbbgbd;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox cbbgkt;
        private MetroFramework.Controls.MetroButton btnThoat;
        private MetroFramework.Controls.MetroButton btnLuu;
    }
}