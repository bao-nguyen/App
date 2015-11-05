using System;
namespace Systemt
{
    public class KhachHangDTO
    {
        #region Thuộc tính

        private int id;

public int Id
{
  get { return id; }
  set { id = value; }
}
    
        private string maKhachHang;

public string MaKhachHang
{
  get { return maKhachHang; }
  set { maKhachHang = value; }
}
      
        private string hoKhachHang;

public string HoKhachHang
{
  get { return hoKhachHang; }
  set { hoKhachHang = value; }
}
       
        private string tenKhachHang;

public string TenKhachHang
{
  get { return tenKhachHang; }
  set { tenKhachHang = value; }
}              

        private int idNhomKhachHang;

public int IdNhomKhachHang
{
  get { return idNhomKhachHang; }
  set { idNhomKhachHang = value; }
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
     
        private DateTime ngaySinh;

public DateTime NgaySinh
{
  get { return ngaySinh; }
  set { ngaySinh = value; }
}

private string email;

public string Email
{
    get { return email; }
    set { email = value; }
}



        private string ghiChu;

public string GhiChu
{
  get { return ghiChu; }
  set { ghiChu = value; }
}


        #endregion Thuộc tính

        #region Hàm tạo
        public KhachHangDTO()
        {
            this.id = this.idNhomKhachHang = 0;
            this.maKhachHang = this.hoKhachHang = this.tenKhachHang = this.diaChi = this.dienThoai = this.email = this.ghiChu = "";            
            this.ngaySinh = DateTime.Now;
        }

        #endregion Hàm tạo

    }
}
