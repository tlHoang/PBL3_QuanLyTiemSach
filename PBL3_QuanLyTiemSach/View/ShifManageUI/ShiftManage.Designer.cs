namespace PBL3_QuanLyTiemSach.View
{
    partial class ShiftManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftManage));
            this.btnSMLichLam = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSMDangKiCa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnXoaCa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSMThoat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSMQuayLai = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtSMChonNgay = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnSMXem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtbxTenNhanVien = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnChinhSua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.metroLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cbbTimeShowCa = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.dgvShift = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTimeShowCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSMLichLam
            // 
            this.btnSMLichLam.BackColor = System.Drawing.Color.Black;
            this.btnSMLichLam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSMLichLam.BackgroundImage")));
            this.btnSMLichLam.Location = new System.Drawing.Point(842, 72);
            this.btnSMLichLam.Margin = new System.Windows.Forms.Padding(2);
            this.btnSMLichLam.Name = "btnSMLichLam";
            this.btnSMLichLam.Size = new System.Drawing.Size(119, 32);
            this.btnSMLichLam.TabIndex = 1;
            this.btnSMLichLam.Values.Text = "Lịch Làm";
            this.btnSMLichLam.Click += new System.EventHandler(this.btnSMLichLam_Click);
            // 
            // btnSMDangKiCa
            // 
            this.btnSMDangKiCa.BackColor = System.Drawing.Color.Black;
            this.btnSMDangKiCa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSMDangKiCa.BackgroundImage")));
            this.btnSMDangKiCa.Location = new System.Drawing.Point(842, 124);
            this.btnSMDangKiCa.Margin = new System.Windows.Forms.Padding(2);
            this.btnSMDangKiCa.Name = "btnSMDangKiCa";
            this.btnSMDangKiCa.Size = new System.Drawing.Size(119, 32);
            this.btnSMDangKiCa.TabIndex = 1;
            this.btnSMDangKiCa.Values.Text = "Đăng Kí Ca";
            this.btnSMDangKiCa.Click += new System.EventHandler(this.btnSMDangKiCa_Click);
            // 
            // btnXoaCa
            // 
            this.btnXoaCa.BackColor = System.Drawing.Color.Black;
            this.btnXoaCa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaCa.BackgroundImage")));
            this.btnXoaCa.Location = new System.Drawing.Point(842, 170);
            this.btnXoaCa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaCa.Name = "btnXoaCa";
            this.btnXoaCa.Size = new System.Drawing.Size(119, 32);
            this.btnXoaCa.TabIndex = 1;
            this.btnXoaCa.Values.Text = "Xoá Ca";
            this.btnXoaCa.Click += new System.EventHandler(this.btnXoaCa_Click);
            // 
            // btnSMThoat
            // 
            this.btnSMThoat.BackColor = System.Drawing.Color.Black;
            this.btnSMThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSMThoat.BackgroundImage")));
            this.btnSMThoat.Location = new System.Drawing.Point(842, 467);
            this.btnSMThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnSMThoat.Name = "btnSMThoat";
            this.btnSMThoat.Size = new System.Drawing.Size(119, 32);
            this.btnSMThoat.TabIndex = 2;
            this.btnSMThoat.Values.Text = "Thoát";
            this.btnSMThoat.Click += new System.EventHandler(this.btnSMThoat_Click);
            // 
            // btnSMQuayLai
            // 
            this.btnSMQuayLai.BackColor = System.Drawing.Color.Black;
            this.btnSMQuayLai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSMQuayLai.BackgroundImage")));
            this.btnSMQuayLai.Location = new System.Drawing.Point(842, 419);
            this.btnSMQuayLai.Name = "btnSMQuayLai";
            this.btnSMQuayLai.Size = new System.Drawing.Size(119, 32);
            this.btnSMQuayLai.TabIndex = 3;
            this.btnSMQuayLai.Values.Text = "Quay Lại";
            this.btnSMQuayLai.Click += new System.EventHandler(this.btnSMQuayLai_Click);
            // 
            // dtSMChonNgay
            // 
            this.dtSMChonNgay.Location = new System.Drawing.Point(133, 34);
            this.dtSMChonNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtSMChonNgay.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtSMChonNgay.Name = "dtSMChonNgay";
            this.dtSMChonNgay.Size = new System.Drawing.Size(171, 29);
            this.dtSMChonNgay.TabIndex = 4;
            // 
            // btnSMXem
            // 
            this.btnSMXem.Location = new System.Drawing.Point(15, 34);
            this.btnSMXem.Margin = new System.Windows.Forms.Padding(2);
            this.btnSMXem.Name = "btnSMXem";
            this.btnSMXem.Size = new System.Drawing.Size(96, 25);
            this.btnSMXem.TabIndex = 5;
            this.btnSMXem.Values.Text = "Xem";
            this.btnSMXem.Click += new System.EventHandler(this.btnSMXem_Click);
            // 
            // txtbxTenNhanVien
            // 
            this.txtbxTenNhanVien.Location = new System.Drawing.Point(500, 39);
            this.txtbxTenNhanVien.Name = "txtbxTenNhanVien";
            this.txtbxTenNhanVien.ReadOnly = true;
            this.txtbxTenNhanVien.Size = new System.Drawing.Size(216, 23);
            this.txtbxTenNhanVien.TabIndex = 6;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.Black;
            this.btnChinhSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChinhSua.BackgroundImage")));
            this.btnChinhSua.Location = new System.Drawing.Point(842, 218);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(119, 32);
            this.btnChinhSua.TabIndex = 1;
            this.btnChinhSua.Values.Text = "Chỉnh Sửa";
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(389, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 20);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Values.Text = "Tên Nhân Viên";
            // 
            // cbbTimeShowCa
            // 
            this.cbbTimeShowCa.DropDownWidth = 171;
            this.cbbTimeShowCa.FormattingEnabled = true;
            this.cbbTimeShowCa.Location = new System.Drawing.Point(133, 0);
            this.cbbTimeShowCa.Name = "cbbTimeShowCa";
            this.cbbTimeShowCa.Size = new System.Drawing.Size(171, 21);
            this.cbbTimeShowCa.TabIndex = 9;
            // 
            // dgvShift
            // 
            this.dgvShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShift.Location = new System.Drawing.Point(15, 72);
            this.dgvShift.Name = "dgvShift";
            this.dgvShift.ReadOnly = true;
            this.dgvShift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShift.Size = new System.Drawing.Size(792, 427);
            this.dgvShift.TabIndex = 10;
            this.dgvShift.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShift_CellMouseDoubleClick);
            // 
            // ShiftManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 551);
            this.Controls.Add(this.dgvShift);
            this.Controls.Add(this.cbbTimeShowCa);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtbxTenNhanVien);
            this.Controls.Add(this.btnSMXem);
            this.Controls.Add(this.dtSMChonNgay);
            this.Controls.Add(this.btnSMQuayLai);
            this.Controls.Add(this.btnSMThoat);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnXoaCa);
            this.Controls.Add(this.btnSMDangKiCa);
            this.Controls.Add(this.btnSMLichLam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShiftManage";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Text = "Ca Làm";
            ((System.ComponentModel.ISupportInitialize)(this.cbbTimeShowCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSMLichLam;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSMDangKiCa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXoaCa;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSMThoat;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSMQuayLai;
        private  ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtSMChonNgay;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSMXem;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtbxTenNhanVien;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnChinhSua;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel metroLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbTimeShowCa;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvShift;
    }
}