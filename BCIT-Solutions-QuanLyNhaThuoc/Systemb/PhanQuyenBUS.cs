using System.ComponentModel;
using Systemd;
using Systemt;

namespace Systemb
{
    public class PhanQuyenBUS
    {  
        public BindingList<PhanQuyenDTO> LayDanhSach()
        {
            // Kiem tra Business Rule neu co
            BindingList<PhanQuyenDTO> danhSach = new BindingList<PhanQuyenDTO>();
            PhanQuyenDAO itemDAO = new PhanQuyenDAO();
            danhSach = itemDAO.LayDanhSach();
            return danhSach;
        }
        public void Them(PhanQuyenDTO itemDTO)
        {            
            PhanQuyenDAO itemDAO = new PhanQuyenDAO();
            itemDAO.Them(itemDTO);
        }
        public void Sua(PhanQuyenDTO itemDTO)
        {

            PhanQuyenDAO itemDAO = new PhanQuyenDAO();
            itemDAO.Sua(itemDTO);
        }

        public void Xoa(int ma)
        {
            PhanQuyenDAO itemDAO = new PhanQuyenDAO();
            itemDAO.Xoa(ma);
        }

        public BindingList<PhanQuyenCTO> LayDanhSachCTO(int maND)
        {
            // Kiem tra Business Rule neu co
            BindingList<PhanQuyenCTO> danhSach = new BindingList<PhanQuyenCTO>();
            PhanQuyenDAO itemDAO = new PhanQuyenDAO();
            danhSach = itemDAO.LayDanhSachCTO(maND);
            return danhSach;
        }
    }
}
