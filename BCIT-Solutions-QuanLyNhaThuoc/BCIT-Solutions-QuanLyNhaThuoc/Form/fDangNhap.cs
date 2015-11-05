using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;
using SystemFunctions;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDangNhap : Form
    {
        public delegate void DangNhap(string tenDangNhap);
        public delegate void ThoatDangNhap();
        public event DangNhap LoginEvent;
        public event ThoatDangNhap thoatChuongTrinh;
        public fDangNhap()
        {
            InitializeComponent();
        }       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            thoatChuongTrinh();
            this.Close();            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MD5 mahoa = new MD5();
            string tenDangNhap = tboxTenDangNhap.Text.Trim();
            string matKhau = mahoa.md5(tboxMatKhau.Text.Trim());
            NguoiDungBUS itemBUS = new NguoiDungBUS();
            bool ketQua = itemBUS.KiemTraDangNhap(tenDangNhap, matKhau);
            if(ketQua == false)
            {
                MessageBox.Show("Đăng nhập không thành công! Bạn bị một trong các lỗi sau:\n - Sai tên đăng nhập hoặc mật khẩu.\n - Tài khoản của bạn đã hết hạn sử dụng hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else 
            {
                MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoginEvent(tenDangNhap);
                this.Close();
            }            
        }

        

    
    }
}
