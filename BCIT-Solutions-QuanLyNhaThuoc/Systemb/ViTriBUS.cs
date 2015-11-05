using System.ComponentModel;
using Systemd;
using Systemt;

namespace Systemb
{
    public class ViTriBUS
    {  
        public BindingList<ViTriDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<ViTriDTO> danhSach = new BindingList<ViTriDTO>();
            ViTriDAO itemDAO = new ViTriDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(ViTriDTO itemDTO)
        {
            ViTriDAO itemDAO = new ViTriDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(ViTriDTO itemDTO)
        {

            ViTriDAO itemDAO = new ViTriDAO();
            itemDAO.Sua(itemDTO);
        }

        public void Xoa(int ma)
        {
            ViTriDAO itemDAO = new ViTriDAO();
            itemDAO.Xoa(ma);
        }
    }
}
