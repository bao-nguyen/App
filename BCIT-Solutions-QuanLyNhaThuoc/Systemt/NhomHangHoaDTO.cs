namespace Systemt
{
    public class NhomHangHoaDTO
    {
        #region Thuộc tính

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string maNhomHangHoa;

public string MaNhomHangHoa
{
  get { return maNhomHangHoa; }
  set { maNhomHangHoa = value; }
}

        private string tenNhomHangHoa;

public string TenNhomHangHoa
{
  get { return tenNhomHangHoa; }
  set { tenNhomHangHoa = value; }
}

        private string ghiChu;

public string GhiChu
{
  get { return ghiChu; }
  set { ghiChu = value; }
}


        #endregion Thuộc tính

        public NhomHangHoaDTO()
        {
            this.id = 0;
            this.maNhomHangHoa = this.tenNhomHangHoa = this.ghiChu = "";
        }
    }
}
