using System.ComponentModel;
using Systemd;
using Systemt;

namespace Systemb
{
    public class NhomHangHoaBUS
    {  
        public BindingList<NhomHangHoaDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<NhomHangHoaDTO> danhSach = new BindingList<NhomHangHoaDTO>();
            NhomHangHoaDAO itemDAO = new NhomHangHoaDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(NhomHangHoaDTO itemDTO)
        {
            NhomHangHoaDAO itemDAO = new NhomHangHoaDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(NhomHangHoaDTO itemDTO)
        {

            NhomHangHoaDAO itemDAO = new NhomHangHoaDAO();
            itemDAO.Sua(itemDTO);
        }

        public void Xoa(int ma)
        {
            NhomHangHoaDAO itemDAO = new NhomHangHoaDAO();
            itemDAO.Xoa(ma);
        }
    }
}
