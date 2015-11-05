using System.ComponentModel;
using Systemd;
using Systemt;

namespace Systemb
{
    public class HoatChatChinhBUS
    {  
        public BindingList<HoatChatChinhDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<HoatChatChinhDTO> danhSach = new BindingList<HoatChatChinhDTO>();
            HoatChatChinhDAO itemDAO = new HoatChatChinhDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(HoatChatChinhDTO itemDTO)
        {
            HoatChatChinhDAO itemDAO = new HoatChatChinhDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(HoatChatChinhDTO itemDTO)
        {

            HoatChatChinhDAO itemDAO = new HoatChatChinhDAO();
            itemDAO.Sua(itemDTO);
        }

        public void Xoa(int ma)
        {
            HoatChatChinhDAO itemDAO = new HoatChatChinhDAO();
            itemDAO.Xoa(ma);
        }
    }
}
