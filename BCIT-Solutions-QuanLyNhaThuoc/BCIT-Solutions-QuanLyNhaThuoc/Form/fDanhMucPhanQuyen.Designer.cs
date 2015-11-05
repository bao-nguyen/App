namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fDanhMucPhanQuyen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scpNguoiDung = new System.Windows.Forms.SplitContainer();
            this.gboxNguoiDung = new System.Windows.Forms.GroupBox();
            this.gcNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.gvNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gboxPhanQuyen = new System.Windows.Forms.GroupBox();
            this.gcDanhSachPhanQuyen = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachPhanQuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolPhanQuyenId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolIdNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolIdChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolIdPhanHe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolDoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolThem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scpNguoiDung)).BeginInit();
            this.scpNguoiDung.Panel1.SuspendLayout();
            this.scpNguoiDung.Panel2.SuspendLayout();
            this.scpNguoiDung.SuspendLayout();
            this.gboxNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguoiDung)).BeginInit();
            this.gboxPhanQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // scpNguoiDung
            // 
            this.scpNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scpNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scpNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.scpNguoiDung.Name = "scpNguoiDung";
            // 
            // scpNguoiDung.Panel1
            // 
            this.scpNguoiDung.Panel1.Controls.Add(this.gboxNguoiDung);
            // 
            // scpNguoiDung.Panel2
            // 
            this.scpNguoiDung.Panel2.Controls.Add(this.gboxPhanQuyen);
            this.scpNguoiDung.Size = new System.Drawing.Size(784, 461);
            this.scpNguoiDung.SplitterDistance = 309;
            this.scpNguoiDung.TabIndex = 0;
            // 
            // gboxNguoiDung
            // 
            this.gboxNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxNguoiDung.Controls.Add(this.gcNguoiDung);
            this.gboxNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxNguoiDung.Location = new System.Drawing.Point(12, 12);
            this.gboxNguoiDung.Name = "gboxNguoiDung";
            this.gboxNguoiDung.Size = new System.Drawing.Size(282, 433);
            this.gboxNguoiDung.TabIndex = 0;
            this.gboxNguoiDung.TabStop = false;
            this.gboxNguoiDung.Text = "Người dùng";
            // 
            // gcNguoiDung
            // 
            this.gcNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcNguoiDung.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcNguoiDung.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gcNguoiDung.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcNguoiDung.EmbeddedNavigator.Enabled = false;
            this.gcNguoiDung.Location = new System.Drawing.Point(9, 19);
            this.gcNguoiDung.MainView = this.gvNguoiDung;
            this.gcNguoiDung.Name = "gcNguoiDung";
            this.gcNguoiDung.Size = new System.Drawing.Size(267, 408);
            this.gcNguoiDung.TabIndex = 0;
            this.gcNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNguoiDung});
            // 
            // gvNguoiDung
            // 
            this.gvNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaNguoiDung,
            this.gcolTenNguoiDung});
            this.gvNguoiDung.GridControl = this.gcNguoiDung;
            this.gvNguoiDung.Name = "gvNguoiDung";
            this.gvNguoiDung.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvNguoiDung.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvNguoiDung.OptionsBehavior.Editable = false;
            this.gvNguoiDung.OptionsBehavior.ReadOnly = true;
            this.gvNguoiDung.OptionsView.ShowAutoFilterRow = true;
            this.gvNguoiDung.OptionsView.ShowGroupPanel = false;
            this.gvNguoiDung.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvNguoiDung_RowClick);
            // 
            // gcolId
            // 
            this.gcolId.Caption = "Id";
            this.gcolId.FieldName = "Id";
            this.gcolId.Name = "gcolId";
            // 
            // gcolMaNguoiDung
            // 
            this.gcolMaNguoiDung.Caption = "Tên đăng nhập";
            this.gcolMaNguoiDung.FieldName = "MaNguoiDung";
            this.gcolMaNguoiDung.Name = "gcolMaNguoiDung";
            this.gcolMaNguoiDung.Visible = true;
            this.gcolMaNguoiDung.VisibleIndex = 0;
            this.gcolMaNguoiDung.Width = 40;
            // 
            // gcolTenNguoiDung
            // 
            this.gcolTenNguoiDung.Caption = "Tên người dùng";
            this.gcolTenNguoiDung.FieldName = "TenNguoiDung";
            this.gcolTenNguoiDung.Name = "gcolTenNguoiDung";
            this.gcolTenNguoiDung.Visible = true;
            this.gcolTenNguoiDung.VisibleIndex = 1;
            this.gcolTenNguoiDung.Width = 209;
            // 
            // gboxPhanQuyen
            // 
            this.gboxPhanQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxPhanQuyen.Controls.Add(this.gcDanhSachPhanQuyen);
            this.gboxPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPhanQuyen.Location = new System.Drawing.Point(12, 12);
            this.gboxPhanQuyen.Name = "gboxPhanQuyen";
            this.gboxPhanQuyen.Size = new System.Drawing.Size(443, 433);
            this.gboxPhanQuyen.TabIndex = 0;
            this.gboxPhanQuyen.TabStop = false;
            this.gboxPhanQuyen.Text = "Phân quyền";
            // 
            // gcDanhSachPhanQuyen
            // 
            this.gcDanhSachPhanQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhSachPhanQuyen.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDanhSachPhanQuyen.Location = new System.Drawing.Point(6, 22);
            this.gcDanhSachPhanQuyen.MainView = this.gvDanhSachPhanQuyen;
            this.gcDanhSachPhanQuyen.Name = "gcDanhSachPhanQuyen";
            this.gcDanhSachPhanQuyen.Size = new System.Drawing.Size(431, 405);
            this.gcDanhSachPhanQuyen.TabIndex = 0;
            this.gcDanhSachPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachPhanQuyen});
            // 
            // gvDanhSachPhanQuyen
            // 
            this.gvDanhSachPhanQuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolPhanQuyenId,
            this.gcolIdNguoiDung,
            this.gcolIdChucNang,
            this.gcolIdPhanHe,
            this.gcolDoc,
            this.gcolThem,
            this.gcolSua,
            this.gcolXoa});
            this.gvDanhSachPhanQuyen.GridControl = this.gcDanhSachPhanQuyen;
            this.gvDanhSachPhanQuyen.GroupCount = 1;
            this.gvDanhSachPhanQuyen.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "IdPhanHe", null, "(Số chức năng: {0})")});
            this.gvDanhSachPhanQuyen.Name = "gvDanhSachPhanQuyen";
            this.gvDanhSachPhanQuyen.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvDanhSachPhanQuyen.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gvDanhSachPhanQuyen.OptionsView.ShowGroupPanel = false;
            this.gvDanhSachPhanQuyen.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcolIdPhanHe, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvDanhSachPhanQuyen.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhSachPhanQuyen_RowUpdated);
            // 
            // gcolPhanQuyenId
            // 
            this.gcolPhanQuyenId.Caption = "Id";
            this.gcolPhanQuyenId.FieldName = "Id";
            this.gcolPhanQuyenId.Name = "gcolPhanQuyenId";
            // 
            // gcolIdNguoiDung
            // 
            this.gcolIdNguoiDung.Caption = "Id người dùng";
            this.gcolIdNguoiDung.FieldName = "IdNguoiDung";
            this.gcolIdNguoiDung.Name = "gcolIdNguoiDung";
            // 
            // gcolIdChucNang
            // 
            this.gcolIdChucNang.Caption = "Id chức năng";
            this.gcolIdChucNang.FieldName = "ChucNang";
            this.gcolIdChucNang.Name = "gcolIdChucNang";
            this.gcolIdChucNang.OptionsColumn.AllowEdit = false;
            this.gcolIdChucNang.Visible = true;
            this.gcolIdChucNang.VisibleIndex = 0;
            this.gcolIdChucNang.Width = 213;
            // 
            // gcolIdPhanHe
            // 
            this.gcolIdPhanHe.Caption = "Phân hệ";
            this.gcolIdPhanHe.FieldName = "PhanHe";
            this.gcolIdPhanHe.Name = "gcolIdPhanHe";
            this.gcolIdPhanHe.Visible = true;
            this.gcolIdPhanHe.VisibleIndex = 1;
            // 
            // gcolDoc
            // 
            this.gcolDoc.Caption = "Đọc";
            this.gcolDoc.FieldName = "Doc";
            this.gcolDoc.Name = "gcolDoc";
            this.gcolDoc.Visible = true;
            this.gcolDoc.VisibleIndex = 1;
            this.gcolDoc.Width = 50;
            // 
            // gcolThem
            // 
            this.gcolThem.Caption = "Them";
            this.gcolThem.FieldName = "Them";
            this.gcolThem.Name = "gcolThem";
            this.gcolThem.Visible = true;
            this.gcolThem.VisibleIndex = 2;
            this.gcolThem.Width = 50;
            // 
            // gcolSua
            // 
            this.gcolSua.Caption = "Sửa";
            this.gcolSua.FieldName = "Sua";
            this.gcolSua.Name = "gcolSua";
            this.gcolSua.Visible = true;
            this.gcolSua.VisibleIndex = 3;
            this.gcolSua.Width = 50;
            // 
            // gcolXoa
            // 
            this.gcolXoa.Caption = "Xóa";
            this.gcolXoa.FieldName = "Xoa";
            this.gcolXoa.Name = "gcolXoa";
            this.gcolXoa.Visible = true;
            this.gcolXoa.VisibleIndex = 4;
            this.gcolXoa.Width = 50;
            // 
            // fDanhMucPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.scpNguoiDung);
            this.Name = "fDanhMucPhanQuyen";
            this.Text = "Phân quyền";
            this.Load += new System.EventHandler(this.fDanhMucPhanQuyen_Load);
            this.scpNguoiDung.Panel1.ResumeLayout(false);
            this.scpNguoiDung.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scpNguoiDung)).EndInit();
            this.scpNguoiDung.ResumeLayout(false);
            this.gboxNguoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguoiDung)).EndInit();
            this.gboxPhanQuyen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachPhanQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scpNguoiDung;
        private System.Windows.Forms.GroupBox gboxNguoiDung;
        private DevExpress.XtraGrid.GridControl gcNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenNguoiDung;
        private System.Windows.Forms.GroupBox gboxPhanQuyen;
        private DevExpress.XtraGrid.GridControl gcDanhSachPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachPhanQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn gcolPhanQuyenId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolIdNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn gcolIdChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn gcolIdPhanHe;
        private DevExpress.XtraGrid.Columns.GridColumn gcolDoc;
        private DevExpress.XtraGrid.Columns.GridColumn gcolThem;
        private DevExpress.XtraGrid.Columns.GridColumn gcolSua;
        private DevExpress.XtraGrid.Columns.GridColumn gcolXoa;

    }
}