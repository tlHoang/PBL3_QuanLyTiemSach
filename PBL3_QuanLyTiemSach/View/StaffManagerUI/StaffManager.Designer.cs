namespace PBL3_QuanLyTiemSach.View.StaffManager
{
    partial class StaffManager
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
            this.txtBox_search = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbb_sort = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btn_search = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgv_nhanvien = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btn_sort = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.checkBox_showInactiveStaff = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.btn_them = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_chinhsua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_xoa = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_sort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_search
            // 
            this.txtBox_search.Location = new System.Drawing.Point(125, 74);
            this.txtBox_search.Name = "txtBox_search";
            this.txtBox_search.Size = new System.Drawing.Size(100, 23);
            this.txtBox_search.TabIndex = 7;
            // 
            // cbb_sort
            // 
            this.cbb_sort.DropDownWidth = 121;
            this.cbb_sort.Location = new System.Drawing.Point(384, 74);
            this.cbb_sort.Name = "cbb_sort";
            this.cbb_sort.Size = new System.Drawing.Size(121, 21);
            this.cbb_sort.TabIndex = 8;
            this.cbb_sort.Text = "Sắp xếp";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(231, 72);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(90, 25);
            this.btn_search.TabIndex = 9;
            this.btn_search.Values.Text = "Tìm";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Location = new System.Drawing.Point(102, 103);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.ReadOnly = true;
            this.dgv_nhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nhanvien.Size = new System.Drawing.Size(607, 331);
            this.dgv_nhanvien.TabIndex = 11;
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(511, 72);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(90, 25);
            this.btn_sort.TabIndex = 12;
            this.btn_sort.Values.Text = "Sắp xếp";
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // checkBox_showInactiveStaff
            // 
            this.checkBox_showInactiveStaff.Location = new System.Drawing.Point(570, 440);
            this.checkBox_showInactiveStaff.Name = "checkBox_showInactiveStaff";
            this.checkBox_showInactiveStaff.Size = new System.Drawing.Size(123, 20);
            this.checkBox_showInactiveStaff.TabIndex = 13;
            this.checkBox_showInactiveStaff.Values.Text = "Nhân viên đã nghỉ";
            this.checkBox_showInactiveStaff.CheckedChanged += new System.EventHandler(this.checkBox_showInactiveStaff_CheckedChanged);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(6, 143);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(90, 25);
            this.btn_them.TabIndex = 14;
            this.btn_them.Values.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_chinhsua
            // 
            this.btn_chinhsua.Location = new System.Drawing.Point(6, 174);
            this.btn_chinhsua.Name = "btn_chinhsua";
            this.btn_chinhsua.Size = new System.Drawing.Size(90, 25);
            this.btn_chinhsua.TabIndex = 15;
            this.btn_chinhsua.Values.Text = "Chỉnh sửa";
            this.btn_chinhsua.Click += new System.EventHandler(this.btn_chinhsua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(6, 258);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(90, 25);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Values.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // StaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 524);
            this.ControlBox = false;
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_chinhsua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.checkBox_showInactiveStaff);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.dgv_nhanvien);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cbb_sort);
            this.Controls.Add(this.txtBox_search);
            this.Name = "StaffManager";
            this.Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.cbb_sort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBox_search;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbb_sort;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_search;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_nhanvien;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_sort;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox checkBox_showInactiveStaff;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_them;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_chinhsua;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_xoa;
    }
}