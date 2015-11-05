using System.ComponentModel;
using Systemd;
using Systemt;

namespace Systemb
{
    public class NhomKhachHangBUS
    {  
        public BindingList<NhomKhachHangDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<NhomKhachHangDTO> danhSach = new BindingList<NhomKhachHangDTO>();
            NhomKhachHangDAO itemDAO = new NhomKhachHangDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(NhomKhachHangDTO itemDTO)
        {
            NhomKhachHangDAO itemDAO = new NhomKhachHangDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(NhomKhachHangDTO itemDTO)
        {

            NhomKhachHangDAO itemDAO = new NhomKhachHangDAO();
            itemDAO.Sua(itemDTO);
        }

        public void Xoa(int ma)
        {
            NhomKhachHangDAO itemDAO = new NhomKhachHangDAO();
            itemDAO.Xoa(ma);
        }
    }
}
