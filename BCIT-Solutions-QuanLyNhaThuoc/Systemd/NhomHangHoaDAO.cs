using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class NhomHangHoaDAO
    {       
        public BindingList<NhomHangHoaDTO> LayDanhSach()
        {
            BindingList<NhomHangHoaDTO> danhSach = new BindingList<NhomHangHoaDTO>();            
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From DanhMucNhomHangHoa";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhomHangHoaDTO itemDTO = new NhomHangHoaDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaNhomHangHoa = (string)dr["MaNhomHangHoa"];
                itemDTO.TenNhomHangHoa = (string)dr["TenNhomHangHoa"];
                itemDTO.GhiChu = (string)dr["GhiChu"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }
        public void Them(NhomHangHoaDTO itemDTO)
        {
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            
            string strSQL;
            
            strSQL = "Insert into DanhMucNhomHangHoa (MaNhomHangHoa,TenNhomHangHoa,GhiChu) values (?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@MaNhomHangHoa", OleDbType.WChar).Value = itemDTO.MaNhomHangHoa;
            cmd.Parameters.Add("@TenNhomHangHoa", OleDbType.WChar).Value = itemDTO.TenNhomHangHoa;            
            cmd.Parameters.Add("@GhiChu", OleDbType.WChar).Value = itemDTO.GhiChu;                      
            
                cmd.ExecuteNonQuery();
            
            cn.Close();
        }
        public void Sua(NhomHangHoaDTO itemDTO)
        {
            
            OleDbConnection cn;            
            cn = DataProvider.KetNoi();            

            string strSQL;            
            strSQL = "Update DanhMucNhomHangHoa Set MaNhomHangHoa = ?, TenNhomHangHoa = ?, GhiChu = ? Where Id = ?";
                        
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaBacSy", OleDbType.WChar).Value = itemDTO.MaNhomHangHoa;
            cmd.Parameters.Add("@TenBacSy", OleDbType.WChar).Value = itemDTO.TenNhomHangHoa;            
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
            strSQL = "DELETE FROM DanhMucNhomHangHoa Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
