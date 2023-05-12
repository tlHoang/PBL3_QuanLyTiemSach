namespace PBL3_QuanLyTiemSach.View
{
    partial class Bill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListHoaDon = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbbHoaDon = new MetroFramework.Controls.MetroComboBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnReturn = new MetroFramework.Controls.MetroButton();
            this.btnShow = new MetroFramework.Controls.MetroButton();
            this.cbbSort = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListHoaDon
            // 
            this.dgvListHoaDon.AllowUserToResizeRows = false;
            this.dgvListHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvListHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListHoaDon.ColumnHeadersHeight = 24;
            this.dgvListHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListHoaDon.EnableHeadersVisualStyles = false;
            this.dgvListHoaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvListHoaDon.GridColor = System.Drawing.Color.White;
            this.dgvListHoaDon.Location = new System.Drawing.Point(23, 171);
            this.dgvListHoaDon.Name = "dgvListHoaDon";
            this.dgvListHoaDon.ReadOnly = true;
            this.dgvListHoaDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListHoaDon.RowHeadersVisible = false;
            this.dgvListHoaDon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListHoaDon.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListHoaDon.Size = new System.Drawing.Size(601, 256);
            this.dgvListHoaDon.TabIndex = 26;
            this.dgvListHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListHoaDon_CellContentClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Loại hóa đơn";
            // 
            // cbbHoaDon
            // 
            this.cbbHoaDon.FormattingEnabled = true;
            this.cbbHoaDon.ItemHeight = 23;
            this.cbbHoaDon.Items.AddRange(new object[] {
            "Hóa đơn nhập",
            "Hóa đơn bán hàng"});
            this.cbbHoaDon.Location = new System.Drawing.Point(121, 22);
            this.cbbHoaDon.Name = "cbbHoaDon";
            this.cbbHoaDon.Size = new System.Drawing.Size(204, 29);
            this.cbbHoaDon.TabIndex = 28;
            this.cbbHoaDon.UseSelectable = true;
            this.cbbHoaDon.SelectedIndexChanged += new System.EventHandler(this.cbbHoaDon_SelectedIndexChanged);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(121, 71);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(204, 29);
            this.metroDateTime1.TabIndex = 29;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Ngày lập";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(369, 28);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 31;
            this.btnReturn.Text = "Refresh";
            this.btnReturn.UseSelectable = true;
            this.btnReturn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(369, 77);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 32;
            this.btnShow.Text = "Show";
            this.btnShow.UseSelectable = true;
            this.btnShow.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // cbbSort
            // 
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.ItemHeight = 23;
            this.cbbSort.Items.AddRange(new object[] {
            "Mã đơn",
            "Ngày lập",
            "Nhân viên lập",
            "",
            "Tổng tiền"});
            this.cbbSort.Location = new System.Drawing.Point(121, 120);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(204, 29);
            this.cbbSort.TabIndex = 33;
            this.cbbSort.UseSelectable = true;
            this.cbbSort.SelectedIndexChanged += new System.EventHandler(this.cbbSort_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(29, 130);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 34;
            this.metroLabel3.Text = "Sắp xếp";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(369, 126);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 35;
            this.metroButton1.Text = "Sắp xếp";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // BillUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 437);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbbSort);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.cbbHoaDon);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgvListHoaDon);
            this.Name = "BillUI";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbbHoaDon;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnReturn;
        private MetroFramework.Controls.MetroGrid dgvListHoaDon;
        private MetroFramework.Controls.MetroButton btnShow;
        private MetroFramework.Controls.MetroComboBox cbbSort;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}