using System.ComponentModel;
using Systemd;
using Systemt;
using SystemFunctions;

namespace Systemb
{
    public class NhaCungCapBUS
    {  
        public BindingList<NhaCungCapDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<NhaCungCapDTO> danhSach = new BindingList<NhaCungCapDTO>();
            NhaCungCapDAO itemDAO = new NhaCungCapDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(NhaCungCapDTO itemDTO)
        {            
            NhaCungCapDAO itemDAO = new NhaCungCapDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(NhaCungCapDTO itemDTO)
        {

            NhaCungCapDAO itemDAO = new NhaCungCapDAO();
            itemDAO.Sua(itemDTO);
        }
        public void Xoa(int ma)
        {
            NhaCungCapDAO itemDAO = new NhaCungCapDAO();
            itemDAO.Xoa(ma);
        }        
    }
}
