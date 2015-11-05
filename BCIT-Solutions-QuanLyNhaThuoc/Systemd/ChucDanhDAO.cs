using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class ChucDanhDAO
    {       
        public BindingList<ChucDanhDTO> LayDanhSach()
        {
            BindingList<ChucDanhDTO> danhSach = new BindingList<ChucDanhDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From SysDanhMucChucDanh";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ChucDanhDTO itemDTO = new ChucDanhDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaChucDanh = (string)dr["MaChucDanh"];
                itemDTO.TenChucDanh = (string)dr["TenChucDanh"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        /*
        public BindingList<ChucDanhDTO> LayDanhSachCombobox()
        {
            BindingList<ChucDanhDTO> danhSach = new BindingList<ChucDanhDTO>();
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From DanhMucChucDanh";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ChucDanhDTO itemDTO = new ChucDanhDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaChucDanh = (string)dr["MaChucDanh"];
                itemDTO.TenChucDanh = (string)dr["TenChucDanh"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        */
        public void Them(ChucDanhDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into SysDanhMucChucDanh (MaChucDanh,TenChucDanh,GhiChu) values (?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@MaChucDanh", OleDbType.WChar).Value = itemDTO.MaChucDanh;
            cmd.Parameters.Add("@TenChucDanh", OleDbType.WChar).Value = itemDTO.TenChucDanh;            
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;                      
            
                cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(ChucDanhDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update SysDanhMucChucDanh Set MaChucDanh = ?, TenChucDanh = ?, GhiChu = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaChucDanh", OleDbType.WChar).Value = itemDTO.MaChucDanh;
            cmd.Parameters.Add("@TenChucDanh", OleDbType.WChar).Value = itemDTO.TenChucDanh;            
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
            strSQL = "DELETE FROM SysDanhMucChucDanh Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
