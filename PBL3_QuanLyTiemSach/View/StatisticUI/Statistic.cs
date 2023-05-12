using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyTiemSach.View.StatisticUI
{
    public partial class Statistic : MetroFramework.Forms.MetroForm
    {
        public Statistic()
        {
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {
            for (int i = 1; i <= 12; i++)
            {
                metroComboBox_month.Items.Add(new CBBItem
                {
                    Value = i,
                    Text = $"Tháng {i}"
                });
            }
            int thisYear = Convert.ToInt32(DateTime.Now.Year);
            for (int i = thisYear - 5; i <= thisYear; i++)
            {
                metroComboBox_year.Items.Add(new CBBItem
                {
                    Value = i,
                    Text = $"Năm {i}"
                });
            }
        }
    }
}
