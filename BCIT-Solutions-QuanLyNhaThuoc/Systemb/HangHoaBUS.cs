using System.ComponentModel;
using Systemd;
using Systemt;
using SystemFunctions;

namespace Systemb
{
    public class HangHoaBUS
    {
        public BindingList<HangHoaDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<HangHoaDTO> danhSach = new BindingList<HangHoaDTO>();
            HangHoaDAO itemDAO = new HangHoaDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(HangHoaDTO itemDTO)
        {
            HangHoaDAO itemDAO = new HangHoaDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(HangHoaDTO itemDTO)
        {

            HangHoaDAO itemDAO = new HangHoaDAO();
            itemDAO.Sua(itemDTO);
        }
        public void Xoa(int ma)
        {
            HangHoaDAO itemDAO = new HangHoaDAO();
            itemDAO.Xoa(ma);
        }
    }
}
