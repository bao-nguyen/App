namespace Systemt
{
    public class PhanQuyenDTO
    {
        #region Thuộc tính

        private int id;

public int Id
{
  get { return id; }
  set { id = value; }
}

        private int idNguoiDung;

public int IdNguoiDung
{
  get { return idNguoiDung; }
  set { idNguoiDung = value; }
}

        private int idChucNang;

public int IdChucNang
{
  get { return idChucNang; }
  set { idChucNang = value; }
}

        private int idPhanHe;

public int IdPhanHe
{
  get { return idPhanHe; }
  set { idPhanHe = value; }
}

        private bool doc;

public bool Doc
{
  get { return doc; }
  set { doc = value; }
}

        private bool them;

public bool Them
{
  get { return them; }
  set { them = value; }
}

        private bool sua;

public bool Sua
{
  get { return sua; }
  set { sua = value; }
}

        private bool xoa;

public bool Xoa
{
  get { return xoa; }
  set { xoa = value; }
}

        #endregion Thuộc tính

        #region Hàm tạo
        public PhanQuyenDTO()
        {
            
        }

        #endregion Hàm tạo

    }

    public class PhanQuyenCTO
    {
        #region Thuộc tính

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int idNguoiDung;

        public int IdNguoiDung
        {
            get { return idNguoiDung; }
            set { idNguoiDung = value; }
        }

        private string chucNang;

public string ChucNang
{
  get { return chucNang; }
  set { chucNang = value; }
}

       
        private string phanHe;

public string PhanHe
{
  get { return phanHe; }
  set { phanHe = value; }
}


        private bool doc;

        public bool Doc
        {
            get { return doc; }
            set { doc = value; }
        }

        private bool them;

        public bool Them
        {
            get { return them; }
            set { them = value; }
        }

        private bool sua;

        public bool Sua
        {
            get { return sua; }
            set { sua = value; }
        }

        private bool xoa;

        public bool Xoa
        {
            get { return xoa; }
            set { xoa = value; }
        }

        #endregion Thuộc tính

        #region Hàm tạo
        public PhanQuyenCTO()
        {

        }

        #endregion Hàm tạo

    }
}
