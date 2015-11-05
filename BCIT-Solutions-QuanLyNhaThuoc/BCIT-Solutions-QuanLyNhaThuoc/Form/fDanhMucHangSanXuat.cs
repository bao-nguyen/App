using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucHangSanXuat : Form
    {
        public fDanhMucHangSanXuat()
        {
            InitializeComponent();
        }
        bool flagThem = false;
        private void LayDanhSachHangSanXuat()
        {

            HangSanXuatBUS itemBUS = new HangSanXuatBUS();
            BindingList<HangSanXuatDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucHangSanXuat.DataSource = danhSach;
        }

        private void gvDanhMucHangSanXuat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    HangSanXuatBUS itemBUS = new HangSanXuatBUS();
                    for (int i = 0; i < gvDanhMucHangSanXuat.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucHangSanXuat.GetRowCellValue(gvDanhMucHangSanXuat.GetSelectedRows()[i], gvDanhMucHangSanXuat.Columns["Id"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachHangSanXuat();
            }
        }

        private void gvDanhMucHangSanXuat_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucHangSanXuat.FocusedRowHandle > -1)
            {
                try
                {
                    HangSanXuatDTO itemDTO = new HangSanXuatDTO();
                    HangSanXuatBUS itemBUS = new HangSanXuatBUS();
                    itemDTO.MaHangSanXuat = gvDanhMucHangSanXuat.GetFocusedRowCellValue("MaHangSanXuat").ToString();
                    itemDTO.TenHangSanXuat = gvDanhMucHangSanXuat.GetFocusedRowCellValue("TenHangSanXuat").ToString();
                    itemDTO.GhiChu = gvDanhMucHangSanXuat.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.Id = int.Parse(gvDanhMucHangSanXuat.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucHangSanXuat.FocusedRowHandle == gvDanhMucHangSanXuat.RowCount - 2)
                    {
                        if (itemDTO.MaHangSanXuat.Length > 0)
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
                this.LayDanhSachHangSanXuat();
            }
        }

        private void gvDanhMucHangSanXuat_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                HangSanXuatBUS itemBUS = new HangSanXuatBUS();
                for (int i = 0; i < gvDanhMucHangSanXuat.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucHangSanXuat.GetRowCellValue(gvDanhMucHangSanXuat.GetSelectedRows()[i], gvDanhMucHangSanXuat.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachHangSanXuat();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanhMucHangSanXuat_Load(object sender, EventArgs e)
        {
            this.LayDanhSachHangSanXuat();
        }
    }
}
