using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;
using Systemf;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using SystemFunctions;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucHangHoa : Form
    {
        public fDanhMucHangHoa()
        {
            InitializeComponent();
        }

        bool flagThem = false;

        private void LayDanhSachHangHoa()
        {

            HangHoaBUS itemBUS = new HangHoaBUS();
            BindingList<HangHoaDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucHangHoa.DataSource = danhSach;
           
            BCIT_ComboBoxItems iComboBox = new BCIT_ComboBoxItems();
            gvDanhMucHangHoa.Columns["IdHoatChatChinh"].ColumnEdit = iComboBox.HoatChatChinh();
            gvDanhMucHangHoa.Columns["IdNhomHangHoa"].ColumnEdit = iComboBox.NhomHangHoa();
            gvDanhMucHangHoa.Columns["IdLoaiHangHoa"].ColumnEdit = iComboBox.LoaiHangHoa();
            gvDanhMucHangHoa.Columns["IdHangSanXuat"].ColumnEdit = iComboBox.HangSanXuat();
            gvDanhMucHangHoa.Columns["IdNoiSanXuat"].ColumnEdit = iComboBox.NoiSanXuat();
            gvDanhMucHangHoa.Columns["IdViTri"].ColumnEdit = iComboBox.ViTri();
            gvDanhMucHangHoa.Columns["IdDonViTinh"].ColumnEdit = iComboBox.DonViTinh();
            gvDanhMucHangHoa.Columns["IdDonViQuyDoi1"].ColumnEdit = iComboBox.DonViTinh();
            gvDanhMucHangHoa.Columns["IdDonViQuyDoi2"].ColumnEdit = iComboBox.DonViTinh();
        }

        private void XoaHangHoa()
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                HangHoaBUS itemBUS = new HangHoaBUS();
                for (int i = 0; i < gvDanhMucHangHoa.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucHangHoa.GetRowCellValue(gvDanhMucHangHoa.GetSelectedRows()[i], gvDanhMucHangHoa.Columns["Id"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachHangHoa();
        }

        private void fDanhMucHangHoa_Load(object sender, EventArgs e)
        {
            this.LayDanhSachHangHoa();
        }

        private void gvDanhMucHangHoa_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            
            if (gvDanhMucHangHoa.FocusedRowHandle > -1)
            {
                try
                {                  
                    HangHoaDTO itemDTO = new HangHoaDTO();
                    HangHoaBUS itemBUS = new HangHoaBUS();
                    
                    itemDTO.MaHangHoa = gvDanhMucHangHoa.GetFocusedRowCellValue("MaHangHoa").ToString();
                    itemDTO.TenHangHoa = gvDanhMucHangHoa.GetFocusedRowCellValue("TenHangHoa").ToString();
                    
                    itemDTO.IdHoatChatChinh = int.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("IdHoatChatChinh").ToString());
                    itemDTO.IdNhomHangHoa = int.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("IdNhomHangHoa").ToString());
                    itemDTO.IdLoaiHangHoa = int.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("IdLoaiHangHoa").ToString());
                    itemDTO.IdHangSanXuat = int.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("IdHangSanXuat").ToString());
                    itemDTO.IdNoiSanXuat = int.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("IdNoiSanXuat").ToString());
                    itemDTO.IdViTri = int.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("IdViTri").ToString());
                    itemDTO.SoDangKy = gvDanhMucHangHoa.GetFocusedRowCellValue("SoDangKy").ToString();
                    itemDTO.IdDonViTinh = int.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("IdDonViTinh").ToString());
                    itemDTO.GiaNhap = double.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("GiaNhap").ToString());
                    itemDTO.TyLeChietKhau = double.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("TyLeChietKhau").ToString());                  
                    itemDTO.VAT = double.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("VAT").ToString());
                    itemDTO.IdDonViQuyDoi1 = int.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("IdDonViQuyDoi1").ToString());
                    itemDTO.TyLeQuyDoi1 = int.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("TyLeQuyDoi1").ToString());
                    itemDTO.GiaQuyDoi1 = double.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("GiaQuyDoi1").ToString());
                    itemDTO.GiaDeXuat1 = double.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("GiaDeXuat1").ToString());
                    itemDTO.IdDonViQuyDoi2 = int.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("IdDonViQuyDoi2").ToString());
                    itemDTO.TyLeQuyDoi2 = int.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("TyLeQuyDoi2").ToString());
                    itemDTO.GiaQuyDoi2 = double.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("GiaQuyDoi2").ToString());
                    itemDTO.GiaDeXuat2 = double.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("GiaDeXuat2").ToString());
                    itemDTO.NhietDoBaoQuan = gvDanhMucHangHoa.GetFocusedRowCellValue("NhietDoBaoQuan").ToString();
                    itemDTO.AnhSangBaoQuan = gvDanhMucHangHoa.GetFocusedRowCellValue("AnhSangBaoQuan").ToString();
                    itemDTO.DoAmBaoQuan = gvDanhMucHangHoa.GetFocusedRowCellValue("DoAmBaoQuan").ToString();
                    itemDTO.QuanLyKho = bool.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("QuanLyKho").ToString());                                                                                                
                    itemDTO.Id = int.Parse(gvDanhMucHangHoa.GetFocusedRowCellValue("Id").ToString());

                    if (this.flagThem && gvDanhMucHangHoa.FocusedRowHandle == gvDanhMucHangHoa.RowCount - 2)
                    {
                       
                        if (itemDTO.MaHangHoa.Length > 0)
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
                this.LayDanhSachHangHoa();
            }
        }

        private void gvDanhMucHangHoa_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            this.flagThem = true;
        }

        private void gvDanhMucHangHoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.XoaHangHoa();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.XoaHangHoa();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
