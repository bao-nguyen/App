using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;
using SystemFunctions;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fThongTinCaNhan : Form
    {
        public fThongTinCaNhan()
        {
            InitializeComponent();
        }
        private NguoiDungDTO nguoiDungDTO = new NguoiDungDTO();
        public fThongTinCaNhan(NguoiDungDTO iNdDTO)
        {
            InitializeComponent();
            nguoiDungDTO = iNdDTO;
        }

        private void HienThiThongTinNguoiDung()
        {
            this.lbelTenDangNhap.Text = nguoiDungDTO.MaNguoiDung.ToString();
            this.lbelHoTen.Text = nguoiDungDTO.TenNguoiDung.ToString();
            this.lbelDienThoai.Text = this.txtSoDienThoai.Text = nguoiDungDTO.DienThoai.ToString();
            this.lbelDiaChi.Text = this.txtDiaChi.Text = nguoiDungDTO.DiaChi.ToString();
            
             
        }
        private void fThongTinCaNhan_Load(object sender, EventArgs e)
        {            
            this.HienThiThongTinNguoiDung();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {            
            MD5 mahoa = new MD5();
            string tenDangNhap = nguoiDungDTO.MaNguoiDung;
            string matKhau = mahoa.md5(txtMatKhauCu.Text.Trim());
            NguoiDungBUS nguoiDungBUS = new NguoiDungBUS();
            bool ketQua = nguoiDungBUS.KiemTraDangNhap(tenDangNhap, matKhau);
            if(ketQua == false)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else 
            {
                if (this.txtMatKhauMoi.Text.Length < 6 && this.txtMatKhauMoi.Text.Length > 0)
                {
                    MessageBox.Show("Mật khẩu có ít nhất 6 ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                else if (this.txtMatKhauMoi.Text != this.txtMatKhauNhapLai.Text && this.txtMatKhauMoi.Text.Length > 0)
                {
                    MessageBox.Show("Mật khẩu mới nhập lại không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                else
                {
                    if (this.txtDiaChi.Text.Length == 0 || this.txtSoDienThoai.Text.Length ==0)
                    {
                        MessageBox.Show("Điện thoại và địa chỉ không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    else
                    {
                        try
                        {
                            nguoiDungDTO.DiaChi = this.txtDiaChi.Text;
                            nguoiDungDTO.DienThoai = this.txtSoDienThoai.Text;
                            if (this.txtMatKhauMoi.Text.Length > 0)
                                nguoiDungDTO.MatKhau = mahoa.md5(txtMatKhauMoi.Text.Trim());
                            nguoiDungBUS.Sua(nguoiDungDTO);
                            this.Close();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }                        
                    }
                }                
            }            
        }

        
               

    }    
}
