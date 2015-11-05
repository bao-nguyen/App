using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucChucNang : Form
    {
        public fDanhMucChucNang()
        {
            InitializeComponent();
        }
        bool flagThem = false;
        private void LayDanhSachChucNang()
        {

            ChucNangBUS itemBUS = new ChucNangBUS();
            BindingList<ChucNangDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucChucNang.DataSource = danhSach;

            PhanHeBUS phanHeBUS = new PhanHeBUS();
            BindingList<PhanHeDTO> dsPhanHe = phanHeBUS.LayDanhSach();

            RepositoryItemLookUpEdit comboPhanHe = new RepositoryItemLookUpEdit();
            comboPhanHe.DataSource = dsPhanHe;
            comboPhanHe.PopulateColumns();
            foreach (LookUpColumnInfo col in comboPhanHe.Columns)
            {
                if (col.FieldName == "Id")
                    col.Visible = false;
            }
            comboPhanHe.DisplayMember = "TenPhanHe";
            comboPhanHe.ValueMember = "Id";
            gvDanhMucChucNang.Columns["IdPhanHe"].ColumnEdit = comboPhanHe;


        }

        private void fDanhMucChucNang_Load(object sender, EventArgs e)
        {
            this.LayDanhSachChucNang();
        }

        private void gvDanhMucChucNang_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucChucNang.FocusedRowHandle > -1)
            {
                try
                {
                    ChucNangDTO itemDTO = new ChucNangDTO();
                    ChucNangBUS itemBUS = new ChucNangBUS();
                    

                    itemDTO.MaChucNang = gvDanhMucChucNang.GetFocusedRowCellValue("MaChucNang").ToString();
                    itemDTO.TenChucNang = gvDanhMucChucNang.GetFocusedRowCellValue("TenChucNang").ToString();
                    itemDTO.IdPhanHe = int.Parse(gvDanhMucChucNang.GetFocusedRowCellValue("IdPhanHe").ToString());                    
                    itemDTO.TenForm = gvDanhMucChucNang.GetFocusedRowCellValue("TenForm").ToString();
                    itemDTO.Id = int.Parse(gvDanhMucChucNang.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucChucNang.FocusedRowHandle == gvDanhMucChucNang.RowCount - 2)
                    {
                        if (itemDTO.MaChucNang.Length > 0)
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
                this.LayDanhSachChucNang();
            }
        }

        private void gvDanhMucChucNang_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }

        private void gvDanhMucChucNang_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                ChucNangBUS itemBUS = new ChucNangBUS();
                for (int i = 0; i < gvDanhMucChucNang.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucChucNang.GetRowCellValue(gvDanhMucChucNang.GetSelectedRows()[i], gvDanhMucChucNang.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachChucNang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
