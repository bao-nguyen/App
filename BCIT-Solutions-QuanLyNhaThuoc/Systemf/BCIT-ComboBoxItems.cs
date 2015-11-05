using System;
using Systemb;
using Systemt;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;

namespace Systemf
{
    public  class BCIT_ComboBoxItems
    {
        public RepositoryItemLookUpEdit HoatChatChinh()
        {
            HoatChatChinhBUS hoatChatChinhBUS = new HoatChatChinhBUS();
            BindingList<HoatChatChinhDTO> dsHoatChatChinh = hoatChatChinhBUS.LayDanhSach();

            RepositoryItemLookUpEdit repositoryItem = new RepositoryItemLookUpEdit();
            repositoryItem.DataSource = dsHoatChatChinh;
            repositoryItem.PopulateColumns();
            foreach (LookUpColumnInfo col in repositoryItem.Columns)
            {
                if (col.FieldName == "Id" || col.FieldName == "GhiChu")
                    col.Visible = false;
            }
            repositoryItem.DisplayMember = "TenHoatChatChinh";
            repositoryItem.ValueMember = "Id";
            return repositoryItem;
        }
        public RepositoryItemLookUpEdit NhomHangHoa()
        {
            NhomHangHoaBUS nhomHangHoaBUS = new NhomHangHoaBUS();
            BindingList<NhomHangHoaDTO> dsNhomHangHoa = nhomHangHoaBUS.LayDanhSach();

            RepositoryItemLookUpEdit repositoryNhomHangHoa = new RepositoryItemLookUpEdit();
            repositoryNhomHangHoa.DataSource = dsNhomHangHoa;
            repositoryNhomHangHoa.PopulateColumns();
            foreach (LookUpColumnInfo col in repositoryNhomHangHoa.Columns)
            {
                if (col.FieldName == "Id" || col.FieldName == "GhiChu")
                    col.Visible = false;
            }
            repositoryNhomHangHoa.DisplayMember = "TenNhomHangHoa";
            repositoryNhomHangHoa.ValueMember = "Id";
            return repositoryNhomHangHoa;
        }
        public RepositoryItemLookUpEdit LoaiHangHoa()
        {
            LoaiHangHoaBUS loaiHangHoaBUS = new LoaiHangHoaBUS();
            BindingList<LoaiHangHoaDTO> dsLoaiHangHoa = loaiHangHoaBUS.LayDanhSach();

            RepositoryItemLookUpEdit repositoryLoaiHangHoa = new RepositoryItemLookUpEdit();
            repositoryLoaiHangHoa.DataSource = dsLoaiHangHoa;
            repositoryLoaiHangHoa.PopulateColumns();
            foreach (LookUpColumnInfo col in repositoryLoaiHangHoa.Columns)
            {
                if (col.FieldName == "Id" || col.FieldName == "GhiChu")
                    col.Visible = false;
            }
            repositoryLoaiHangHoa.DisplayMember = "TenLoaiHangHoa";
            repositoryLoaiHangHoa.ValueMember = "Id";
            return repositoryLoaiHangHoa;
        }
        public RepositoryItemLookUpEdit HangSanXuat()
        {
            HangSanXuatBUS hangSanXuatBUS = new HangSanXuatBUS();
            BindingList<HangSanXuatDTO> dsHangSanXuat = hangSanXuatBUS.LayDanhSach();

            RepositoryItemLookUpEdit repositoryHangSanXuat = new RepositoryItemLookUpEdit();
            repositoryHangSanXuat.DataSource = dsHangSanXuat;
            repositoryHangSanXuat.PopulateColumns();
            foreach (LookUpColumnInfo col in repositoryHangSanXuat.Columns)
            {
                if (col.FieldName == "Id" || col.FieldName == "GhiChu")
                    col.Visible = false;
            }
            repositoryHangSanXuat.DisplayMember = "TenHangSanXuat";
            repositoryHangSanXuat.ValueMember = "Id";
            return repositoryHangSanXuat;
        }
        public RepositoryItemLookUpEdit NoiSanXuat()
        {
            NoiSanXuatBUS noiSanXuatBUS = new NoiSanXuatBUS();
            BindingList<NoiSanXuatDTO> dsNoiSanXuat = noiSanXuatBUS.LayDanhSach();

            RepositoryItemLookUpEdit repositoryNoiSanXuat = new RepositoryItemLookUpEdit();
            repositoryNoiSanXuat.DataSource = dsNoiSanXuat;
            repositoryNoiSanXuat.PopulateColumns();
            foreach (LookUpColumnInfo col in repositoryNoiSanXuat.Columns)
            {
                if (col.FieldName == "Id" || col.FieldName == "GhiChu")
                    col.Visible = false;
            }
            repositoryNoiSanXuat.DisplayMember = "TenNoiSanXuat";
            repositoryNoiSanXuat.ValueMember = "Id";
            return repositoryNoiSanXuat;
        }
        public RepositoryItemLookUpEdit ViTri()
        {
            ViTriBUS viTriBUS = new ViTriBUS();
            BindingList<ViTriDTO> dsViTri = viTriBUS.LayDanhSach();

            RepositoryItemLookUpEdit repositoryViTri = new RepositoryItemLookUpEdit();
            repositoryViTri.DataSource = dsViTri;
            repositoryViTri.PopulateColumns();
            foreach (LookUpColumnInfo col in repositoryViTri.Columns)
            {
                if (col.FieldName == "Id" || col.FieldName == "GhiChu")
                    col.Visible = false;
            }
            repositoryViTri.DisplayMember = "TenViTri";
            repositoryViTri.ValueMember = "Id";
            return repositoryViTri;
        }
        public RepositoryItemLookUpEdit DonViTinh()
        {
            DonViTinhBUS DonViTinhBUS = new DonViTinhBUS();
            BindingList<DonViTinhDTO> dsDonViTinh = DonViTinhBUS.LayDanhSach();

            RepositoryItemLookUpEdit repositoryDonViTinh = new RepositoryItemLookUpEdit();
            repositoryDonViTinh.DataSource = dsDonViTinh;
            repositoryDonViTinh.PopulateColumns();
            foreach (LookUpColumnInfo col in repositoryDonViTinh.Columns)
            {
                if (col.FieldName == "Id" || col.FieldName == "GhiChu")
                    col.Visible = false;
            }
            repositoryDonViTinh.DisplayMember = "TenDonViTinh";
            repositoryDonViTinh.ValueMember = "Id";
            return repositoryDonViTinh;
        }
        
    }
}
