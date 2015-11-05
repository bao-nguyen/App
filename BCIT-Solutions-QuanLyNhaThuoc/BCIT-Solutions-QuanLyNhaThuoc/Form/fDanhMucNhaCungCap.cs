using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using SystemFunctions;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucNhaCungCap : Form
    {
        public fDanhMucNhaCungCap()
        {
            InitializeComponent();
        }
        bool flagThem = false;

        private void LayDanhSachNhaCungCap()
        {

            NhaCungCapBUS itemBUS = new NhaCungCapBUS();
            BindingList<NhaCungCapDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucNhaCungCap.DataSource = danhSach;

            NhomNhaCungCapBUS nhomNhaCungCapBUS = new NhomNhaCungCapBUS();
            BindingList<NhomNhaCungCapDTO> dsNhomNhaCungCap = nhomNhaCungCapBUS.LayDanhSach();

            RepositoryItemLookUpEdit repositoryItem = new RepositoryItemLookUpEdit();
            repositoryItem.DataSource = dsNhomNhaCungCap;
            repositoryItem.PopulateColumns();
            foreach (LookUpColumnInfo col in repositoryItem.Columns)
            {
                if (col.FieldName == "Id" || col.FieldName == "GhiChu")
                    col.Visible = false;
            }
            repositoryItem.DisplayMember = "TenNhomNhaCungCap";
            repositoryItem.ValueMember = "Id";
            gvDanhMucNhaCungCap.Columns["IdNhomNhaCungCap"].ColumnEdit = repositoryItem;

        }
        private void fDanhMucNhaCungCap_Load(object sender, EventArgs e)
        {
            this.LayDanhSachNhaCungCap();
        }

        private void gvDanhMucNhaCungCap_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucNhaCungCap.FocusedRowHandle > -1)
            {
                try
                {
                    NhaCungCapDTO itemDTO = new NhaCungCapDTO();
                    NhaCungCapBUS itemBUS = new NhaCungCapBUS();                    

                    itemDTO.MaNhaCungCap = gvDanhMucNhaCungCap.GetFocusedRowCellValue("MaNhaCungCap").ToString();                    
                    itemDTO.TenNhaCungCap = gvDanhMucNhaCungCap.GetFocusedRowCellValue("TenNhaCungCap").ToString();
                    itemDTO.IdNhomNhaCungCap = int.Parse(gvDanhMucNhaCungCap.GetFocusedRowCellValue("IdNhomNhaCungCap").ToString());
                    itemDTO.DiaChi = gvDanhMucNhaCungCap.GetFocusedRowCellValue("DiaChi").ToString();
                    itemDTO.DienThoai = gvDanhMucNhaCungCap.GetFocusedRowCellValue("DienThoai").ToString();                    
                    itemDTO.Email = gvDanhMucNhaCungCap.GetFocusedRowCellValue("Email").ToString();
                    itemDTO.SoTaiKhoan = gvDanhMucNhaCungCap.GetFocusedRowCellValue("SoTaiKhoan").ToString();
                    itemDTO.TenNganHang = gvDanhMucNhaCungCap.GetFocusedRowCellValue("TenNganHang").ToString();
                    itemDTO.TenChiNhanh = gvDanhMucNhaCungCap.GetFocusedRowCellValue("TenChiNhanh").ToString();
                    itemDTO.GhiChu = gvDanhMucNhaCungCap.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.Id = int.Parse(gvDanhMucNhaCungCap.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucNhaCungCap.FocusedRowHandle == gvDanhMucNhaCungCap.RowCount - 2)
                    {
                        if (itemDTO.MaNhaCungCap.Length > 0)
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
                this.LayDanhSachNhaCungCap();
            }
        }

        private void gvDanhMucNhaCungCap_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }

        private void gvDanhMucNhaCungCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    NhaCungCapBUS itemBUS = new NhaCungCapBUS();
                    for (int i = 0; i < gvDanhMucNhaCungCap.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucNhaCungCap.GetRowCellValue(gvDanhMucNhaCungCap.GetSelectedRows()[i], gvDanhMucNhaCungCap.Columns["Id"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachNhaCungCap();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                NhaCungCapBUS itemBUS = new NhaCungCapBUS();
                for (int i = 0; i < gvDanhMucNhaCungCap.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucNhaCungCap.GetRowCellValue(gvDanhMucNhaCungCap.GetSelectedRows()[i], gvDanhMucNhaCungCap.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachNhaCungCap();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
