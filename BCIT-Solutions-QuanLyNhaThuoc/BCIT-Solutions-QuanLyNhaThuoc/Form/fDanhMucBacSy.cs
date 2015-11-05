using System.ComponentModel;
using System.Windows.Forms;
using System;
using Systemb;
using Systemt;

namespace BCIT_Solutions_QuanLyNhaThuoc
{
    public partial class fDanhMucBacSy : Form
    {
        bool flagThem = false;
        
        private void LayDanhSachBacSy()
        {

            BacSyBUS itemBUS = new BacSyBUS();
            BindingList<BacSyDTO> danhSach = itemBUS.LayDanhSach();
            danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhMucBacSy.DataSource = danhSach;                          
        }
        public fDanhMucBacSy()
        {
            InitializeComponent();
        }
        private void fDanhMucBacSy_Load(object sender, EventArgs e)
        {
            this.LayDanhSachBacSy();
        }        
        private void gvDanhMucBacSy_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhMucBacSy.FocusedRowHandle > -1)
            {
                try
                {                    
                    BacSyDTO itemDTO = new BacSyDTO();
                    BacSyBUS itemBUS = new BacSyBUS();
                    itemDTO.MaBacSy = gvDanhMucBacSy.GetFocusedRowCellValue("MaBacSy").ToString();
                    itemDTO.TenBacSy = gvDanhMucBacSy.GetFocusedRowCellValue("TenBacSy").ToString();
                    itemDTO.DiaChi = gvDanhMucBacSy.GetFocusedRowCellValue("DiaChi").ToString();
                    itemDTO.DienThoai = gvDanhMucBacSy.GetFocusedRowCellValue("DienThoai").ToString();
                    itemDTO.GhiChu = gvDanhMucBacSy.GetFocusedRowCellValue("GhiChu").ToString();
                    itemDTO.IdBacSy = int.Parse(gvDanhMucBacSy.GetFocusedRowCellValue("IdBacSy").ToString());

                    if (this.flagThem && gvDanhMucBacSy.FocusedRowHandle == gvDanhMucBacSy.RowCount - 2)
                    {
                        if (itemDTO.MaBacSy.Length > 0)
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
                            MessageBox.Show("Bạn chưa nhập mã bác sỹ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                this.LayDanhSachBacSy();
            }
        }
        private void gvDanhMucBacSy_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {            
            this.flagThem = true;
        }        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hopThoai == DialogResult.Yes)
            {
                BacSyBUS itemBUS = new BacSyBUS();
                for (int i = 0; i < gvDanhMucBacSy.SelectedRowsCount; i++)
                {
                    int ma = int.Parse(gvDanhMucBacSy.GetRowCellValue(gvDanhMucBacSy.GetSelectedRows()[i], gvDanhMucBacSy.Columns["IdBacSy"]).ToString());
                    itemBUS.Xoa(ma);
                }
            }
            this.LayDanhSachBacSy();
        }
        private void gcDanhMucBacSy_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                DialogResult hopThoai = MessageBox.Show("Bạn chắc chắn muốn xóa những dòng bạn chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (hopThoai == DialogResult.Yes)
                {
                    BacSyBUS itemBUS = new BacSyBUS();
                    for (int i = 0; i < gvDanhMucBacSy.SelectedRowsCount; i++)
                    {
                        int ma = int.Parse(gvDanhMucBacSy.GetRowCellValue(gvDanhMucBacSy.GetSelectedRows()[i], gvDanhMucBacSy.Columns["IdBacSy"]).ToString());
                        itemBUS.Xoa(ma);
                    }
                }
                this.LayDanhSachBacSy();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
