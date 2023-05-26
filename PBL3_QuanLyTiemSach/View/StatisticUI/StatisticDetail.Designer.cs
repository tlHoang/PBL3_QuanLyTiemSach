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
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.btn_changeprice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_detail
            // 
            this.dgv_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detail.Location = new System.Drawing.Point(12, 12);
            this.dgv_detail.Name = "dgv_detail";
            this.dgv_detail.Size = new System.Drawing.Size(523, 357);
            this.dgv_detail.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(389, 399);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Quay lại";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.metroButton_back_Click);
            // 
            // btn_changeprice
            // 
            this.btn_changeprice.Location = new System.Drawing.Point(78, 399);
            this.btn_changeprice.Name = "btn_changeprice";
            this.btn_changeprice.Size = new System.Drawing.Size(75, 23);
            this.btn_changeprice.TabIndex = 2;
            this.btn_changeprice.Text = "Chỉnh giá";
            this.btn_changeprice.UseVisualStyleBackColor = true;
            this.btn_changeprice.Visible = false;
            this.btn_changeprice.Click += new System.EventHandler(this.button_changeprice_Click);
            // 
            // StatisticDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.btn_changeprice);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_detail);
            this.Name = "StatisticDetail";
            this.Text = "StatisticDetail";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_detail;
        private MetroFramework.Controls.MetroButton btn_back;
        private System.Windows.Forms.Button btn_changeprice;
    }
}