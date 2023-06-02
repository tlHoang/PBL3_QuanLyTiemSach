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
            this.metroPanel_thongtin = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_soluongdonhangvalue = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_soluonghoadon = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_doanhthuvalue = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_doanhthu = new MetroFramework.Controls.MetroLabel();
            this.btn_chitiet = new MetroFramework.Controls.MetroButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_changeprice = new System.Windows.Forms.Button();
            this.btn_xem = new MetroFramework.Controls.MetroButton();
            this.btn_pdf = new MetroFramework.Controls.MetroButton();
            this.dgv_doanhthu = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dgv_sach = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.tabControl_thongke.SuspendLayout();
            this.tabPage_doanhthu.SuspendLayout();
            this.metroPanel_thongtin.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).BeginInit();
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
            this.tabControl_thongke.Location = new System.Drawing.Point(23, 98);
            this.tabControl_thongke.Name = "tabControl_thongke";
            this.tabControl_thongke.SelectedIndex = 0;
            this.tabControl_thongke.Size = new System.Drawing.Size(654, 339);
            this.tabControl_thongke.TabIndex = 2;
            // 
            // tabPage_doanhthu
            // 
            this.tabPage_doanhthu.Controls.Add(this.dgv_doanhthu);
            this.tabPage_doanhthu.Controls.Add(this.metroPanel_thongtin);
            this.tabPage_doanhthu.Controls.Add(this.btn_chitiet);
            this.tabPage_doanhthu.Location = new System.Drawing.Point(4, 22);
            this.tabPage_doanhthu.Name = "tabPage_doanhthu";
            this.tabPage_doanhthu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_doanhthu.Size = new System.Drawing.Size(646, 313);
            this.tabPage_doanhthu.TabIndex = 0;
            this.tabPage_doanhthu.Text = "Doanh thu";
            this.tabPage_doanhthu.UseVisualStyleBackColor = true;
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
            // btn_chitiet
            // 
            this.btn_chitiet.Location = new System.Drawing.Point(68, 269);
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.Size = new System.Drawing.Size(75, 23);
            this.btn_chitiet.TabIndex = 1;
            this.btn_chitiet.Text = "Chi tiết";
            this.btn_chitiet.UseSelectable = true;
            this.btn_chitiet.Click += new System.EventHandler(this.metroButton_chitiet_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_sach);
            this.tabPage3.Controls.Add(this.btn_changeprice);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(646, 313);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sách";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_changeprice
            // 
            this.btn_changeprice.Location = new System.Drawing.Point(55, 271);
            this.btn_changeprice.Name = "btn_changeprice";
            this.btn_changeprice.Size = new System.Drawing.Size(75, 23);
            this.btn_changeprice.TabIndex = 1;
            this.btn_changeprice.Text = "Chỉnh giá";
            this.btn_changeprice.UseVisualStyleBackColor = true;
            this.btn_changeprice.Click += new System.EventHandler(this.button_changeprice_Click);
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(290, 64);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(49, 28);
            this.btn_xem.TabIndex = 3;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseSelectable = true;
            this.btn_xem.Click += new System.EventHandler(this.metroButton_xem_Click);
            // 
            // btn_pdf
            // 
            this.btn_pdf.Location = new System.Drawing.Point(545, 64);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(75, 28);
            this.btn_pdf.TabIndex = 4;
            this.btn_pdf.Text = "To PDF";
            this.btn_pdf.UseSelectable = true;
            // 
            // dgv_doanhthu
            // 
            this.dgv_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doanhthu.Location = new System.Drawing.Point(6, 6);
            this.dgv_doanhthu.Name = "dgv_doanhthu";
            this.dgv_doanhthu.Size = new System.Drawing.Size(374, 246);
            this.dgv_doanhthu.TabIndex = 4;
            // 
            // dgv_sach
            // 
            this.dgv_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sach.Location = new System.Drawing.Point(6, 6);
            this.dgv_sach.Name = "dgv_sach";
            this.dgv_sach.Size = new System.Drawing.Size(631, 246);
            this.dgv_sach.TabIndex = 2;
            this.dgv_sach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sach_CellDoubleClick);
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.tabControl_thongke);
            this.Controls.Add(this.metroComboBox_year);
            this.Controls.Add(this.metroComboBox_month);
            this.Name = "Statistic";
            this.Text = "Thống kê";
            this.tabControl_thongke.ResumeLayout(false);
            this.tabPage_doanhthu.ResumeLayout(false);
            this.metroPanel_thongtin.ResumeLayout(false);
            this.metroPanel_thongtin.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox_month;
        private MetroFramework.Controls.MetroComboBox metroComboBox_year;
        private System.Windows.Forms.TabControl tabControl_thongke;
        private System.Windows.Forms.TabPage tabPage_doanhthu;
        private MetroFramework.Controls.MetroPanel metroPanel_thongtin;
        private MetroFramework.Controls.MetroButton btn_chitiet;
        private System.Windows.Forms.TabPage tabPage3;
        private MetroFramework.Controls.MetroButton btn_xem;
        private MetroFramework.Controls.MetroLabel metroLabel_doanhthu;
        private MetroFramework.Controls.MetroLabel metroLabel_doanhthuvalue;
        private MetroFramework.Controls.MetroButton btn_pdf;
        private MetroFramework.Controls.MetroLabel metroLabel_soluonghoadon;
        private MetroFramework.Controls.MetroLabel metroLabel_soluongdonhangvalue;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btn_changeprice;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_doanhthu;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_sach;
    }
}