namespace PBL3_QuanLyTiemSach.View
{
    partial class Import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.txtGiaNhap = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSoLuong = new MetroFramework.Controls.MetroTextBox();
            this.txtTenSach = new MetroFramework.Controls.MetroTextBox();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbbDVCC = new System.Windows.Forms.ComboBox();
            this.labelTongTien = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.btnDel = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtTacGia = new MetroFramework.Controls.MetroTextBox();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.dgvHoaDonNhap = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(3, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 31);
            this.panel1.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(187, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(23, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Lines = new string[] {
        "Tìm kiếm"};
            this.txtSearch.Location = new System.Drawing.Point(0, 5);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(187, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Tìm kiếm";
            this.txtSearch.UseCustomForeColor = true;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // txtGiaNhap
            // 
            // 
            // 
            // 
            this.txtGiaNhap.CustomButton.Image = null;
            this.txtGiaNhap.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtGiaNhap.CustomButton.Name = "";
            this.txtGiaNhap.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGiaNhap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGiaNhap.CustomButton.TabIndex = 1;
            this.txtGiaNhap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGiaNhap.CustomButton.UseSelectable = true;
            this.txtGiaNhap.CustomButton.Visible = false;
            this.txtGiaNhap.Lines = new string[0];
            this.txtGiaNhap.Location = new System.Drawing.Point(3, 349);
            this.txtGiaNhap.MaxLength = 32767;
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.PasswordChar = '\0';
            this.txtGiaNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGiaNhap.SelectedText = "";
            this.txtGiaNhap.SelectionLength = 0;
            this.txtGiaNhap.SelectionStart = 0;
            this.txtGiaNhap.ShortcutsEnabled = true;
            this.txtGiaNhap.Size = new System.Drawing.Size(211, 23);
            this.txtGiaNhap.TabIndex = 6;
            this.txtGiaNhap.UseSelectable = true;
            this.txtGiaNhap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGiaNhap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 329);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Giá nhập";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 281);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Số lượng";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 101);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Tên Sách";
            // 
            // txtSoLuong
            // 
            // 
            // 
            // 
            this.txtSoLuong.CustomButton.Image = null;
            this.txtSoLuong.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtSoLuong.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.CustomButton.Name = "";
            this.txtSoLuong.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSoLuong.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoLuong.CustomButton.TabIndex = 1;
            this.txtSoLuong.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoLuong.CustomButton.UseSelectable = true;
            this.txtSoLuong.CustomButton.Visible = false;
            this.txtSoLuong.Lines = new string[0];
            this.txtSoLuong.Location = new System.Drawing.Point(3, 301);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.MaxLength = 32767;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.SelectionLength = 0;
            this.txtSoLuong.SelectionStart = 0;
            this.txtSoLuong.ShortcutsEnabled = true;
            this.txtSoLuong.Size = new System.Drawing.Size(211, 23);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.UseSelectable = true;
            this.txtSoLuong.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSoLuong.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTenSach
            // 
            // 
            // 
            // 
            this.txtTenSach.CustomButton.Image = null;
            this.txtTenSach.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtTenSach.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSach.CustomButton.Name = "";
            this.txtTenSach.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTenSach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenSach.CustomButton.TabIndex = 1;
            this.txtTenSach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenSach.CustomButton.UseSelectable = true;
            this.txtTenSach.CustomButton.Visible = false;
            this.txtTenSach.Lines = new string[0];
            this.txtTenSach.Location = new System.Drawing.Point(3, 157);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSach.MaxLength = 32767;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.PasswordChar = '\0';
            this.txtTenSach.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenSach.SelectedText = "";
            this.txtTenSach.SelectionLength = 0;
            this.txtTenSach.SelectionStart = 0;
            this.txtTenSach.ShortcutsEnabled = true;
            this.txtTenSach.Size = new System.Drawing.Size(211, 23);
            this.txtTenSach.TabIndex = 2;
            this.txtTenSach.UseSelectable = true;
            this.txtTenSach.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenSach.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(53, 394);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm vào đơn";
            this.btnThem.UseSelectable = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(241, 58);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "Đơn vị cung cấp";
            // 
            // cbbDVCC
            // 
            this.cbbDVCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDVCC.FormattingEnabled = true;
            this.cbbDVCC.Location = new System.Drawing.Point(241, 80);
            this.cbbDVCC.Name = "cbbDVCC";
            this.cbbDVCC.Size = new System.Drawing.Size(210, 23);
            this.cbbDVCC.TabIndex = 0;
            // 
            // labelTongTien
            // 
            this.labelTongTien.Location = new System.Drawing.Point(601, 453);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(124, 19);
            this.labelTongTien.TabIndex = 29;
            this.labelTongTien.Text = "0 đ";
            this.labelTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(519, 453);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 19);
            this.metroLabel5.TabIndex = 28;
            this.metroLabel5.Text = "Tổng tiền:";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(553, 60);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 36);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(354, 453);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(55, 23);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseSelectable = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 233);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(55, 19);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Thể loại";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 185);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(49, 19);
            this.metroLabel7.TabIndex = 34;
            this.metroLabel7.Text = "Tác giả";
            // 
            // txtTacGia
            // 
            // 
            // 
            // 
            this.txtTacGia.CustomButton.Image = null;
            this.txtTacGia.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtTacGia.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtTacGia.CustomButton.Name = "";
            this.txtTacGia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTacGia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTacGia.CustomButton.TabIndex = 1;
            this.txtTacGia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTacGia.CustomButton.UseSelectable = true;
            this.txtTacGia.CustomButton.Visible = false;
            this.txtTacGia.Lines = new string[0];
            this.txtTacGia.Location = new System.Drawing.Point(3, 205);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(2);
            this.txtTacGia.MaxLength = 32767;
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.PasswordChar = '\0';
            this.txtTacGia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTacGia.SelectedText = "";
            this.txtTacGia.SelectionLength = 0;
            this.txtTacGia.SelectionStart = 0;
            this.txtTacGia.ShortcutsEnabled = true;
            this.txtTacGia.Size = new System.Drawing.Size(211, 23);
            this.txtTacGia.TabIndex = 3;
            this.txtTacGia.UseSelectable = true;
            this.txtTacGia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTacGia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(3, 253);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(211, 23);
            this.cbbTheLoai.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(269, 453);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.AllowUserToResizeRows = false;
            this.dgvHoaDonNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDonNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDonNhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvHoaDonNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDonNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDonNhap.ColumnHeadersHeight = 24;
            this.dgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDonNhap.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDonNhap.EnableHeadersVisualStyles = false;
            this.dgvHoaDonNhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvHoaDonNhap.GridColor = System.Drawing.Color.White;
            this.dgvHoaDonNhap.Location = new System.Drawing.Point(241, 120);
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDonNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDonNhap.RowHeadersVisible = false;
            this.dgvHoaDonNhap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHoaDonNhap.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDonNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(620, 311);
            this.dgvHoaDonNhap.TabIndex = 36;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "     Tên sách";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "    Đơn giá";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "    Số lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "    Tác giả";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "    Thể loại";
            this.Column5.Name = "Column5";
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 543);
            this.ControlBox = false;
            this.Controls.Add(this.dgvHoaDonNhap);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbbTheLoai);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.labelTongTien);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.cbbDVCC);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.btnThem);
            this.Name = "Import";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Nhập hàng";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroTextBox txtGiaNhap;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSoLuong;
        private MetroFramework.Controls.MetroTextBox txtTenSach;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox cbbDVCC;
        private MetroFramework.Controls.MetroLabel labelTongTien;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnConfirm;
        private MetroFramework.Controls.MetroButton btnDel;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtTacGia;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroGrid dgvHoaDonNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}