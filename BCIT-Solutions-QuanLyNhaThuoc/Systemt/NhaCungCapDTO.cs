namespace Systemt
{
    public class NhaCungCapDTO
    {
        #region Thuộc tính

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string maNhaCungCap;

        public string MaNhaCungCap
        {
            get { return maNhaCungCap; }
            set { maNhaCungCap = value; }
        }
        private string tenNhaCungCap;

        public string TenNhaCungCap
        {
            get { return tenNhaCungCap; }
            set { tenNhaCungCap = value; }
        }
        private int idNhomNhaCungCap;

        public int IdNhomNhaCungCap
        {
            get { return idNhomNhaCungCap; }
            set { idNhomNhaCungCap = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string dienThoai;

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string soTaiKhoan;

        public string SoTaiKhoan
        {
            get { return soTaiKhoan; }
            set { soTaiKhoan = value; }
        }
        private string tenNganHang;

        public string TenNganHang
        {
            get { return tenNganHang; }
            set { tenNganHang = value; }
        }
        private string tenChiNhanh;

        public string TenChiNhanh
        {
            get { return tenChiNhanh; }
            set { tenChiNhanh = value; }
        }
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        #endregion Thuộc tính

        #region Hàm tạo
        public NhaCungCapDTO()
        {
            this.id = this.idNhomNhaCungCap = 0;
            this.maNhaCungCap = this.tenNhaCungCap = this.diaChi = this.dienThoai = this.email = this.tenNganHang = this.soTaiKhoan = this.tenChiNhanh = this.ghiChu = "";                        
        }

        #endregion Hàm tạo

    }
}
