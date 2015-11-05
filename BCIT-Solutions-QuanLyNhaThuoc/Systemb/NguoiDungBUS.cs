using System.ComponentModel;
using Systemd;
using Systemt;
using SystemFunctions;

namespace Systemb
{
    public class NguoiDungBUS
    {  
        public BindingList<NguoiDungDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<NguoiDungDTO> danhSach = new BindingList<NguoiDungDTO>();
            NguoiDungDAO itemDAO = new NguoiDungDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(NguoiDungDTO itemDTO)
        {            
            NguoiDungDAO itemDAO = new NguoiDungDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(NguoiDungDTO itemDTO)
        {

            NguoiDungDAO itemDAO = new NguoiDungDAO();
            itemDAO.Sua(itemDTO);
        }
        public void Xoa(int ma)
        {
            NguoiDungDAO itemDAO = new NguoiDungDAO();
            itemDAO.Xoa(ma);
        }
        public NguoiDungDTO LayThongTinNguoiDungByMa(string tenTruyCap)
        {
            NguoiDungDAO itemDAO = new NguoiDungDAO();
            return itemDAO.LayThongTinNguoiDungByMa(tenTruyCap);
        }
        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            NguoiDungDAO itemDAO = new NguoiDungDAO();
            NguoiDungDTO nguoiDungDTO = itemDAO.KiemTraDangNhap(tenDangNhap, matKhau);
            if (nguoiDungDTO.Id > 0)
            {
                if (nguoiDungDTO.VoHieu == true)
                {
                    return true;
                }
                else
                {
                    KiemTraThoiGian iThoiGian = new KiemTraThoiGian();
                    return iThoiGian.KiemTraKhoangThoiGianDMY(nguoiDungDTO.NgayBatDau, nguoiDungDTO.NgayKetThuc);
                }
            }
            else
            {
                return false;
            }
        }
    }
}
