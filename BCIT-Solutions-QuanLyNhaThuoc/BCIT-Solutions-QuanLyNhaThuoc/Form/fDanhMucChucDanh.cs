using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucChucDanh : Form
    {
        public fDanhMucChucDanh()
        {
            InitializeComponent();
        }

        bool flagThem = false;
        private void LayDanhSachChucDanh()
        {

            ChucDanhBUS itemBUS = new ChucDanhBUS();
            BindingList<ChucDanhDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucChucDanh.DataSource = danhSach;
        }

        private void fDanhMucChucDanh_Load(object sender, EventArgs e)
        {
            this.LayDanhSachChucDanh();
        }

        private void gvDanhMucChuDanh_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucChuDanh.FocusedRowHandle > -1)
            {
                try
                {
                    ChucDanhDTO itemDTO = new ChucDanhDTO();
                    ChucDanhBUS itemBUS = new ChucDanhBUS();
                    itemDTO.MaChucDanh = gvDanhMucChuDanh.GetFocusedRowCellValue("MaChucDanh").ToString();
                    itemDTO.TenChucDanh = gvDanhMucChuDanh.GetFocusedRowCellValue("TenChucDanh").ToString();
                    itemDTO.GhiChu = gvDanhMucChuDanh.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.Id = int.Parse(gvDanhMucChuDanh.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucChuDanh.FocusedRowHandle == gvDanhMucChuDanh.RowCount - 2)
                    {
                        if (itemDTO.MaChucDanh.Length > 0)
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
                this.LayDanhSachChucDanh();
            }
        }

        private void gvDanhMucChuDanh_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }

        private void gcDanhMucChucDanh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    ChucDanhBUS itemBUS = new ChucDanhBUS();
                    for (int i = 0; i < gvDanhMucChuDanh.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucChuDanh.GetRowCellValue(gvDanhMucChuDanh.GetSelectedRows()[i], gvDanhMucChuDanh.Columns["Id"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachChucDanh();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                ChucDanhBUS itemBUS = new ChucDanhBUS();
                for (int i = 0; i < gvDanhMucChuDanh.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucChuDanh.GetRowCellValue(gvDanhMucChuDanh.GetSelectedRows()[i], gvDanhMucChuDanh.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachChucDanh();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
