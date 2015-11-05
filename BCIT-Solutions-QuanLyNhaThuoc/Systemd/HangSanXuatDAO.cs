using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class HangSanXuatDAO
    {
        public BindingList<HangSanXuatDTO> LayDanhSach()
        {
            BindingList<HangSanXuatDTO> danhSach = new BindingList<HangSanXuatDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From DanhMucHangSanXuat";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                HangSanXuatDTO itemDTO = new HangSanXuatDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaHangSanXuat = (string)dr["MaHangSanXuat"];
                itemDTO.TenHangSanXuat = (string)dr["TenHangSanXuat"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(HangSanXuatDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;

            strSQL = "Insert into DanhMucHangSanXuat (MaHangSanXuat,TenHangSanXuat,GhiChu) values (?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@MaHangSanXuat", OleDbType.WChar).Value = itemDTO.MaHangSanXuat;
            cmd.Parameters.Add("@TenHangSanXuat", OleDbType.WChar).Value = itemDTO.TenHangSanXuat;            
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;                      
            
                cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(HangSanXuatDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;
            strSQL = "Update DanhMucHangSanXuat Set MaHangSanXuat = ?, TenHangSanXuat = ?, GhiChu = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaHangSanXuat", OleDbType.WChar).Value = itemDTO.MaHangSanXuat;
            cmd.Parameters.Add("@TenHangSanXuat", OleDbType.WChar).Value = itemDTO.TenHangSanXuat;            
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
            strSQL = "DELETE FROM DanhMucHangSanXuat Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
