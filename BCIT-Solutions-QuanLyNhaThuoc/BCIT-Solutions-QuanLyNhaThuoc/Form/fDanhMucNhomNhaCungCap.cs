using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucNhomNhaCungCap : Form
    {
        public fDanhMucNhomNhaCungCap()
        {
            InitializeComponent();
        }
        bool flagThem = false;
        private void LayDanhSachNhomNhaCungCap()
        {

            NhomNhaCungCapBUS itemBUS = new NhomNhaCungCapBUS();
            BindingList<NhomNhaCungCapDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucNhomNhaCungCap.DataSource = danhSach;
        }
        private void fDanhMucNhomNhaCungCap_Load(object sender, EventArgs e)
        {
            this.LayDanhSachNhomNhaCungCap();
        }

        private void gvDanhMucNhomNhaCungCap_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucNhomNhaCungCap.FocusedRowHandle > -1)
            {
                try
                {
                    NhomNhaCungCapDTO itemDTO = new NhomNhaCungCapDTO();
                    NhomNhaCungCapBUS itemBUS = new NhomNhaCungCapBUS();
                    itemDTO.MaNhomNhaCungCap = gvDanhMucNhomNhaCungCap.GetFocusedRowCellValue("MaNhomNhaCungCap").ToString();
                    itemDTO.TenNhomNhaCungCap = gvDanhMucNhomNhaCungCap.GetFocusedRowCellValue("TenNhomNhaCungCap").ToString();
                    itemDTO.GhiChu = gvDanhMucNhomNhaCungCap.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.Id = int.Parse(gvDanhMucNhomNhaCungCap.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucNhomNhaCungCap.FocusedRowHandle == gvDanhMucNhomNhaCungCap.RowCount - 2)
                    {
                        if (itemDTO.MaNhomNhaCungCap.Length > 0)
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
                this.LayDanhSachNhomNhaCungCap();
            }
        }

        private void gvDanhMucNhomNhaCungCap_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }

        private void gvDanhMucNhomNhaCungCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    NhomNhaCungCapBUS itemBUS = new NhomNhaCungCapBUS();
                    for (int i = 0; i < gvDanhMucNhomNhaCungCap.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucNhomNhaCungCap.GetRowCellValue(gvDanhMucNhomNhaCungCap.GetSelectedRows()[i], gvDanhMucNhomNhaCungCap.Columns["Id"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachNhomNhaCungCap();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                NhomNhaCungCapBUS itemBUS = new NhomNhaCungCapBUS();
                for (int i = 0; i < gvDanhMucNhomNhaCungCap.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucNhomNhaCungCap.GetRowCellValue(gvDanhMucNhomNhaCungCap.GetSelectedRows()[i], gvDanhMucNhomNhaCungCap.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachNhomNhaCungCap();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
