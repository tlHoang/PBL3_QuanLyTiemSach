namespace PBL3_QuanLyTiemSach.View.StatisticUI
{
    partial class StatisticDetail
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
            this.dgv_detail = new System.Windows.Forms.DataGridView();
            this.metroButton_back = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_detail
            // 
            this.dgv_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detail.Location = new System.Drawing.Point(97, 117);
            this.dgv_detail.Name = "dgv_detail";
            this.dgv_detail.Size = new System.Drawing.Size(617, 150);
            this.dgv_detail.TabIndex = 0;
            // 
            // metroButton_back
            // 
            this.metroButton_back.Location = new System.Drawing.Point(364, 375);
            this.metroButton_back.Name = "metroButton_back";
            this.metroButton_back.Size = new System.Drawing.Size(75, 23);
            this.metroButton_back.TabIndex = 1;
            this.metroButton_back.Text = "Quay lại";
            this.metroButton_back.UseSelectable = true;
            this.metroButton_back.Click += new System.EventHandler(this.metroButton_back_Click);
            // 
            // StatisticDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButton_back);
            this.Controls.Add(this.dgv_detail);
            this.Name = "StatisticDetail";
            this.Text = "StatisticDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_detail;
        private MetroFramework.Controls.MetroButton metroButton_back;
    }
}