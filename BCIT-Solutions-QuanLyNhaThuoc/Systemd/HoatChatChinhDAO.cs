using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class HoatChatChinhDAO
    {       
        public BindingList<HoatChatChinhDTO> LayDanhSach()
        {
            BindingList<HoatChatChinhDTO> danhSach = new BindingList<HoatChatChinhDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From DanhMucHoatChatChinh";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                HoatChatChinhDTO itemDTO = new HoatChatChinhDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaHoatChatChinh = (string)dr["MaHoatChatChinh"];
                itemDTO.TenHoatChatChinh = (string)dr["TenHoatChatChinh"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(HoatChatChinhDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into DanhMucHoatChatChinh (MaHoatChatChinh,TenHoatChatChinh,GhiChu) values (?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@MaHoatChatChinh", OleDbType.WChar).Value = itemDTO.MaHoatChatChinh;
            cmd.Parameters.Add("@TenHoatChatChinh", OleDbType.WChar).Value = itemDTO.TenHoatChatChinh;            
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;                      
            
                cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(HoatChatChinhDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update DanhMucHoatChatChinh Set MaHoatChatChinh = ?, TenHoatChatChinh = ?, GhiChu = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaBacSy", OleDbType.WChar).Value = itemDTO.MaHoatChatChinh;
            cmd.Parameters.Add("@TenBacSy", OleDbType.WChar).Value = itemDTO.TenHoatChatChinh;            
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
            strSQL = "DELETE FROM DanhMucHoatChatChinh Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
