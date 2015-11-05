using System.ComponentModel;
using Systemd;
using Systemt;

namespace Systemb
{
    public class LoaiHangHoaBUS
    {  
        public BindingList<LoaiHangHoaDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<LoaiHangHoaDTO> danhSach = new BindingList<LoaiHangHoaDTO>();
            LoaiHangHoaDAO itemDAO = new LoaiHangHoaDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(LoaiHangHoaDTO itemDTO)
        {
            LoaiHangHoaDAO itemDAO = new LoaiHangHoaDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(LoaiHangHoaDTO itemDTO)
        {

            LoaiHangHoaDAO itemDAO = new LoaiHangHoaDAO();
            itemDAO.Sua(itemDTO);
        }

        public void Xoa(int ma)
        {
            LoaiHangHoaDAO itemDAO = new LoaiHangHoaDAO();
            itemDAO.Xoa(ma);
        }
    }
}
