namespace Systemt
{
    public class DonViTinhDTO
    {
        #region Thuộc tính

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string maDonViTinh;

        public string MaDonViTinh
        {
            get { return maDonViTinh; }
            set { maDonViTinh = value; }
        }
        private string tenDonViTinh;

        public string TenDonViTinh
        {
            get { return tenDonViTinh; }
            set { tenDonViTinh = value; }
        }
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        #endregion Thuộc tính

        public DonViTinhDTO()
        {
            this.id = 0;
            this.maDonViTinh = this.tenDonViTinh = this.ghiChu = "";
        }
    }
}
