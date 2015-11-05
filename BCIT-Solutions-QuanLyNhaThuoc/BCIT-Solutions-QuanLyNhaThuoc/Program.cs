using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmManHinhChinh());
            //Application.Run(new fDanhMucBacSy());
            //Application.Run(new fDanhMucNhomKhachHang());
            //Application.Run(new fDanhMucKhachHang());
        }
    }
}
