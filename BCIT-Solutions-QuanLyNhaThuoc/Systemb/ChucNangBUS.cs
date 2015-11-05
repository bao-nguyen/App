using System.ComponentModel;
using Systemd;
using Systemt;

namespace Systemb
{
    public class ChucNangBUS
    {  
        public BindingList<ChucNangDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<ChucNangDTO> danhSach = new BindingList<ChucNangDTO>();
            ChucNangDAO itemDAO = new ChucNangDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(ChucNangDTO itemDTO)
        {            
            ChucNangDAO itemDAO = new ChucNangDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(ChucNangDTO itemDTO)
        {

            ChucNangDAO itemDAO = new ChucNangDAO();
            itemDAO.Sua(itemDTO);
        }

        public void Xoa(int ma)
        {
            ChucNangDAO itemDAO = new ChucNangDAO();
            itemDAO.Xoa(ma);
        }
        /*
        public ChucNangDTO LayThongTinNguoiDungByMa(string tenTruyCap)
        {
            ChucNangDAO itemDAO = new ChucNangDAO();
            return itemDAO.LayThongTinNguoiDungByMa(tenTruyCap);
        }
        */ 
    }
}
