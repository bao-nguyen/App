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
    public partial class fDanhMucNguoiDung : Form
    {
        public fDanhMucNguoiDung()
        {
            InitializeComponent();
        }

        bool flagThem = false;

        private void LayDanhSachNguoiDung()
        {

            NguoiDungBUS itemBUS = new NguoiDungBUS();
            BindingList<NguoiDungDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucNguoiDung.DataSource = danhSach;
            
            ChucDanhBUS chucDanhBUS = new ChucDanhBUS();
            BindingList<ChucDanhDTO> dsChucDanh = chucDanhBUS.LayDanhSach();
            
            RepositoryItemLookUpEdit repositoryItem = new RepositoryItemLookUpEdit();
            repositoryItem.DataSource = dsChucDanh;
            repositoryItem.PopulateColumns();            
            foreach (LookUpColumnInfo col in repositoryItem.Columns)
            {
                if (col.FieldName == "Id" || col.FieldName == "GhiChu")
                    col.Visible = false;               
            }
            repositoryItem.DisplayMember = "TenChucDanh";
            repositoryItem.ValueMember = "Id";            
            gvDanhMucNguoiDung.Columns["IdChucDanh"].ColumnEdit = repositoryItem;
                         
        }

        private void fDanhMucNguoiDung_Load(object sender, EventArgs e)
        {
            this.LayDanhSachNguoiDung();
        }

        private void gvDanhMucNguoiDung_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucNguoiDung.FocusedRowHandle > -1)
            {
                try
                {
                    NguoiDungDTO itemDTO = new NguoiDungDTO();
                    NguoiDungBUS itemBUS = new NguoiDungBUS();
                    MD5 maHoa = new MD5();                    

                    itemDTO.MaNguoiDung = gvDanhMucNguoiDung.GetFocusedRowCellValue("MaNguoiDung").ToString();
                    itemDTO.TenNguoiDung = gvDanhMucNguoiDung.GetFocusedRowCellValue("TenNguoiDung").ToString();
                    itemDTO.MatKhau = maHoa.md5(gvDanhMucNguoiDung.GetFocusedRowCellValue("MatKhau").ToString());
                    itemDTO.VoHieu = bool.Parse(gvDanhMucNguoiDung.GetFocusedRowCellValue("VoHieu").ToString());
                    itemDTO.IdChucDanh = int.Parse(gvDanhMucNguoiDung.GetFocusedRowCellValue("IdChucDanh").ToString());
                    itemDTO.DiaChi = gvDanhMucNguoiDung.GetFocusedRowCellValue("DiaChi").ToString();
                    itemDTO.DienThoai = gvDanhMucNguoiDung.GetFocusedRowCellValue("DienThoai").ToString();
                    itemDTO.NgayBatDau = DateTime.Parse(gvDanhMucNguoiDung.GetFocusedRowCellValue("NgayBatDau").ToString());
                    itemDTO.NgayKetThuc = DateTime.Parse(gvDanhMucNguoiDung.GetFocusedRowCellValue("NgayKetThuc").ToString());
                    itemDTO.GhiChu = gvDanhMucNguoiDung.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.Id = int.Parse(gvDanhMucNguoiDung.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucNguoiDung.FocusedRowHandle == gvDanhMucNguoiDung.RowCount - 2)
                    {
                        if (itemDTO.MaNguoiDung.Length > 0)
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
                this.LayDanhSachNguoiDung();
            }
        }

        private void gvDanhMucNguoiDung_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                NguoiDungBUS itemBUS = new NguoiDungBUS();
                for (int i = 0; i < gvDanhMucNguoiDung.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucNguoiDung.GetRowCellValue(gvDanhMucNguoiDung.GetSelectedRows()[i], gvDanhMucNguoiDung.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachNguoiDung();
        }

        private void gcDanhMucNguoiDung_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    NguoiDungBUS itemBUS = new NguoiDungBUS();
                    for (int i = 0; i < gvDanhMucNguoiDung.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucNguoiDung.GetRowCellValue(gvDanhMucNguoiDung.GetSelectedRows()[i], gvDanhMucNguoiDung.Columns["Id"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachNguoiDung();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
