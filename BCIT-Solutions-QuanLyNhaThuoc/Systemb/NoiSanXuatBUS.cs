using System.ComponentModel;
using Systemd;
using Systemt;

namespace Systemb
{
    public class NoiSanXuatBUS
    {  
        public BindingList<NoiSanXuatDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<NoiSanXuatDTO> danhSach = new BindingList<NoiSanXuatDTO>();
            NoiSanXuatDAO itemDAO = new NoiSanXuatDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(NoiSanXuatDTO itemDTO)
        {
            NoiSanXuatDAO itemDAO = new NoiSanXuatDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(NoiSanXuatDTO itemDTO)
        {

            NoiSanXuatDAO itemDAO = new NoiSanXuatDAO();
            itemDAO.Sua(itemDTO);
        }

        public void Xoa(int ma)
        {
            NoiSanXuatDAO itemDAO = new NoiSanXuatDAO();
            itemDAO.Xoa(ma);
        }
    }
}
