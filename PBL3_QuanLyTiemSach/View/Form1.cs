using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_QuanLyTiemSach.View;

namespace PBL3_QuanLyTiemSach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form currentForm; 
        private void OpenForm(Form f)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = f;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_Side.Top = button1.Top;
            panel_Side.Height = button1.Height;
            OpenForm(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_Side.Top = button2.Top;
            panel_Side.Height = button2.Height;
            OpenForm(new Form3());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_Side.Top = button3.Top;
            panel_Side.Height = button3.Height;
            OpenForm(new Form4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_Side.Top = button4.Top;
            OpenForm(new Form5());
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
