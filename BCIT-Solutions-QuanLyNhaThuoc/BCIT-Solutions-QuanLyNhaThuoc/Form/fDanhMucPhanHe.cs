using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucPhanHe : Form
    {
        public fDanhMucPhanHe()
        {
            InitializeComponent();
        }

        bool flagThem = false;

        private void LayDanhSachPhanHe()
        {

            PhanHeBUS itemBUS = new PhanHeBUS();
            BindingList<PhanHeDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucPhanHe.DataSource = danhSach;
        }

        private void fDanhMucPhanHe_Load(object sender, EventArgs e)
        {
            this.LayDanhSachPhanHe();
        }

        private void gvDanhMucPhanHe_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucPhanHe.FocusedRowHandle > -1)
            {
                try
                {
                    PhanHeDTO itemDTO = new PhanHeDTO();
                    PhanHeBUS itemBUS = new PhanHeBUS();
                    itemDTO.MaPhanHe = gvDanhMucPhanHe.GetFocusedRowCellValue("MaPhanHe").ToString();
                    itemDTO.TenPhanHe = gvDanhMucPhanHe.GetFocusedRowCellValue("TenPhanHe").ToString();                    
                    itemDTO.Id = int.Parse(gvDanhMucPhanHe.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucPhanHe.FocusedRowHandle == gvDanhMucPhanHe.RowCount - 2)
                    {
                        if (itemDTO.MaPhanHe.Length > 0)
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
                this.LayDanhSachPhanHe();
            }
        }

        private void gvDanhMucPhanHe_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }

        private void gvDanhMucPhanHe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    NhomKhachHangBUS itemBUS = new NhomKhachHangBUS();
                    for (int i = 0; i < gvDanhMucPhanHe.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucPhanHe.GetRowCellValue(gvDanhMucPhanHe.GetSelectedRows()[i], gvDanhMucPhanHe.Columns["Id"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachPhanHe();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                PhanHeBUS itemBUS = new PhanHeBUS();
                for (int i = 0; i < gvDanhMucPhanHe.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucPhanHe.GetRowCellValue(gvDanhMucPhanHe.GetSelectedRows()[i], gvDanhMucPhanHe.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachPhanHe();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
