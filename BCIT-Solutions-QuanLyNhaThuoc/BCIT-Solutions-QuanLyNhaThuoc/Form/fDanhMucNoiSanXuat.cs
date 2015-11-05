using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucNoiSanXuat : Form
    {
        public fDanhMucNoiSanXuat()
        {
            InitializeComponent();
        }
        bool flagThem = false;
        private void LayDanhSachNoiSanXuat()
        {

            NoiSanXuatBUS itemBUS = new NoiSanXuatBUS();
            BindingList<NoiSanXuatDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucNoiSanXuat.DataSource = danhSach;
        }        
        private void fDanhMucNoiSanXuat_Load(object sender, EventArgs e)
        {
            this.LayDanhSachNoiSanXuat();
        }

        private void gvDanhMucNoiSanXuat_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }

        private void gvDanhMucNoiSanXuat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    NoiSanXuatBUS itemBUS = new NoiSanXuatBUS();
                    for (int i = 0; i < gvDanhMucNoiSanXuat.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucNoiSanXuat.GetRowCellValue(gvDanhMucNoiSanXuat.GetSelectedRows()[i], gvDanhMucNoiSanXuat.Columns["Id"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachNoiSanXuat();
            }
        }

        private void gvDanhMucNoiSanXuat_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucNoiSanXuat.FocusedRowHandle > -1)
            {
                try
                {
                    NoiSanXuatDTO itemDTO = new NoiSanXuatDTO();
                    NoiSanXuatBUS itemBUS = new NoiSanXuatBUS();
                    itemDTO.MaNoiSanXuat = gvDanhMucNoiSanXuat.GetFocusedRowCellValue("MaNoiSanXuat").ToString();
                    itemDTO.TenNoiSanXuat = gvDanhMucNoiSanXuat.GetFocusedRowCellValue("TenNoiSanXuat").ToString();
                    itemDTO.GhiChu = gvDanhMucNoiSanXuat.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.Id = int.Parse(gvDanhMucNoiSanXuat.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucNoiSanXuat.FocusedRowHandle == gvDanhMucNoiSanXuat.RowCount - 2)
                    {
                        if (itemDTO.MaNoiSanXuat.Length > 0)
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
                this.LayDanhSachNoiSanXuat();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                NoiSanXuatBUS itemBUS = new NoiSanXuatBUS();
                for (int i = 0; i < gvDanhMucNoiSanXuat.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucNoiSanXuat.GetRowCellValue(gvDanhMucNoiSanXuat.GetSelectedRows()[i], gvDanhMucNoiSanXuat.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachNoiSanXuat();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
