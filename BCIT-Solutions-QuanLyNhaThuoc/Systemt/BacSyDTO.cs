namespace Systemt
{
    public class BacSyDTO
    {
        #region Thuộc tính

        private int idBacSy;        
        private string maBacSy;        
        private string tenBacSy;        
        private string diaChi;        
        private string dienThoai;        
        private string ghiChu;

        #endregion Thuộc tính

        #region Get - Set

        public int IdBacSy
        {
            get { return idBacSy; }
            set { idBacSy = value; }
        }
        public string MaBacSy
        {
            get { return maBacSy; }
            set { maBacSy = value; }
        }

        public string TenBacSy
        {
            get { return tenBacSy; }
            set { tenBacSy = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

       

        #endregion Get - Set

        #region Hàm tạo
        public BacSyDTO()
        {
            this.idBacSy = 0;
            this.maBacSy = "";
            this.tenBacSy = "";
            this.diaChi = "";
            this.dienThoai = "";
            this.ghiChu = "";
        }

        #endregion Hàm tạo

    }
}
