using Systemt;


namespace Systemt
{
    public class HangHoaDTO
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string maHangHoa;

        public string MaHangHoa
        {
            get { return maHangHoa; }
            set { maHangHoa = value; }
        }
        private string tenHangHoa;

        public string TenHangHoa
        {
            get { return tenHangHoa; }
            set { tenHangHoa = value; }
        }
        private int idHoatChatChinh;

        public int IdHoatChatChinh
        {
            get { return idHoatChatChinh; }
            set { idHoatChatChinh = value; }
        }
        private int idNhomHangHoa;

        public int IdNhomHangHoa
        {
            get { return idNhomHangHoa; }
            set { idNhomHangHoa = value; }
        }
        private int idLoaiHangHoa;

        public int IdLoaiHangHoa
        {
            get { return idLoaiHangHoa; }
            set { idLoaiHangHoa = value; }
        }
        private int idHangSanXuat;

        public int IdHangSanXuat
        {
            get { return idHangSanXuat; }
            set { idHangSanXuat = value; }
        }
        private int idNoiSanXuat;

        public int IdNoiSanXuat
        {
            get { return idNoiSanXuat; }
            set { idNoiSanXuat = value; }
        }
        private int idViTri;

        public int IdViTri
        {
            get { return idViTri; }
            set { idViTri = value; }
        }
        private string soDangKy;

        public string SoDangKy
        {
            get { return soDangKy; }
            set { soDangKy = value; }
        }
        private int idDonViTinh;

        public int IdDonViTinh
        {
            get { return idDonViTinh; }
            set { idDonViTinh = value; }
        }
        private double giaNhap;

        public double GiaNhap
        {
            get { return giaNhap; }
            set { giaNhap = value; }
        }
        private double tyLeChietKhau;

        public double TyLeChietKhau
        {
            get { return tyLeChietKhau; }
            set { tyLeChietKhau = value; }
        }
        private double vAT;

        public double VAT
        {
            get { return vAT; }
            set { vAT = value; }
        }
        private int idDonViQuyDoi1;

        public int IdDonViQuyDoi1
        {
            get { return idDonViQuyDoi1; }
            set { idDonViQuyDoi1 = value; }
        }
        private int tyLeQuyDoi1;

        public int TyLeQuyDoi1
        {
            get { return tyLeQuyDoi1; }
            set { tyLeQuyDoi1 = value; }
        }
        private double giaQuyDoi1;

        public double GiaQuyDoi1
        {
            get { return giaQuyDoi1; }
            set { giaQuyDoi1 = value; }
        }
        private double giaDeXuat1;

        public double GiaDeXuat1
        {
            get { return giaDeXuat1; }
            set { giaDeXuat1 = value; }
        }
        private int idDonViQuyDoi2;

        public int IdDonViQuyDoi2
        {
            get { return idDonViQuyDoi2; }
            set { idDonViQuyDoi2 = value; }
        }
        private int tyLeQuyDoi2;

        public int TyLeQuyDoi2
        {
            get { return tyLeQuyDoi2; }
            set { tyLeQuyDoi2 = value; }
        }
        private double giaQuyDoi2;

        public double GiaQuyDoi2
        {
            get { return giaQuyDoi2; }
            set { giaQuyDoi2 = value; }
        }
        private double giaDeXuat2;

        public double GiaDeXuat2
        {
            get { return giaDeXuat2; }
            set { giaDeXuat2 = value; }
        }
        private string nhietDoBaoQuan;

        public string NhietDoBaoQuan
        {
            get { return nhietDoBaoQuan; }
            set { nhietDoBaoQuan = value; }
        }
        private string anhSangBaoQuan;

        public string AnhSangBaoQuan
        {
            get { return anhSangBaoQuan; }
            set { anhSangBaoQuan = value; }
        }

        private string doAmBaoQuan;

        public string DoAmBaoQuan
        {
            get { return doAmBaoQuan; }
            set { doAmBaoQuan = value; }
        }

        private bool quanLyKho;

        public bool QuanLyKho
        {
            get { return quanLyKho; }
            set { quanLyKho = value; }
        }

        public HangHoaDTO()
        {
            this.id = 0;
            this.maHangHoa = "";
            this.tenHangHoa = "";
            this.idHoatChatChinh = 0;
            this.idNhomHangHoa = 0;
            this.idLoaiHangHoa = 0;
            this.idHangSanXuat = 0;
            this.idNoiSanXuat = 0;
            this.idViTri = 0;
            this.soDangKy = "";
            this.idDonViTinh = 0;
            this.giaNhap = 0;
            this.tyLeChietKhau = 0;
            this.vAT = 0;                                       
            this.idDonViQuyDoi1 = 0;
            this.tyLeQuyDoi1 = 0;
            this.giaQuyDoi1 = 0;
            this.giaDeXuat1 = 0;
            this.idDonViQuyDoi2 = 0;
            this.tyLeQuyDoi2 = 0;
            this.giaQuyDoi2 = 0;
            this.giaDeXuat2 = 0;
            this.nhietDoBaoQuan = "";
            this.anhSangBaoQuan = "";
            this.doAmBaoQuan = "";
            this.quanLyKho = true;
            
        }
    }
}
