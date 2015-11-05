using System.ComponentModel;
using Systemd;
using Systemt;

namespace Systemb
{
    public class ChucDanhBUS
    {  
        public BindingList<ChucDanhDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<ChucDanhDTO> danhSach = new BindingList<ChucDanhDTO>();
            ChucDanhDAO itemDAO = new ChucDanhDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(ChucDanhDTO itemDTO)
        {
            ChucDanhDAO itemDAO = new ChucDanhDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(ChucDanhDTO itemDTO)
        {

            ChucDanhDAO itemDAO = new ChucDanhDAO();
            itemDAO.Sua(itemDTO);
        }

        public void Xoa(int ma)
        {
            ChucDanhDAO itemDAO = new ChucDanhDAO();
            itemDAO.Xoa(ma);
        }
    }
}
