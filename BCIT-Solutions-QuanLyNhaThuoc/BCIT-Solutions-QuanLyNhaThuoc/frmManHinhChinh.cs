using DevExpress.XtraBars;
using DevExpress.XtraTab;
using System.Windows.Forms;
using Systemb;
using Systemt;



namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class frmManHinhChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
        }

        NguoiDungDTO nguoiDungDTO = new NguoiDungDTO();           

        private bool KiemTraSuTonTaiForm (Form form)
        {
            foreach (var child in MdiChildren)
            {
                if(child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        #region Menu hệ thống
        void form_thoatChuongTrinh()
        {
            this.Close();
        }
        private void bbiThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn thoát khỏi chương trình?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void bbiDangNhapLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            nguoiDungDTO = new NguoiDungDTO();
            this.bsiTenNguoiDung.Caption = "";
            this.ribbon.Visible = false;
            xtraTabbedMdiManager.ClosePageButtonShowMode = ClosePageButtonShowMode.Default;
            var form = new fDangNhap();
            form.LoginEvent += form_LoginEvent;
            form.thoatChuongTrinh += form_thoatChuongTrinh;
            form.MdiParent = this;
            form.Show();

        }
        void form_LoginEvent(string tenDangNhap)
        {
            this.ribbon.Visible = true;

            NguoiDungBUS nguoiDungBUS = new NguoiDungBUS();
            nguoiDungDTO = nguoiDungBUS.LayThongTinNguoiDungByMa(tenDangNhap);
            this.bsiTenNguoiDung.Caption = nguoiDungDTO.TenNguoiDung.ToString();
        }
        private void bbiChucDanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucChucDanh();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void bbiNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucNguoiDung();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        private void bbiPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucPhanQuyen();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        private void bbiPhanHe_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucPhanHe();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        private void bbiChucNang_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucChucNang();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();

        }
        private void bbiThongTinCaNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fThongTinCaNhan(nguoiDungDTO);
            if (KiemTraSuTonTaiForm(form)) return;              
            form.MdiParent = this;
            form.Show();
        }

        #endregion Menu hệ thống

        #region Menu danh mục

        private void bbiDsBacSy_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucBacSy();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        private void bbiDsNhomKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucNhomKhachHang();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        private void bbiHangSanXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucHangSanXuat();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        private void bbiNoiSanXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucNoiSanXuat();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        private void bbiDsNhomHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucNhomHangHoa();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        } 
        private void bbiDsLoaiHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucLoaiHangHoa();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        private void bbiDonViTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucDonViTinh();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void bbiDsKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucKhachHang();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        private void bbiNhomNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucNhomNhaCungCap();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void bbiNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucNhaCungCap();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
        private void bbiHoatChatChinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucHoatChatChinh();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void bbiViTri_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucViTri();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void bbiDsHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new fDanhMucHangHoa();
            if (KiemTraSuTonTaiForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }  

        #endregion Menu danh mục

        private void frmManHinhChinh_Load(object sender, System.EventArgs e)
        {   
            /*
            this.ribbon.Visible = false;
            xtraTabbedMdiManager.ClosePageButtonShowMode = ClosePageButtonShowMode.Default;
            var form = new fDangNhap();
            form.LoginEvent += form_LoginEvent;
            form.thoatChuongTrinh += form_thoatChuongTrinh;
            form.MdiParent = this;
            form.Show();            
            */
        }

                                                  
    }
}