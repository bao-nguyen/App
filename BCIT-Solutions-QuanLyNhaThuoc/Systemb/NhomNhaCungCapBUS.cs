using System.ComponentModel;
using Systemd;
using Systemt;

namespace Systemb
{
    public class NhomNhaCungCapBUS
    {  
        public BindingList<NhomNhaCungCapDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<NhomNhaCungCapDTO> danhSach = new BindingList<NhomNhaCungCapDTO>();
            NhomNhaCungCapDAO itemDAO = new NhomNhaCungCapDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(NhomNhaCungCapDTO itemDTO)
        {
            NhomNhaCungCapDAO itemDAO = new NhomNhaCungCapDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(NhomNhaCungCapDTO itemDTO)
        {

            NhomNhaCungCapDAO itemDAO = new NhomNhaCungCapDAO();
            itemDAO.Sua(itemDTO);
        }

        public void Xoa(int ma)
        {
            NhomNhaCungCapDAO itemDAO = new NhomNhaCungCapDAO();
            itemDAO.Xoa(ma);
        }
    }
}
