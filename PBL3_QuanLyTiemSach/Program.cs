using PBL3_QuanLyTiemSach.View;
using PBL3_QuanLyTiemSach.View.StaffManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_QuanLyTiemSach.View;
using PBL3_QuanLyTiemSach.View.SellUI;
using PBL3_QuanLyTiemSach.View.ImportUI;
using PBL3_QuanLyTiemSach.View.StatisticUI;

namespace PBL3_QuanLyTiemSach
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
