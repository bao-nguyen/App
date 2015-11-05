namespace Systemt
{
    public class LoaiHangHoaDTO
    {
        #region Thuộc tính

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string maLoaiHangHoa;

        public string MaLoaiHangHoa
        {
            get { return maLoaiHangHoa; }
            set { maLoaiHangHoa = value; }
        }
        private string tenLoaiHangHoa;

        public string TenLoaiHangHoa
        {
            get { return tenLoaiHangHoa; }
            set { tenLoaiHangHoa = value; }
        }
        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        #endregion Thuộc tính

        public LoaiHangHoaDTO()
        {
            this.id = 0;
            this.maLoaiHangHoa = this.tenLoaiHangHoa = this.ghiChu = "";
        }
    }
}
