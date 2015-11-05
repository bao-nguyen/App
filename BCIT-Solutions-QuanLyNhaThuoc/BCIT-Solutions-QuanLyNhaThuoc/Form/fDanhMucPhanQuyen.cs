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
    public partial class fDanhMucPhanQuyen : Form
    {
        public fDanhMucPhanQuyen()
        {
            InitializeComponent();
        }        
        private void LayDanhSachNguoiDung()
        {

            NguoiDungBUS itemBUS = new NguoiDungBUS();
            BindingList<NguoiDungDTO> danhSach = itemBUS.LayDanhSach();
            //danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcNguoiDung.DataSource = danhSach;
        }

        private void LayDanhSachPhanQuyen(int maND)
        {

            PhanQuyenBUS itemBUS = new PhanQuyenBUS();
            BindingList<PhanQuyenCTO> danhSach = itemBUS.LayDanhSachCTO(maND);
            //danhSach.AllowEdit = danhSach.AllowNew = danhSach.AllowRemove = true;
            gcDanhSachPhanQuyen.DataSource = danhSach;
            
        }

        private void fDanhMucPhanQuyen_Load(object sender, EventArgs e)
        {
            this.LayDanhSachNguoiDung();
            int maND = int.Parse(gvNguoiDung.GetFocusedRowCellValue("Id").ToString());
            this.LayDanhSachPhanQuyen(maND);
        }

        private void gvNguoiDung_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
            int maND = int.Parse(gvNguoiDung.GetFocusedRowCellValue("Id").ToString());
            this.LayDanhSachPhanQuyen(maND);
        }

        private void gvDanhSachPhanQuyen_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (gvDanhSachPhanQuyen.FocusedRowHandle > -1)
            {
                try
                {
                    PhanQuyenDTO itemDTO = new PhanQuyenDTO();
                    PhanQuyenBUS itemBUS = new PhanQuyenBUS();
                    itemDTO.Doc = bool.Parse(gvDanhSachPhanQuyen.GetFocusedRowCellValue("Doc").ToString());
                    itemDTO.Them = bool.Parse(gvDanhSachPhanQuyen.GetFocusedRowCellValue("Them").ToString());
                    itemDTO.Sua = bool.Parse(gvDanhSachPhanQuyen.GetFocusedRowCellValue("Sua").ToString());
                    itemDTO.Xoa = bool.Parse(gvDanhSachPhanQuyen.GetFocusedRowCellValue("Xoa").ToString());
                    itemDTO.Id = int.Parse(gvDanhSachPhanQuyen.GetFocusedRowCellValue("Id").ToString());

                    itemBUS.Sua(itemDTO);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }       
    }
}
