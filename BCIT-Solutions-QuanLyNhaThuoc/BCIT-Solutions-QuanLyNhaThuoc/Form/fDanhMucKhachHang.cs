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
    public partial class fDanhMucKhachHang : Form
    {
        public fDanhMucKhachHang()
        {
            InitializeComponent();
        }

        bool flagThem = false;

        private void LayDanhSachKhachHang()
        {

            KhachHangBUS itemBUS = new KhachHangBUS();
            BindingList<KhachHangDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucKhachHang.DataSource = danhSach;

            NhomKhachHangBUS nhomKhachHangBUS = new NhomKhachHangBUS();
            BindingList<NhomKhachHangDTO> dsNhomKhachHang = nhomKhachHangBUS.LayDanhSach();

            RepositoryItemLookUpEdit repositoryItem = new RepositoryItemLookUpEdit();
            repositoryItem.DataSource = dsNhomKhachHang;
            repositoryItem.PopulateColumns();
            foreach (LookUpColumnInfo col in repositoryItem.Columns)
            {
                if (col.FieldName == "Id" || col.FieldName == "GhiChu")
                    col.Visible = false;
            }
            repositoryItem.DisplayMember = "TenNhomKhachHang";
            repositoryItem.ValueMember = "Id";
            gvDanhMucKhachHang.Columns["IdNhomKhachHang"].ColumnEdit = repositoryItem;

        }
        private void fDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            this.LayDanhSachKhachHang();
        }

        private void gvDanhMucKhachHang_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucKhachHang.FocusedRowHandle > -1)
            {
                try
                {
                    KhachHangDTO itemDTO = new KhachHangDTO();
                    KhachHangBUS itemBUS = new KhachHangBUS();
                    MD5 maHoa = new MD5();

                    itemDTO.MaKhachHang = gvDanhMucKhachHang.GetFocusedRowCellValue("MaKhachHang").ToString();
                    itemDTO.HoKhachHang = gvDanhMucKhachHang.GetFocusedRowCellValue("HoKhachHang").ToString();
                    itemDTO.TenKhachHang = gvDanhMucKhachHang.GetFocusedRowCellValue("TenKhachHang").ToString();                    
                    itemDTO.IdNhomKhachHang = int.Parse(gvDanhMucKhachHang.GetFocusedRowCellValue("IdNhomKhachHang").ToString());
                    itemDTO.DiaChi = gvDanhMucKhachHang.GetFocusedRowCellValue("DiaChi").ToString();
                    itemDTO.DienThoai = gvDanhMucKhachHang.GetFocusedRowCellValue("DienThoai").ToString();
                    itemDTO.NgaySinh = DateTime.Parse(gvDanhMucKhachHang.GetFocusedRowCellValue("NgaySinh").ToString());
                    itemDTO.Email = gvDanhMucKhachHang.GetFocusedRowCellValue("Email").ToString();
                    itemDTO.GhiChu = gvDanhMucKhachHang.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.Id = int.Parse(gvDanhMucKhachHang.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucKhachHang.FocusedRowHandle == gvDanhMucKhachHang.RowCount - 2)
                    {
                        if (itemDTO.MaKhachHang.Length > 0)
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
                this.LayDanhSachKhachHang();
            }
        }

        private void gvDanhMucKhachHang_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }

        private void gvDanhMucKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    KhachHangBUS itemBUS = new KhachHangBUS();
                    for (int i = 0; i < gvDanhMucKhachHang.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucKhachHang.GetRowCellValue(gvDanhMucKhachHang.GetSelectedRows()[i], gvDanhMucKhachHang.Columns["Id"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachKhachHang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                KhachHangBUS itemBUS = new KhachHangBUS();
                for (int i = 0; i < gvDanhMucKhachHang.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucKhachHang.GetRowCellValue(gvDanhMucKhachHang.GetSelectedRows()[i], gvDanhMucKhachHang.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachKhachHang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
