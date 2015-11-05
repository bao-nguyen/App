using System.ComponentModel;
using Systemd;
using Systemt;

namespace Systemb
{
    public class BacSyBUS
    {  
        public BindingList<BacSyDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<BacSyDTO> danhSach = new BindingList<BacSyDTO>();
            BacSyDAO itemDAO = new BacSyDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(BacSyDTO itemDTO)
        {            
            BacSyDAO itemDAO = new BacSyDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(BacSyDTO itemDTO)
        {

            BacSyDAO itemDAO = new BacSyDAO();
            itemDAO.Sua(itemDTO);
        }

        public void Xoa(int ma)
        {
            BacSyDAO itemDAO = new BacSyDAO();
            itemDAO.Xoa(ma);
        }
    }
}
