using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucNhomKhachHang : Form
    {
        
        public fDanhMucNhomKhachHang()
        {
            InitializeComponent();
        }
        bool flagThem = false;
        private void LayDanhSachNhomKhachHang()
        {

            NhomKhachHangBUS itemBUS = new NhomKhachHangBUS();
            BindingList<NhomKhachHangDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucNhomKhachHang.DataSource = danhSach;
        }
        private void fDanhMucNhomKhachHang_Load(object sender, EventArgs e)
        {
            this.LayDanhSachNhomKhachHang();
        }
        private void gvDanhMucNhomKhachHang_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucNhomKhachHang.FocusedRowHandle > -1)
            {
                try
                {
                    NhomKhachHangDTO itemDTO = new NhomKhachHangDTO();
                    NhomKhachHangBUS itemBUS = new NhomKhachHangBUS();
                    itemDTO.MaNhomKhachHang = gvDanhMucNhomKhachHang.GetFocusedRowCellValue("MaNhomKhachHang").ToString();
                    itemDTO.TenNhomKhachHang = gvDanhMucNhomKhachHang.GetFocusedRowCellValue("TenNhomKhachHang").ToString();
                    itemDTO.PhanTramLoiNhuan = double.Parse(gvDanhMucNhomKhachHang.GetFocusedRowCellValue("PhanTramLoiNhuan").ToString());
                    itemDTO.GhiChu = gvDanhMucNhomKhachHang.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.Id = int.Parse(gvDanhMucNhomKhachHang.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucNhomKhachHang.FocusedRowHandle == gvDanhMucNhomKhachHang.RowCount - 2)
                    {
                        if (itemDTO.MaNhomKhachHang.Length > 0)
                        {
                            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn thêm mới?", "Thêm mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (hopThoai == DialogResult.Yes)
                            {
                                itemBUS.Them(itemDTO);
                                this.flagThem = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa nhập mã!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn cập nhật?", "Cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (hopThoai == DialogResult.Yes)
                        {
                            itemBUS.Sua(itemDTO);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.LayDanhSachNhomKhachHang();
            }
        }
        private void gvDanhMucNhomKhachHang_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                NhomKhachHangBUS itemBUS = new NhomKhachHangBUS();
                for (int i = 0; i < gvDanhMucNhomKhachHang.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucNhomKhachHang.GetRowCellValue(gvDanhMucNhomKhachHang.GetSelectedRows()[i], gvDanhMucNhomKhachHang.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachNhomKhachHang();
        }
        private void gcDanhMucNhomKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    NhomKhachHangBUS itemBUS = new NhomKhachHangBUS();
                    for (int i = 0; i < gvDanhMucNhomKhachHang.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucNhomKhachHang.GetRowCellValue(gvDanhMucNhomKhachHang.GetSelectedRows()[i], gvDanhMucNhomKhachHang.Columns["Id"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachNhomKhachHang();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
