using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fTest : Form
    {
        public fTest()
        {
            InitializeComponent();
        }

        bool flagThem = false;
        private void LayDanhSachDonViTinh()
        {

            DonViTinhBUS itemBUS = new DonViTinhBUS();
            BindingList<DonViTinhDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDonViTinh.DataSource = danhSach;
        }

        private void fTest_Load(object sender, EventArgs e)
        {
            this.LayDanhSachDonViTinh();
        }

        private void gvDanhMucDonViTinh_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDonViTinh.FocusedRowHandle > -1)
            {
                try
                {
                    DonViTinhDTO itemDTO = new DonViTinhDTO();
                    DonViTinhBUS itemBUS = new DonViTinhBUS();
                    itemDTO.MaDonViTinh = gvDonViTinh.GetFocusedRowCellValue("MaDonViTinh").ToString();
                    itemDTO.TenDonViTinh = gvDonViTinh.GetFocusedRowCellValue("TenDonViTinh").ToString();
                    itemDTO.GhiChu = gvDonViTinh.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.Id = int.Parse(gvDonViTinh.GetFocusedRowCellValue("Id").ToString());

                   

                    if (this.flagThem && gvDonViTinh.FocusedRowHandle == gvDonViTinh.RowCount - 2)
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

        private void gvDonViTinh_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }
    }
}
