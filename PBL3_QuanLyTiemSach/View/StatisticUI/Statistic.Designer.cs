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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel_doanhthuvalue = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_doanhthu = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btn_chitiet = new MetroFramework.Controls.MetroButton();
            this.dgv_doanhthu = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_xem = new MetroFramework.Controls.MetroButton();
            this.btn_pdf = new MetroFramework.Controls.MetroButton();
            this.tabControl_thongke.SuspendLayout();
            this.tabPage_doanhthu.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).BeginInit();
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
            this.tabControl_thongke.Controls.Add(this.tabPage2);
            this.tabControl_thongke.Controls.Add(this.tabPage3);
            this.tabControl_thongke.Location = new System.Drawing.Point(23, 98);
            this.tabControl_thongke.Name = "tabControl_thongke";
            this.tabControl_thongke.SelectedIndex = 0;
            this.tabControl_thongke.Size = new System.Drawing.Size(654, 339);
            this.tabControl_thongke.TabIndex = 2;
            // 
            // tabPage_doanhthu
            // 
            this.tabPage_doanhthu.Controls.Add(this.metroPanel1);
            this.tabPage_doanhthu.Controls.Add(this.metroButton2);
            this.tabPage_doanhthu.Controls.Add(this.btn_chitiet);
            this.tabPage_doanhthu.Controls.Add(this.dgv_doanhthu);
            this.tabPage_doanhthu.Location = new System.Drawing.Point(4, 22);
            this.tabPage_doanhthu.Name = "tabPage_doanhthu";
            this.tabPage_doanhthu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_doanhthu.Size = new System.Drawing.Size(646, 313);
            this.tabPage_doanhthu.TabIndex = 0;
            this.tabPage_doanhthu.Text = "Doanh thu";
            this.tabPage_doanhthu.UseVisualStyleBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel_doanhthuvalue);
            this.metroPanel1.Controls.Add(this.metroLabel_doanhthu);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(462, 6);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(178, 246);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel_doanhthuvalue
            // 
            this.metroLabel_doanhthuvalue.AutoSize = true;
            this.metroLabel_doanhthuvalue.Location = new System.Drawing.Point(81, 12);
            this.metroLabel_doanhthuvalue.Name = "metroLabel_doanhthuvalue";
            this.metroLabel_doanhthuvalue.Size = new System.Drawing.Size(68, 19);
            this.metroLabel_doanhthuvalue.TabIndex = 3;
            this.metroLabel_doanhthuvalue.Text = "doanh thu";
            // 
            // metroLabel_doanhthu
            // 
            this.metroLabel_doanhthu.AutoSize = true;
            this.metroLabel_doanhthu.Location = new System.Drawing.Point(3, 12);
            this.metroLabel_doanhthu.Name = "metroLabel_doanhthu";
            this.metroLabel_doanhthu.Size = new System.Drawing.Size(72, 19);
            this.metroLabel_doanhthu.TabIndex = 2;
            this.metroLabel_doanhthu.Text = "Doanh thu:";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(305, 269);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.UseSelectable = true;
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
            // dgv_doanhthu
            // 
            this.dgv_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doanhthu.Location = new System.Drawing.Point(6, 6);
            this.dgv_doanhthu.Name = "dgv_doanhthu";
            this.dgv_doanhthu.Size = new System.Drawing.Size(450, 246);
            this.dgv_doanhthu.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(646, 313);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox_month;
        private MetroFramework.Controls.MetroComboBox metroComboBox_year;
        private System.Windows.Forms.TabControl tabControl_thongke;
        private System.Windows.Forms.TabPage tabPage_doanhthu;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btn_chitiet;
        private System.Windows.Forms.DataGridView dgv_doanhthu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MetroFramework.Controls.MetroButton btn_xem;
        private MetroFramework.Controls.MetroLabel metroLabel_doanhthu;
        private MetroFramework.Controls.MetroLabel metroLabel_doanhthuvalue;
        private MetroFramework.Controls.MetroButton btn_pdf;
    }
}