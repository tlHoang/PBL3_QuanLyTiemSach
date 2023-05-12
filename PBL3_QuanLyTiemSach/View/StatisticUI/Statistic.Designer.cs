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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl_thongke.SuspendLayout();
            this.tabPage_doanhthu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
            this.tabPage_doanhthu.Controls.Add(this.metroButton1);
            this.tabPage_doanhthu.Controls.Add(this.dgv);
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
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(305, 269);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "metroButton2";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(68, 269);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 6);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(450, 246);
            this.dgv.TabIndex = 0;
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
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.tabControl_thongke);
            this.Controls.Add(this.metroComboBox_year);
            this.Controls.Add(this.metroComboBox_month);
            this.Name = "Statistic";
            this.Text = "Thống kê";
            this.tabControl_thongke.ResumeLayout(false);
            this.tabPage_doanhthu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox_month;
        private MetroFramework.Controls.MetroComboBox metroComboBox_year;
        private System.Windows.Forms.TabControl tabControl_thongke;
        private System.Windows.Forms.TabPage tabPage_doanhthu;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}