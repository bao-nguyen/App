using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucDonViTinh : Form
    {
        public fDanhMucDonViTinh()
        {
            InitializeComponent();
        }
        bool flagThem = false;
        private void LayDanhSachDonViTinh()
        {

            DonViTinhBUS itemBUS = new DonViTinhBUS();
            BindingList<DonViTinhDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucDonViTinh.DataSource = danhSach;
        }
        private void fDonViTinh_Load(object sender, EventArgs e)
        {
            this.LayDanhSachDonViTinh();
        }

        private void gvDanhMucDonViTinh_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {            
            if (gvDanhMucDonViTinh.FocusedRowHandle > -1)
            {
                try
                {
                    DonViTinhDTO itemDTO = new DonViTinhDTO();
                    DonViTinhBUS itemBUS = new DonViTinhBUS();
                    itemDTO.MaDonViTinh = gvDanhMucDonViTinh.GetFocusedRowCellValue("MaDonViTinh").ToString();
                    itemDTO.TenDonViTinh = gvDanhMucDonViTinh.GetFocusedRowCellValue("TenDonViTinh").ToString();
                    itemDTO.GhiChu = gvDanhMucDonViTinh.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.Id = int.Parse(gvDanhMucDonViTinh.GetFocusedRowCellValue("Id").ToString());
                    
                    if (this.flagThem && gvDanhMucDonViTinh.FocusedRowHandle == gvDanhMucDonViTinh.RowCount -2)
                    {
                        if (itemDTO.MaDonViTinh.Length > 0)
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
                this.LayDanhSachDonViTinh();
            }
        }

        private void gvDanhMucDonViTinh_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                DonViTinhBUS itemBUS = new DonViTinhBUS();
                for (int i = 0; i < gvDanhMucDonViTinh.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucDonViTinh.GetRowCellValue(gvDanhMucDonViTinh.GetSelectedRows()[i], gvDanhMucDonViTinh.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachDonViTinh();
        }

        private void gvDanhMucDonViTinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    DonViTinhBUS itemBUS = new DonViTinhBUS();
                    for (int i = 0; i < gvDanhMucDonViTinh.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucDonViTinh.GetRowCellValue(gvDanhMucDonViTinh.GetSelectedRows()[i], gvDanhMucDonViTinh.Columns["Id"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachDonViTinh();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
