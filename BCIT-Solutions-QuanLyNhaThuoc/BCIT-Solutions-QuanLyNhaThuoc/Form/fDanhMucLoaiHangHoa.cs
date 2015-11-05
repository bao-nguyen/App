using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucLoaiHangHoa : Form
    {
        public fDanhMucLoaiHangHoa()
        {
            InitializeComponent();
        }
        bool flagThem = false;
        private void LayDanhSachLoaiHangHoa()
        {

            LoaiHangHoaBUS itemBUS = new LoaiHangHoaBUS();
            BindingList<LoaiHangHoaDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucLoaiHangHoa.DataSource = danhSach;
        }
        private void fDanhMucLoaiHangHoa_Load(object sender, EventArgs e)
        {
            this.LayDanhSachLoaiHangHoa();
        }

        private void gvDanhMucLoaiHangHoa_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucLoaiHangHoa.FocusedRowHandle > -1)
            {
                try
                {
                    LoaiHangHoaDTO itemDTO = new LoaiHangHoaDTO();
                    LoaiHangHoaBUS itemBUS = new LoaiHangHoaBUS();
                    itemDTO.MaLoaiHangHoa = gvDanhMucLoaiHangHoa.GetFocusedRowCellValue("MaLoaiHangHoa").ToString();
                    itemDTO.TenLoaiHangHoa = gvDanhMucLoaiHangHoa.GetFocusedRowCellValue("TenLoaiHangHoa").ToString();
                    itemDTO.GhiChu = gvDanhMucLoaiHangHoa.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.Id = int.Parse(gvDanhMucLoaiHangHoa.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucLoaiHangHoa.FocusedRowHandle == gvDanhMucLoaiHangHoa.RowCount - 2)
                    {
                        if (itemDTO.MaLoaiHangHoa.Length > 0)
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
                this.LayDanhSachLoaiHangHoa();
            }
        }

        private void gvDanhMucLoaiHangHoa_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                LoaiHangHoaBUS itemBUS = new LoaiHangHoaBUS();
                for (int i = 0; i < gvDanhMucLoaiHangHoa.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucLoaiHangHoa.GetRowCellValue(gvDanhMucLoaiHangHoa.GetSelectedRows()[i], gvDanhMucLoaiHangHoa.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachLoaiHangHoa();
        }

        private void gvDanhMucLoaiHangHoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    LoaiHangHoaBUS itemBUS = new LoaiHangHoaBUS();
                    for (int i = 0; i < gvDanhMucLoaiHangHoa.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucLoaiHangHoa.GetRowCellValue(gvDanhMucLoaiHangHoa.GetSelectedRows()[i], gvDanhMucLoaiHangHoa.Columns["Id"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachLoaiHangHoa();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
