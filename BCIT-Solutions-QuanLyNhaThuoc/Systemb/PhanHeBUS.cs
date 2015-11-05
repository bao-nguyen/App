using System.ComponentModel;
using Systemd;
using Systemt;

namespace Systemb
{
    public class PhanHeBUS
    {  
        public BindingList<PhanHeDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<PhanHeDTO> danhSach = new BindingList<PhanHeDTO>();
            PhanHeDAO itemDAO = new PhanHeDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(PhanHeDTO itemDTO)
        {
            PhanHeDAO itemDAO = new PhanHeDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(PhanHeDTO itemDTO)
        {

            PhanHeDAO itemDAO = new PhanHeDAO();
            itemDAO.Sua(itemDTO);
        }

        public void Xoa(int ma)
        {
            PhanHeDAO itemDAO = new PhanHeDAO();
            itemDAO.Xoa(ma);
        }
    }
}
