namespace PBL3_QuanLyTiemSach.View.StatisticUI
{
    partial class Statistic
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
            this.metroComboBox_month = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox_year = new MetroFramework.Controls.MetroComboBox();
            this.tabControl_thongke = new System.Windows.Forms.TabControl();
            this.tabPage_doanhthu = new System.Windows.Forms.TabPage();
            this.btn_chitiet = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgv_doanhthu = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.metroPanel_thongtin = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_soluongdonhangvalue = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_soluonghoadon = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_doanhthuvalue = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_doanhthu = new MetroFramework.Controls.MetroLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_chinhgia = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgv_sach = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.tabPage_luong = new System.Windows.Forms.TabPage();
            this.dgv_luong = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btn_xem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label_luong = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tabControl_thongke.SuspendLayout();
            this.tabPage_doanhthu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).BeginInit();
            this.metroPanel_thongtin.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).BeginInit();
            this.tabPage_luong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_luong)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBox_month
            // 
            this.metroComboBox_month.FormattingEnabled = true;
            this.metroComboBox_month.ItemHeight = 23;
            this.metroComboBox_month.Location = new System.Drawing.Point(36, 63);
            this.metroComboBox_month.Name = "metroComboBox_month";
            this.metroComboBox_month.PromptText = "Tháng";
            this.metroComboBox_month.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox_month.TabIndex = 0;
            this.metroComboBox_month.UseSelectable = true;
            // 
            // metroComboBox_year
            // 
            this.metroComboBox_year.FormattingEnabled = true;
            this.metroComboBox_year.ItemHeight = 23;
            this.metroComboBox_year.Location = new System.Drawing.Point(163, 63);
            this.metroComboBox_year.Name = "metroComboBox_year";
            this.metroComboBox_year.PromptText = "Năm";
            this.metroComboBox_year.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox_year.TabIndex = 1;
            this.metroComboBox_year.UseSelectable = true;
            // 
            // tabControl_thongke
            // 
            this.tabControl_thongke.Controls.Add(this.tabPage_doanhthu);
            this.tabControl_thongke.Controls.Add(this.tabPage3);
            this.tabControl_thongke.Controls.Add(this.tabPage_luong);
            this.tabControl_thongke.Location = new System.Drawing.Point(23, 98);
            this.tabControl_thongke.Name = "tabControl_thongke";
            this.tabControl_thongke.SelectedIndex = 0;
            this.tabControl_thongke.Size = new System.Drawing.Size(654, 339);
            this.tabControl_thongke.TabIndex = 2;
            // 
            // tabPage_doanhthu
            // 
            this.tabPage_doanhthu.Controls.Add(this.btn_chitiet);
            this.tabPage_doanhthu.Controls.Add(this.dgv_doanhthu);
            this.tabPage_doanhthu.Controls.Add(this.metroPanel_thongtin);
            this.tabPage_doanhthu.Location = new System.Drawing.Point(4, 22);
            this.tabPage_doanhthu.Name = "tabPage_doanhthu";
            this.tabPage_doanhthu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_doanhthu.Size = new System.Drawing.Size(646, 313);
            this.tabPage_doanhthu.TabIndex = 0;
            this.tabPage_doanhthu.Text = "Doanh thu";
            this.tabPage_doanhthu.UseVisualStyleBackColor = true;
            // 
            // btn_chitiet
            // 
            this.btn_chitiet.Location = new System.Drawing.Point(41, 258);
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.Size = new System.Drawing.Size(89, 25);
            this.btn_chitiet.TabIndex = 4;
            this.btn_chitiet.Values.Text = "Chi tiết";
            this.btn_chitiet.Click += new System.EventHandler(this.btn_chitiet_Click);
            // 
            // dgv_doanhthu
            // 
            this.dgv_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doanhthu.Location = new System.Drawing.Point(6, 6);
            this.dgv_doanhthu.Name = "dgv_doanhthu";
            this.dgv_doanhthu.ReadOnly = true;
            this.dgv_doanhthu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_doanhthu.Size = new System.Drawing.Size(374, 246);
            this.dgv_doanhthu.TabIndex = 4;
            // 
            // metroPanel_thongtin
            // 
            this.metroPanel_thongtin.Controls.Add(this.metroLabel1);
            this.metroPanel_thongtin.Controls.Add(this.metroLabel_soluongdonhangvalue);
            this.metroPanel_thongtin.Controls.Add(this.metroLabel_soluonghoadon);
            this.metroPanel_thongtin.Controls.Add(this.metroLabel_doanhthuvalue);
            this.metroPanel_thongtin.Controls.Add(this.metroLabel_doanhthu);
            this.metroPanel_thongtin.HorizontalScrollbarBarColor = true;
            this.metroPanel_thongtin.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel_thongtin.HorizontalScrollbarSize = 10;
            this.metroPanel_thongtin.Location = new System.Drawing.Point(386, 6);
            this.metroPanel_thongtin.Name = "metroPanel_thongtin";
            this.metroPanel_thongtin.Size = new System.Drawing.Size(254, 246);
            this.metroPanel_thongtin.TabIndex = 3;
            this.metroPanel_thongtin.VerticalScrollbarBarColor = true;
            this.metroPanel_thongtin.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel_thongtin.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(59, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(127, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Số liệu của tháng:";
            // 
            // metroLabel_soluongdonhangvalue
            // 
            this.metroLabel_soluongdonhangvalue.AutoSize = true;
            this.metroLabel_soluongdonhangvalue.Location = new System.Drawing.Point(132, 57);
            this.metroLabel_soluongdonhangvalue.Name = "metroLabel_soluongdonhangvalue";
            this.metroLabel_soluongdonhangvalue.Size = new System.Drawing.Size(78, 19);
            this.metroLabel_soluongdonhangvalue.TabIndex = 5;
            this.metroLabel_soluongdonhangvalue.Text = "soluongdon";
            // 
            // metroLabel_soluonghoadon
            // 
            this.metroLabel_soluonghoadon.AutoSize = true;
            this.metroLabel_soluonghoadon.Location = new System.Drawing.Point(1, 57);
            this.metroLabel_soluonghoadon.Name = "metroLabel_soluonghoadon";
            this.metroLabel_soluonghoadon.Size = new System.Drawing.Size(125, 19);
            this.metroLabel_soluonghoadon.TabIndex = 4;
            this.metroLabel_soluonghoadon.Text = "Số lượng đơn hàng:";
            // 
            // metroLabel_doanhthuvalue
            // 
            this.metroLabel_doanhthuvalue.AutoSize = true;
            this.metroLabel_doanhthuvalue.Location = new System.Drawing.Point(132, 38);
            this.metroLabel_doanhthuvalue.Name = "metroLabel_doanhthuvalue";
            this.metroLabel_doanhthuvalue.Size = new System.Drawing.Size(68, 19);
            this.metroLabel_doanhthuvalue.TabIndex = 3;
            this.metroLabel_doanhthuvalue.Text = "doanh thu";
            // 
            // metroLabel_doanhthu
            // 
            this.metroLabel_doanhthu.AutoSize = true;
            this.metroLabel_doanhthu.Location = new System.Drawing.Point(1, 38);
            this.metroLabel_doanhthu.Name = "metroLabel_doanhthu";
            this.metroLabel_doanhthu.Size = new System.Drawing.Size(72, 19);
            this.metroLabel_doanhthu.TabIndex = 2;
            this.metroLabel_doanhthu.Text = "Doanh thu:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_chinhgia);
            this.tabPage3.Controls.Add(this.dgv_sach);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(646, 313);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sách";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_chinhgia
            // 
            this.btn_chinhgia.Location = new System.Drawing.Point(41, 258);
            this.btn_chinhgia.Name = "btn_chinhgia";
            this.btn_chinhgia.Size = new System.Drawing.Size(89, 25);
            this.btn_chinhgia.TabIndex = 3;
            this.btn_chinhgia.Values.Text = "Chỉnh giá";
            this.btn_chinhgia.Click += new System.EventHandler(this.btn_chinhgia_Click);
            // 
            // dgv_sach
            // 
            this.dgv_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sach.Location = new System.Drawing.Point(6, 6);
            this.dgv_sach.Name = "dgv_sach";
            this.dgv_sach.ReadOnly = true;
            this.dgv_sach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sach.Size = new System.Drawing.Size(631, 246);
            this.dgv_sach.TabIndex = 2;
            this.dgv_sach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sach_CellDoubleClick);
            // 
            // tabPage_luong
            // 
            this.tabPage_luong.Controls.Add(this.label_luong);
            this.tabPage_luong.Controls.Add(this.kryptonLabel1);
            this.tabPage_luong.Controls.Add(this.dgv_luong);
            this.tabPage_luong.Location = new System.Drawing.Point(4, 22);
            this.tabPage_luong.Name = "tabPage_luong";
            this.tabPage_luong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_luong.Size = new System.Drawing.Size(646, 313);
            this.tabPage_luong.TabIndex = 3;
            this.tabPage_luong.Text = "Lương";
            this.tabPage_luong.UseVisualStyleBackColor = true;
            // 
            // dgv_luong
            // 
            this.dgv_luong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_luong.Location = new System.Drawing.Point(6, 6);
            this.dgv_luong.Name = "dgv_luong";
            this.dgv_luong.ReadOnly = true;
            this.dgv_luong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_luong.Size = new System.Drawing.Size(631, 246);
            this.dgv_luong.TabIndex = 0;
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(290, 63);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(78, 29);
            this.btn_xem.TabIndex = 3;
            this.btn_xem.Values.Text = "Xem";
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(422, 273);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Tổng:";
            // 
            // label_luong
            // 
            this.label_luong.Location = new System.Drawing.Point(469, 273);
            this.label_luong.Name = "label_luong";
            this.label_luong.Size = new System.Drawing.Size(88, 20);
            this.label_luong.TabIndex = 2;
            this.label_luong.Values.Text = "kryptonLabel2";
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 562);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.tabControl_thongke);
            this.Controls.Add(this.metroComboBox_year);
            this.Controls.Add(this.metroComboBox_month);
            this.Name = "Statistic";
            this.Text = "Thống kê";
            this.tabControl_thongke.ResumeLayout(false);
            this.tabPage_doanhthu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).EndInit();
            this.metroPanel_thongtin.ResumeLayout(false);
            this.metroPanel_thongtin.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).EndInit();
            this.tabPage_luong.ResumeLayout(false);
            this.tabPage_luong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_luong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox_month;
        private MetroFramework.Controls.MetroComboBox metroComboBox_year;
        private System.Windows.Forms.TabControl tabControl_thongke;
        private System.Windows.Forms.TabPage tabPage_doanhthu;
        private MetroFramework.Controls.MetroPanel metroPanel_thongtin;
        private System.Windows.Forms.TabPage tabPage3;
        private MetroFramework.Controls.MetroLabel metroLabel_doanhthu;
        private MetroFramework.Controls.MetroLabel metroLabel_doanhthuvalue;
        private MetroFramework.Controls.MetroLabel metroLabel_soluonghoadon;
        private MetroFramework.Controls.MetroLabel metroLabel_soluongdonhangvalue;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_doanhthu;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_sach;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_chitiet;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_xem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_chinhgia;
        private System.Windows.Forms.TabPage tabPage_luong;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_luong;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label_luong;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}