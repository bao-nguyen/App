namespace Systemt
{
    public class ChucDanhDTO
    {
        #region Thuộc tính

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string maChucDanh;

        public string MaChucDanh
        {
            get { return maChucDanh; }
            set { maChucDanh = value; }
        }


        private string tenChucDanh;

        public string TenChucDanh
        {
            get { return tenChucDanh; }
            set { tenChucDanh = value; }
        }

        
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        #endregion Thuộc tính

        public ChucDanhDTO()
        {
            this.id = 0;
            this.maChucDanh = this.tenChucDanh = this.ghiChu = "";
        }
    }
}
