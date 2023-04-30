namespace PBL3_QuanLyTiemSach.View
{
    partial class LoginForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_username = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox_password = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(54, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tài khoản";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(54, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Mật khẩu";
            // 
            // metroTextBox_username
            // 
            // 
            // 
            // 
            this.metroTextBox_username.CustomButton.Image = null;
            this.metroTextBox_username.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.metroTextBox_username.CustomButton.Name = "";
            this.metroTextBox_username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_username.CustomButton.TabIndex = 1;
            this.metroTextBox_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_username.CustomButton.UseSelectable = true;
            this.metroTextBox_username.CustomButton.Visible = false;
            this.metroTextBox_username.Lines = new string[0];
            this.metroTextBox_username.Location = new System.Drawing.Point(144, 63);
            this.metroTextBox_username.MaxLength = 32767;
            this.metroTextBox_username.Name = "metroTextBox_username";
            this.metroTextBox_username.PasswordChar = '\0';
            this.metroTextBox_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_username.SelectedText = "";
            this.metroTextBox_username.SelectionLength = 0;
            this.metroTextBox_username.SelectionStart = 0;
            this.metroTextBox_username.ShortcutsEnabled = true;
            this.metroTextBox_username.Size = new System.Drawing.Size(152, 23);
            this.metroTextBox_username.TabIndex = 2;
            this.metroTextBox_username.UseSelectable = true;
            this.metroTextBox_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox_password
            // 
            // 
            // 
            // 
            this.metroTextBox_password.CustomButton.Image = null;
            this.metroTextBox_password.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.metroTextBox_password.CustomButton.Name = "";
            this.metroTextBox_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_password.CustomButton.TabIndex = 1;
            this.metroTextBox_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_password.CustomButton.UseSelectable = true;
            this.metroTextBox_password.CustomButton.Visible = false;
            this.metroTextBox_password.Lines = new string[0];
            this.metroTextBox_password.Location = new System.Drawing.Point(144, 115);
            this.metroTextBox_password.MaxLength = 32767;
            this.metroTextBox_password.Name = "metroTextBox_password";
            this.metroTextBox_password.PasswordChar = '\0';
            this.metroTextBox_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_password.SelectedText = "";
            this.metroTextBox_password.SelectionLength = 0;
            this.metroTextBox_password.SelectionStart = 0;
            this.metroTextBox_password.ShortcutsEnabled = true;
            this.metroTextBox_password.Size = new System.Drawing.Size(152, 23);
            this.metroTextBox_password.TabIndex = 3;
            this.metroTextBox_password.UseSelectable = true;
            this.metroTextBox_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(178, 207);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Đăng nhập";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 298);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox_password);
            this.Controls.Add(this.metroTextBox_username);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "LoginForm";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox_username;
        private MetroFramework.Controls.MetroTextBox metroTextBox_password;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}