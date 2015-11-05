using System.ComponentModel;
using Systemd;
using Systemt;

namespace Systemb
{
    public class HangSanXuatBUS
    {  
        public BindingList<HangSanXuatDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<HangSanXuatDTO> danhSach = new BindingList<HangSanXuatDTO>();
            HangSanXuatDAO itemDAO = new HangSanXuatDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(HangSanXuatDTO itemDTO)
        {
            HangSanXuatDAO itemDAO = new HangSanXuatDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(HangSanXuatDTO itemDTO)
        {

            HangSanXuatDAO itemDAO = new HangSanXuatDAO();
            itemDAO.Sua(itemDTO);
        }

        public void Xoa(int ma)
        {
            HangSanXuatDAO itemDAO = new HangSanXuatDAO();
            itemDAO.Xoa(ma);
        }
    }
}
