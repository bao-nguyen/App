namespace Systemt
{
    public class HangSanXuatDTO
    {
        #region Thuộc tính

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string maHangSanXuat;

        public string MaHangSanXuat
        {
            get { return maHangSanXuat; }
            set { maHangSanXuat = value; }
        }
        private string tenHangSanXuat;

        public string TenHangSanXuat
        {
            get { return tenHangSanXuat; }
            set { tenHangSanXuat = value; }
        }
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        #endregion Thuộc tính

        public HangSanXuatDTO()
        {
            this.id = 0;
            this.maHangSanXuat = this.tenHangSanXuat = this.ghiChu = "";
        }
    }
}
