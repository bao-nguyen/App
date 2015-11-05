using System;
using System.ComponentModel;
using System.Data.OleDb;
using Systemt;

namespace Systemd
{
    public class HangHoaDAO
    {
        public BindingList<HangHoaDTO> LayDanhSach()
        {
            BindingList<HangHoaDTO> danhSach = new BindingList<HangHoaDTO>();
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;
            strSQL = "Select * From DanhMucHangHoa";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                HangHoaDTO itemDTO = new HangHoaDTO();

                itemDTO.Id = (int)dr["Id"];
                itemDTO.MaHangHoa = (string)dr["MaHangHoa"];
                itemDTO.TenHangHoa = (string)dr["TenHangHoa"];
                itemDTO.IdHoatChatChinh = (int)dr["IdHoatChatChinh"];
                itemDTO.IdNhomHangHoa = (int)dr["IdNhomHangHoa"];
                itemDTO.IdLoaiHangHoa = (int)dr["IdLoaiHangHoa"];
                itemDTO.IdHangSanXuat = (int)dr["IdHangSanXuat"];
                itemDTO.IdNoiSanXuat = (int)dr["IdNoiSanXuat"];
                itemDTO.IdViTri = (int)dr["IdViTri"];
                itemDTO.SoDangKy = (string)dr["SoDangKy"];
                itemDTO.IdDonViTinh = (int)dr["IdDonViTinh"];
                itemDTO.GiaNhap = (double)dr["GiaNhap"];
                itemDTO.TyLeChietKhau = (double)dr["TyLeChietKhau"];
                itemDTO.VAT = (double)dr["VAT"];
                itemDTO.IdDonViQuyDoi1 = (int)dr["IdDonViQuyDoi1"];
                itemDTO.TyLeQuyDoi1 = (int)dr["TyLeQuyDoi1"];
                itemDTO.GiaQuyDoi1 = (double)dr["GiaQuyDoi1"];
                itemDTO.GiaDeXuat1 = (double)dr["GiaDeXuat1"];
                itemDTO.IdDonViQuyDoi2 = (int)dr["IdDonViQuyDoi2"];
                itemDTO.TyLeQuyDoi2 = (int)dr["TyLeQuyDoi2"];
                itemDTO.GiaQuyDoi2 = (double)dr["GiaQuyDoi2"];
                itemDTO.GiaDeXuat2 = (double)dr["GiaDeXuat2"];
                itemDTO.NhietDoBaoQuan = (string)dr["NhietDoBaoQuan"];
                itemDTO.AnhSangBaoQuan = (string)dr["AnhSangBaoQuan"];
                itemDTO.DoAmBaoQuan = (string)dr["DoAmBaoQuan"];
                itemDTO.QuanLyKho = (bool)dr["QuanLyKho"];

                danhSach.Add(itemDTO);
            }
            return danhSach;
        }

        public void Them(HangHoaDTO itemDTO)
        {
            OleDbConnection cn;
            cn = DataProvider.KetNoi();
            string strSQL;

            strSQL = "Insert into DanhMucHangHoa (MaHangHoa, TenHangHoa, IdHoatChatChinh, IdNhomHangHoa, IdLoaiHangHoa, IdHangSanXuat, IdNoiSanXuat, IdViTri, SoDangKy, IdDonViTinh, GiaNhap, TyLeChietKhau, VAT, IdDonViQuyDoi1, TyLeQuyDoi1, GiaQuyDoi1, GiaDeXuat1, IdDonViQuyDoi2, TyLeQuyDoi2, GiaQuyDoi2, GiaDeXuat2, NhietDoBaoQuan, AnhSangBaoQuan, DoAmBaoQuan, QuanLyKho) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@MaHangHoa", OleDbType.WChar).Value = itemDTO.MaHangHoa;
            cmd.Parameters.Add("@TenHangHoa", OleDbType.WChar).Value = itemDTO.TenHangHoa;
            cmd.Parameters.Add("@IdHoatChatChinh", OleDbType.Integer).Value = itemDTO.IdHoatChatChinh;
            cmd.Parameters.Add("@IdNhomHangHoa", OleDbType.Integer).Value = itemDTO.IdNhomHangHoa;
            cmd.Parameters.Add("@IdLoaiHangHoa", OleDbType.Integer).Value = itemDTO.IdLoaiHangHoa;
            cmd.Parameters.Add("@IdHangSanXuat", OleDbType.Integer).Value = itemDTO.IdHangSanXuat;
            cmd.Parameters.Add("@IdNoiSanXuat", OleDbType.Integer).Value = itemDTO.IdNoiSanXuat;
            cmd.Parameters.Add("@IdViTri", OleDbType.Integer).Value = itemDTO.IdViTri;
            cmd.Parameters.Add("@SoDangKy", OleDbType.WChar).Value = itemDTO.SoDangKy;
            cmd.Parameters.Add("@IdDonViTinh", OleDbType.Integer).Value = itemDTO.IdDonViTinh;
            cmd.Parameters.Add("@GiaNhap", OleDbType.Double).Value = itemDTO.GiaNhap;
            cmd.Parameters.Add("@TyLeChietKhau", OleDbType.Double).Value = itemDTO.TyLeChietKhau;
            cmd.Parameters.Add("@VAT", OleDbType.Double).Value = itemDTO.VAT;
            cmd.Parameters.Add("@IdDonViQuyDoi1", OleDbType.Integer).Value = itemDTO.IdDonViQuyDoi1;
            cmd.Parameters.Add("@TyLeQuyDoi1", OleDbType.Integer).Value = itemDTO.TyLeQuyDoi1;
            cmd.Parameters.Add("@GiaQuyDoi1", OleDbType.Double).Value = itemDTO.GiaQuyDoi1;
            cmd.Parameters.Add("@GiaDeXuat1", OleDbType.Double).Value = itemDTO.GiaDeXuat1;
            cmd.Parameters.Add("@IdDonViQuyDoi2", OleDbType.Integer).Value = itemDTO.IdDonViQuyDoi2;
            cmd.Parameters.Add("@TyLeQuyDoi2", OleDbType.Integer).Value = itemDTO.TyLeQuyDoi2;
            cmd.Parameters.Add("@GiaQuyDoi2", OleDbType.Double).Value = itemDTO.GiaQuyDoi2;
            cmd.Parameters.Add("@GiaDeXuat2", OleDbType.Double).Value = itemDTO.GiaDeXuat2;
            cmd.Parameters.Add("@NhietDoBaoQuan", OleDbType.WChar).Value = itemDTO.NhietDoBaoQuan;
            cmd.Parameters.Add("@AnhSangBaoQuan", OleDbType.WChar).Value = itemDTO.AnhSangBaoQuan;
            cmd.Parameters.Add("@DoAmBaoQuan", OleDbType.WChar).Value = itemDTO.DoAmBaoQuan;
            cmd.Parameters.Add("@QuanLyKho", OleDbType.Boolean).Value = itemDTO.QuanLyKho;

            cmd.ExecuteNonQuery();

            cn.Close();
        }

        public void Sua(HangHoaDTO itemDTO)
        {

            OleDbConnection cn;
            cn = DataProvider.KetNoi();

            string strSQL;
            strSQL = "Update DanhMucHangHoa Set MaHangHoa = ?, TenHangHoa = ?, IdHoatChatChinh = ?, IdNhomHangHoa = ?, IdLoaiHangHoa = ?, IdHangSanXuat = ?, IdNoiSanXuat = ?, IdViTri = ?, SoDangKy = ?, IdDonViTinh = ?, GiaNhap = ?, TyLeChietKhau = ?, VAT = ?, IdDonViQuyDoi1 = ?, TyLeQuyDoi1 = ?, GiaQuyDoi1 = ?, GiaDeXuat1 = ?, IdDonViQuyDoi2 = ?, TyLeQuyDoi2 = ?, GiaQuyDoi2 = ?, GiaDeXuat2 = ?, NhietDoBaoQuan = ?, AnhSangBaoQuan = ?, DoAmBaoQuan = ?, QuanLyKho = ? Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@MaHangHoa", OleDbType.WChar).Value = itemDTO.MaHangHoa;
            cmd.Parameters.Add("@TenHangHoa", OleDbType.WChar).Value = itemDTO.TenHangHoa;
            cmd.Parameters.Add("@IdHoatChatChinh", OleDbType.Integer).Value = itemDTO.IdHoatChatChinh;
            cmd.Parameters.Add("@IdNhomHangHoa", OleDbType.Integer).Value = itemDTO.IdNhomHangHoa;
            cmd.Parameters.Add("@IdLoaiHangHoa", OleDbType.Integer).Value = itemDTO.IdLoaiHangHoa;
            cmd.Parameters.Add("@IdHangSanXuat", OleDbType.Integer).Value = itemDTO.IdHangSanXuat;
            cmd.Parameters.Add("@IdNoiSanXuat", OleDbType.Integer).Value = itemDTO.IdNoiSanXuat;
            cmd.Parameters.Add("@IdViTri", OleDbType.Integer).Value = itemDTO.IdViTri;
            cmd.Parameters.Add("@SoDangKy", OleDbType.WChar).Value = itemDTO.SoDangKy;
            cmd.Parameters.Add("@IdDonViTinh", OleDbType.Integer).Value = itemDTO.IdDonViTinh;
            cmd.Parameters.Add("@GiaNhap", OleDbType.Double).Value = itemDTO.GiaNhap;
            cmd.Parameters.Add("@TyLeChietKhau", OleDbType.Integer).Value = itemDTO.TyLeChietKhau;
            cmd.Parameters.Add("@VAT", OleDbType.Double).Value = itemDTO.VAT;
            cmd.Parameters.Add("@IdDonViQuyDoi1", OleDbType.Integer).Value = itemDTO.IdDonViQuyDoi1;
            cmd.Parameters.Add("@TyLeQuyDoi1", OleDbType.Integer).Value = itemDTO.TyLeQuyDoi1;
            cmd.Parameters.Add("@GiaQuyDoi1", OleDbType.Double).Value = itemDTO.GiaQuyDoi1;
            cmd.Parameters.Add("@GiaDeXuat1", OleDbType.Double).Value = itemDTO.GiaDeXuat1;
            cmd.Parameters.Add("@IdDonViQuyDoi2", OleDbType.Integer).Value = itemDTO.IdDonViQuyDoi2;
            cmd.Parameters.Add("@TyLeQuyDoi2", OleDbType.Integer).Value = itemDTO.TyLeQuyDoi2;
            cmd.Parameters.Add("@GiaQuyDoi2", OleDbType.Double).Value = itemDTO.GiaQuyDoi2;
            cmd.Parameters.Add("@GiaDeXuat2", OleDbType.Double).Value = itemDTO.GiaDeXuat2;
            cmd.Parameters.Add("@NhietDoBaoQuan", OleDbType.WChar).Value = itemDTO.NhietDoBaoQuan;
            cmd.Parameters.Add("@AnhSangBaoQuan", OleDbType.WChar).Value = itemDTO.AnhSangBaoQuan;
            cmd.Parameters.Add("@DoAmBaoQuan", OleDbType.WChar).Value = itemDTO.DoAmBaoQuan;
            cmd.Parameters.Add("@QuanLyKho", OleDbType.Boolean).Value = itemDTO.QuanLyKho;
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = itemDTO.Id;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void Xoa(int ma)
        {
            OleDbConnection cn;
            cn = DataProvider.KetNoi();

            string strSQL;
            strSQL = "DELETE FROM DanhMucHangHoa Where Id = ?";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Id", OleDbType.Numeric).Value = ma;
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
