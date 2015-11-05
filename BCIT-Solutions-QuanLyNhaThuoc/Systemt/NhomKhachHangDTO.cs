namespace Systemt
{
    public class NhomKhachHangDTO
    {
        #region Thuộc tính

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string maNhomKhachHang;

        public string MaNhomKhachHang
        {
            get { return maNhomKhachHang; }
            set { maNhomKhachHang = value; }
        }
        private string tenNhomKhachHang;

        public string TenNhomKhachHang
        {
            get { return tenNhomKhachHang; }
            set { tenNhomKhachHang = value; }
        }

        private double phanTramLoiNhuan;

        public double PhanTramLoiNhuan
        {
            get { return phanTramLoiNhuan; }
            set { phanTramLoiNhuan = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        #endregion Thuộc tính

        public NhomKhachHangDTO()
        {
            this.id = 0;
            this.phanTramLoiNhuan = 10;
            this.maNhomKhachHang = this.tenNhomKhachHang = this.ghiChu = "";
        }
    }
}
