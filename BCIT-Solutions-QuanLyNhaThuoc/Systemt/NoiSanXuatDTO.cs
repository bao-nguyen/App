namespace Systemt
{
    public class NoiSanXuatDTO
    {
        #region Thuộc tính

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string maNoiSanXuat;

        public string MaNoiSanXuat
        {
            get { return maNoiSanXuat; }
            set { maNoiSanXuat = value; }
        }
        private string tenNoiSanXuat;

        public string TenNoiSanXuat
        {
            get { return tenNoiSanXuat; }
            set { tenNoiSanXuat = value; }
        }
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        #endregion Thuộc tính

        public NoiSanXuatDTO()
        {
            this.id = 0;
            this.maNoiSanXuat = this.tenNoiSanXuat = this.ghiChu = "";
        }
    }
}
