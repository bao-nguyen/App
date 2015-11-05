namespace Systemt
{
    public class ViTriDTO
    {
        #region Thuộc tính

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string maViTri;

        public string MaViTri
        {
            get { return maViTri; }
            set { maViTri = value; }
        }
        private string tenViTri;

        public string TenViTri
        {
            get { return tenViTri; }
            set { tenViTri = value; }
        }
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        #endregion Thuộc tính

        public ViTriDTO()
        {
            this.id = 0;
            this.maViTri = this.tenViTri = this.ghiChu = "";
        }
    }
}
