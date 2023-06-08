namespace PBL3_QuanLyTiemSach.View
{
    partial class BookInfo
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
            this.metroGrid1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dgvBookInfo = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.txtBookInfoTenSach = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtBookInfoTacGia = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbbTheLoai = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnXem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTimKiem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnQuayLai = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.Location = new System.Drawing.Point(315, 112);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersWidth = 62;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 28;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(160, 98);
            this.metroGrid1.TabIndex = 0;
            // 
            // dgvBookInfo
            // 
            this.dgvBookInfo.AllowUserToResizeRows = false;
            this.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvBookInfo.Location = new System.Drawing.Point(15, 39);
            this.dgvBookInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.RowHeadersWidth = 62;
            this.dgvBookInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBookInfo.RowTemplate.Height = 28;
            this.dgvBookInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookInfo.Size = new System.Drawing.Size(512, 400);
            this.dgvBookInfo.TabIndex = 1;
            // 
            // txtBookInfoTenSach
            // 
            this.txtBookInfoTenSach.Location = new System.Drawing.Point(600, 39);
            this.txtBookInfoTenSach.Name = "txtBookInfoTenSach";
            this.txtBookInfoTenSach.Size = new System.Drawing.Size(123, 23);
            this.txtBookInfoTenSach.TabIndex = 7;
            // 
            // txtBookInfoTacGia
            // 
            this.txtBookInfoTacGia.Location = new System.Drawing.Point(600, 79);
            this.txtBookInfoTacGia.Name = "txtBookInfoTacGia";
            this.txtBookInfoTacGia.Size = new System.Drawing.Size(123, 23);
            this.txtBookInfoTacGia.TabIndex = 7;
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.DropDownWidth = 123;
            this.cbbTheLoai.Location = new System.Drawing.Point(600, 122);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(123, 21);
            this.cbbTheLoai.TabIndex = 8;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(535, 39);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "Tên Sách";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(535, 77);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(50, 20);
            this.kryptonLabel2.TabIndex = 9;
            this.kryptonLabel2.Values.Text = "Tác Giả";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(535, 122);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel3.TabIndex = 9;
            this.kryptonLabel3.Values.Text = "Thể Loại";
            // 
            // btnXem
            // 
            this.btnXem.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnXem.Location = new System.Drawing.Point(537, 188);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(90, 25);
            this.btnXem.TabIndex = 10;
            this.btnXem.Values.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.btnTimKiem.Location = new System.Drawing.Point(633, 188);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 25);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Values.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(600, 414);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(90, 25);
            this.btnQuayLai.TabIndex = 12;
            this.btnQuayLai.Values.Text = "Quay Lại";
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 468);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.cbbTheLoai);
            this.Controls.Add(this.txtBookInfoTacGia);
            this.Controls.Add(this.txtBookInfoTenSach);
            this.Controls.Add(this.dgvBookInfo);
            this.Controls.Add(this.metroGrid1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookInfo";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Text = "Quản Lý Sách";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView metroGrid1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvBookInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBookInfoTenSach;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBookInfoTacGia;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbbTheLoai;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTimKiem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnQuayLai;
    }
}