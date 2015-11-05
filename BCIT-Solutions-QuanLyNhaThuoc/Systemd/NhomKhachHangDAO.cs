using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class NhomKhachHangDAO
    {       
        public BindingList<NhomKhachHangDTO> LayDanhSach()
        {
            BindingList<NhomKhachHangDTO> danhSach = new BindingList<NhomKhachHangDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From DanhMucNhomKhachHang";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhomKhachHangDTO itemDTO = new NhomKhachHangDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaNhomKhachHang = (string)dr["MaNhomKhachHang"];
                itemDTO.TenNhomKhachHang = (string)dr["TenNhomKhachHang"];
                itemDTO.PhanTramLoiNhuan = (double)dr["PhanTramLoiNhuan"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(NhomKhachHangDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into DanhMucNhomKhachHang (MaNhomKhachHang,TenNhomKhachHang,PhanTramLoiNhuan,GhiChu) values (?, ?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@MaNhomKhachHang", OleDbType.WChar).Value = itemDTO.MaNhomKhachHang;
            cmd.Parameters.Add("@TenNhomKhachHang", OleDbType.WChar).Value = itemDTO.TenNhomKhachHang;
            cmd.Parameters.Add("@PhanTramLoiNhuan", OleDbType.Double).Value = itemDTO.PhanTramLoiNhuan;            
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;                      
            
            cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(NhomKhachHangDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update DanhMucNhomKhachHang Set MaNhomKhachHang = ?, TenNhomKhachHang = ?, PhanTramLoiNhuan = ?, GhiChu = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaNhomKhachHang", OleDbType.WChar).Value = itemDTO.MaNhomKhachHang;
            cmd.Parameters.Add("@TenNhomKhachHang", OleDbType.WChar).Value = itemDTO.TenNhomKhachHang;
            cmd.Parameters.Add("@PhanTramLoiNhuan", OleDbType.WChar).Value = itemDTO.PhanTramLoiNhuan;            
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = itemDTO.Id;
            
            cmd.ExecuteNonQuery();            
            cn.Close();

        }

        public void Xoa(int ma)
        {
            OleDbConnection cn;
            cn = DataProvider.KetNoi();

            string strSQL;
            strSQL = "DELETE FROM DanhMucNhomKhachHang Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
