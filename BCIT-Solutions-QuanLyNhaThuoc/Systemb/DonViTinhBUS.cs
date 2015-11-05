using System.ComponentModel;
using Systemd;
using Systemt;

namespace Systemb
{
    public class DonViTinhBUS
    {  
        public BindingList<DonViTinhDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<DonViTinhDTO> danhSach = new BindingList<DonViTinhDTO>();
            DonViTinhDAO itemDAO = new DonViTinhDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(DonViTinhDTO itemDTO)
        {
            DonViTinhDAO itemDAO = new DonViTinhDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(DonViTinhDTO itemDTO)
        {

            DonViTinhDAO itemDAO = new DonViTinhDAO();
            itemDAO.Sua(itemDTO);
        }

        public void Xoa(int ma)
        {
            DonViTinhDAO itemDAO = new DonViTinhDAO();
            itemDAO.Xoa(ma);
        }
    }
}
