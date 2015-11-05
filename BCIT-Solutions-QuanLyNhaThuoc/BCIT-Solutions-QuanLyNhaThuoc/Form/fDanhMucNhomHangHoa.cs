using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucNhomHangHoa : Form
    {
        public fDanhMucNhomHangHoa()
        {
            InitializeComponent();
        }
        bool flagThem = false;
        private void LayDanhSachNhomHangHoa()
        {

            NhomHangHoaBUS itemBUS = new NhomHangHoaBUS();
            BindingList<NhomHangHoaDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucNhomHangHoa.DataSource = danhSach;
        }
        private void fDanhMucNhomHangHoa_Load(object sender, EventArgs e)
        {
            this.LayDanhSachNhomHangHoa();
        }

        private void gvDanhMucNhomHangHoa_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }

        private void gvDanhMucNhomHangHoa_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucNhomHangHoa.FocusedRowHandle > -1)
            {
                try
                {
                    NhomHangHoaDTO itemDTO = new NhomHangHoaDTO();
                    NhomHangHoaBUS itemBUS = new NhomHangHoaBUS();
                    itemDTO.MaNhomHangHoa = gvDanhMucNhomHangHoa.GetFocusedRowCellValue("MaNhomHangHoa").ToString();
                    itemDTO.TenNhomHangHoa = gvDanhMucNhomHangHoa.GetFocusedRowCellValue("TenNhomHangHoa").ToString();
                    itemDTO.GhiChu = gvDanhMucNhomHangHoa.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.Id = int.Parse(gvDanhMucNhomHangHoa.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucNhomHangHoa.FocusedRowHandle == gvDanhMucNhomHangHoa.RowCount - 2)
                    {
                        if (itemDTO.MaNhomHangHoa.Length > 0)
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
                this.LayDanhSachNhomHangHoa();
            }
        }

        private void gvDanhMucNhomHangHoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    NhomHangHoaBUS itemBUS = new NhomHangHoaBUS();
                    for (int i = 0; i < gvDanhMucNhomHangHoa.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucNhomHangHoa.GetRowCellValue(gvDanhMucNhomHangHoa.GetSelectedRows()[i], gvDanhMucNhomHangHoa.Columns["Id"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachNhomHangHoa();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                NhomHangHoaBUS itemBUS = new NhomHangHoaBUS();
                for (int i = 0; i < gvDanhMucNhomHangHoa.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucNhomHangHoa.GetRowCellValue(gvDanhMucNhomHangHoa.GetSelectedRows()[i], gvDanhMucNhomHangHoa.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachNhomHangHoa();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
