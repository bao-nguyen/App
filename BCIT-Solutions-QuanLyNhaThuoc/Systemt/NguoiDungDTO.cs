using System;
namespace Systemt
{
    public class NguoiDungDTO
    {
        #region Thuộc tính

        private int id;

public int Id
{
  get { return id; }
  set { id = value; }
}        
        private string maNguoiDung;

public string MaNguoiDung
{
  get { return maNguoiDung; }
  set { maNguoiDung = value; }
}        
        private string tenNguoiDung;

public string TenNguoiDung
{
  get { return tenNguoiDung; }
  set { tenNguoiDung = value; }
}        
        private string matKhau;

public string MatKhau
{
  get { return matKhau; }
  set { matKhau = value; }
}        
        private bool voHieu;

public bool VoHieu
{
  get { return voHieu; }
  set { voHieu = value; }
}

        private int idChucDanh;

public int IdChucDanh
{
    get { return idChucDanh; }
    set { idChucDanh = value; }
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
        private DateTime ngayBatDau;

public DateTime NgayBatDau
{
  get { return ngayBatDau; }
  set { ngayBatDau = value; }
}
        private DateTime ngayKetThuc;

public DateTime NgayKetThuc
{
  get { return ngayKetThuc; }
  set { ngayKetThuc = value; }
}
        private string ghiChu;

public string GhiChu
{
  get { return ghiChu; }
  set { ghiChu = value; }
}

        #endregion Thuộc tính

        #region Hàm tạo
        public NguoiDungDTO()
        {
            this.id = this.idChucDanh = 0;
            this.maNguoiDung = this.tenNguoiDung = this.matKhau = this.diaChi = this.dienThoai = this.ghiChu = "";
            this.voHieu = false;
            this.ngayBatDau = this.ngayKetThuc = DateTime.Now;
        }

        #endregion Hàm tạo

    }
}
