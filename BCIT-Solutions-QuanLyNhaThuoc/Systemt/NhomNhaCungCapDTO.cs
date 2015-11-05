namespace Systemt
{
    public class NhomNhaCungCapDTO
    {
        #region Thuộc tính

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string maNhomNhaCungCap;

        public string MaNhomNhaCungCap
        {
            get { return maNhomNhaCungCap; }
            set { maNhomNhaCungCap = value; }
        }
        private string tenNhomNhaCungCap;

        public string TenNhomNhaCungCap
        {
            get { return tenNhomNhaCungCap; }
            set { tenNhomNhaCungCap = value; }
        }
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        #endregion Thuộc tính

        public NhomNhaCungCapDTO()
        {
            this.id = 0;
            this.maNhomNhaCungCap = this.tenNhomNhaCungCap = this.ghiChu = "";
        }
    }
}
