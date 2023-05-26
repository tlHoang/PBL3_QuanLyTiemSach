namespace PBL3_QuanLyTiemSach
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_Left = new System.Windows.Forms.Panel();
            this.button_HoaDon = new System.Windows.Forms.Button();
            this.btnCaLam = new System.Windows.Forms.Button();
            this.btnThongTinSach = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel_Side = new System.Windows.Forms.Panel();
            this.button_ThongKe = new System.Windows.Forms.Button();
            this.button_NhapHang = new System.Windows.Forms.Button();
            this.button_BanHang = new System.Windows.Forms.Button();
            this.button_Home = new System.Windows.Forms.Button();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel_Left.Controls.Add(this.button_HoaDon);
            this.panel_Left.Controls.Add(this.btnCaLam);
            this.panel_Left.Controls.Add(this.btnThongTinSach);
            this.panel_Left.Controls.Add(this.labelRole);
            this.panel_Left.Controls.Add(this.labelName);
            this.panel_Left.Controls.Add(this.pictureBox);
            this.panel_Left.Controls.Add(this.panel_Side);
            this.panel_Left.Controls.Add(this.button_ThongKe);
            this.panel_Left.Controls.Add(this.button_NhapHang);
            this.panel_Left.Controls.Add(this.button_BanHang);
            this.panel_Left.Controls.Add(this.button_Home);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(153, 548);
            this.panel_Left.TabIndex = 0;
            this.panel_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel_Left.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel_Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button_HoaDon
            // 
            this.button_HoaDon.FlatAppearance.BorderSize = 0;
            this.button_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HoaDon.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_HoaDon.ForeColor = System.Drawing.Color.White;
            this.button_HoaDon.Location = new System.Drawing.Point(0, 297);
            this.button_HoaDon.Name = "button_HoaDon";
            this.button_HoaDon.Size = new System.Drawing.Size(153, 54);
            this.button_HoaDon.TabIndex = 7;
            this.button_HoaDon.Text = "Xem hoá đơn";
            this.button_HoaDon.UseVisualStyleBackColor = true;
            this.button_HoaDon.Click += new System.EventHandler(this.button_HoaDon_Click);
            // 
            // btnCaLam
            // 
            this.btnCaLam.FlatAppearance.BorderSize = 0;
            this.btnCaLam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaLam.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaLam.ForeColor = System.Drawing.Color.White;
            this.btnCaLam.Location = new System.Drawing.Point(0, 363);
            this.btnCaLam.Name = "btnCaLam";
            this.btnCaLam.Size = new System.Drawing.Size(153, 54);
            this.btnCaLam.TabIndex = 7;
            this.btnCaLam.Text = "Ca Làm";
            this.btnCaLam.UseVisualStyleBackColor = true;
            this.btnCaLam.Click += new System.EventHandler(this.btnCaLam_Click);
            // 
            // btnThongTinSach
            // 
            this.btnThongTinSach.FlatAppearance.BorderSize = 0;
            this.btnThongTinSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinSach.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinSach.ForeColor = System.Drawing.Color.White;
            this.btnThongTinSach.Location = new System.Drawing.Point(3, 303);
            this.btnThongTinSach.Name = "btnThongTinSach";
            this.btnThongTinSach.Size = new System.Drawing.Size(153, 54);
            this.btnThongTinSach.TabIndex = 8;
            this.btnThongTinSach.Text = "Thông Tin Sách";
            this.btnThongTinSach.UseVisualStyleBackColor = true;
            this.btnThongTinSach.Click += new System.EventHandler(this.btnThongTinSach_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.labelRole.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelRole.Location = new System.Drawing.Point(65, 51);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(30, 13);
            this.labelRole.TabIndex = 6;
            this.labelRole.Text = "Role";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.SkyBlue;
            this.labelName.Location = new System.Drawing.Point(65, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(47, 40);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // panel_Side
            // 
            this.panel_Side.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel_Side.Location = new System.Drawing.Point(0, 81);
            this.panel_Side.Name = "panel_Side";
            this.panel_Side.Size = new System.Drawing.Size(9, 54);
            this.panel_Side.TabIndex = 0;
            // 
            // button_ThongKe
            // 
            this.button_ThongKe.FlatAppearance.BorderSize = 0;
            this.button_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThongKe.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThongKe.ForeColor = System.Drawing.Color.White;
            this.button_ThongKe.Location = new System.Drawing.Point(0, 243);
            this.button_ThongKe.Name = "button_ThongKe";
            this.button_ThongKe.Size = new System.Drawing.Size(153, 54);
            this.button_ThongKe.TabIndex = 3;
            this.button_ThongKe.Text = "Thống kê";
            this.button_ThongKe.UseVisualStyleBackColor = true;
            this.button_ThongKe.Click += new System.EventHandler(this.button_ThongKe_Click);
            // 
            // button_NhapHang
            // 
            this.button_NhapHang.FlatAppearance.BorderSize = 0;
            this.button_NhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NhapHang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NhapHang.ForeColor = System.Drawing.Color.White;
            this.button_NhapHang.Location = new System.Drawing.Point(0, 189);
            this.button_NhapHang.Name = "button_NhapHang";
            this.button_NhapHang.Size = new System.Drawing.Size(153, 54);
            this.button_NhapHang.TabIndex = 2;
            this.button_NhapHang.Text = "Nhập hàng";
            this.button_NhapHang.UseVisualStyleBackColor = true;
            this.button_NhapHang.Click += new System.EventHandler(this.button_NhapHang_Click);
            // 
            // button_BanHang
            // 
            this.button_BanHang.FlatAppearance.BorderSize = 0;
            this.button_BanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BanHang.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BanHang.ForeColor = System.Drawing.Color.White;
            this.button_BanHang.Location = new System.Drawing.Point(0, 135);
            this.button_BanHang.Name = "button_BanHang";
            this.button_BanHang.Size = new System.Drawing.Size(153, 54);
            this.button_BanHang.TabIndex = 1;
            this.button_BanHang.Text = "Bán hàng";
            this.button_BanHang.UseVisualStyleBackColor = true;
            this.button_BanHang.Click += new System.EventHandler(this.button_BanHang_Click);
            // 
            // button_Home
            // 
            this.button_Home.FlatAppearance.BorderSize = 0;
            this.button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Home.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Home.ForeColor = System.Drawing.Color.White;
            this.button_Home.Location = new System.Drawing.Point(0, 81);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(153, 54);
            this.button_Home.TabIndex = 0;
            this.button_Home.Text = "Trang chủ";
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Top.Controls.Add(this.button5);
            this.panel_Top.Controls.Add(this.button_Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel_Top.Location = new System.Drawing.Point(153, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(928, 33);
            this.panel_Top.TabIndex = 1;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel_Top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(859, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Hide_Click);
            // 
            // button_Close
            // 
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.ForeColor = System.Drawing.Color.White;
            this.button_Close.Image = ((System.Drawing.Image)(resources.GetObject("button_Close.Image")));
            this.button_Close.Location = new System.Drawing.Point(895, 3);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 0;
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // panel_Body
            // 
            this.panel_Body.Location = new System.Drawing.Point(153, 33);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(925, 515);
            this.panel_Body.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 548);
            this.Controls.Add(this.panel_Body);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Left.ResumeLayout(false);
            this.panel_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Button button_BanHang;
        private System.Windows.Forms.Panel panel_Side;
        private System.Windows.Forms.Button button_ThongKe;
        private System.Windows.Forms.Button button_NhapHang;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button button_HoaDon;
        private System.Windows.Forms.Button btnCaLam;
        private System.Windows.Forms.Button btnThongTinSach;
    }
}

