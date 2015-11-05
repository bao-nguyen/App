using System.ComponentModel;
using Systemd;
using Systemt;
using SystemFunctions;

namespace Systemb
{
    public class KhachHangBUS
    {  
        public BindingList<KhachHangDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<KhachHangDTO> danhSach = new BindingList<KhachHangDTO>();
            KhachHangDAO itemDAO = new KhachHangDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(KhachHangDTO itemDTO)
        {            
            KhachHangDAO itemDAO = new KhachHangDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(KhachHangDTO itemDTO)
        {

            KhachHangDAO itemDAO = new KhachHangDAO();
            itemDAO.Sua(itemDTO);
        }
        public void Xoa(int ma)
        {
            KhachHangDAO itemDAO = new KhachHangDAO();
            itemDAO.Xoa(ma);
        }        
    }
}
