using System;
namespace Systemt
{
    public class ChucNangDTO
    {
        #region Thuộc tính

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string maChucNang;

        public string MaChucNang
        {
            get { return maChucNang; }
            set { maChucNang = value; }
        }
        private string tenChucNang;

        public string TenChucNang
        {
            get { return tenChucNang; }
            set { tenChucNang = value; }
        }
        private int idPhanHe;

        public int IdPhanHe
        {
            get { return idPhanHe; }
            set { idPhanHe = value; }
        }
        private string tenForm;

        public string TenForm
        {
            get { return tenForm; }
            set { tenForm = value; }
        }

        #endregion Thuộc tính

        #region Hàm tạo

        public ChucNangDTO()
        {
            this.id = this.idPhanHe = 0;
            this.maChucNang = this.tenChucNang = this.tenForm = "";            
        }

        #endregion Hàm tạo

    }
}
