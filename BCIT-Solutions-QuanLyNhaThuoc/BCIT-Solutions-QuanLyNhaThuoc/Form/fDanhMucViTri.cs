using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucViTri : Form
    {
        public fDanhMucViTri()
        {
            InitializeComponent();
        }
        bool flagThem = false;
        private void LayDanhSachViTri()
        {

            ViTriBUS itemBUS = new ViTriBUS();
            BindingList<ViTriDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucViTri.DataSource = danhSach;
        }
        private void fDanhMucViTri_Load(object sender, EventArgs e)
        {
            this.LayDanhSachViTri();
        }

        private void gvDanhMucViTri_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucViTri.FocusedRowHandle > -1)
            {
                try
                {
                    ViTriDTO itemDTO = new ViTriDTO();
                    ViTriBUS itemBUS = new ViTriBUS();
                    itemDTO.MaViTri = gvDanhMucViTri.GetFocusedRowCellValue("MaViTri").ToString();
                    itemDTO.TenViTri = gvDanhMucViTri.GetFocusedRowCellValue("TenViTri").ToString();
                    itemDTO.GhiChu = gvDanhMucViTri.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.Id = int.Parse(gvDanhMucViTri.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucViTri.FocusedRowHandle == gvDanhMucViTri.RowCount - 2)
                    {
                        if (itemDTO.MaViTri.Length > 0)
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
                this.LayDanhSachViTri();
            }
        }

        private void gvDanhMucViTri_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }

        private void gvDanhMucViTri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    ViTriBUS itemBUS = new ViTriBUS();
                    for (int i = 0; i < gvDanhMucViTri.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucViTri.GetRowCellValue(gvDanhMucViTri.GetSelectedRows()[i], gvDanhMucViTri.Columns["Id"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachViTri();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                ViTriBUS itemBUS = new ViTriBUS();
                for (int i = 0; i < gvDanhMucViTri.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucViTri.GetRowCellValue(gvDanhMucViTri.GetSelectedRows()[i], gvDanhMucViTri.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachViTri();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
