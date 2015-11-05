using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucHoatChatChinh : Form
    {
        public fDanhMucHoatChatChinh()
        {
            InitializeComponent();
        }
        bool flagThem = false;
        private void LayDanhSachHoatChatChinh()
        {

            HoatChatChinhBUS itemBUS = new HoatChatChinhBUS();
            BindingList<HoatChatChinhDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucHoatChatChinh.DataSource = danhSach;
        }
        private void fDanhMucHoatChatChinh_Load(object sender, EventArgs e)
        {
            this.LayDanhSachHoatChatChinh();
        }

        private void gvDanhMucHoatChatChinh_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucHoatChatChinh.FocusedRowHandle > -1)
            {
                try
                {
                    HoatChatChinhDTO itemDTO = new HoatChatChinhDTO();
                    HoatChatChinhBUS itemBUS = new HoatChatChinhBUS();
                    itemDTO.MaHoatChatChinh = gvDanhMucHoatChatChinh.GetFocusedRowCellValue("MaHoatChatChinh").ToString();
                    itemDTO.TenHoatChatChinh = gvDanhMucHoatChatChinh.GetFocusedRowCellValue("TenHoatChatChinh").ToString();
                    itemDTO.GhiChu = gvDanhMucHoatChatChinh.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.Id = int.Parse(gvDanhMucHoatChatChinh.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucHoatChatChinh.FocusedRowHandle == gvDanhMucHoatChatChinh.RowCount - 2)
                    {
                        if (itemDTO.MaHoatChatChinh.Length > 0)
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
                this.LayDanhSachHoatChatChinh();
            }
        }

        private void gvDanhMucHoatChatChinh_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }

        private void gvDanhMucHoatChatChinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    HoatChatChinhBUS itemBUS = new HoatChatChinhBUS();
                    for (int i = 0; i < gvDanhMucHoatChatChinh.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucHoatChatChinh.GetRowCellValue(gvDanhMucHoatChatChinh.GetSelectedRows()[i], gvDanhMucHoatChatChinh.Columns["Id"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachHoatChatChinh();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                HoatChatChinhBUS itemBUS = new HoatChatChinhBUS();
                for (int i = 0; i < gvDanhMucHoatChatChinh.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucHoatChatChinh.GetRowCellValue(gvDanhMucHoatChatChinh.GetSelectedRows()[i], gvDanhMucHoatChatChinh.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachHoatChatChinh();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
