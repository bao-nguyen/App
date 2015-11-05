namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fDanhMucNhomKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucNhomKhachHang));
            this.gcDanhMucNhomKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMucNhomKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaNhomKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenNhomKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gcolPhanTramLoiNhuan = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucNhomKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucNhomKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDanhMucNhomKhachHang
            // 
            this.gcDanhMucNhomKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhMucNhomKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDanhMucNhomKhachHang.Location = new System.Drawing.Point(14, 12);
            this.gcDanhMucNhomKhachHang.MainView = this.gvDanhMucNhomKhachHang;
            this.gcDanhMucNhomKhachHang.Name = "gcDanhMucNhomKhachHang";
            this.gcDanhMucNhomKhachHang.Size = new System.Drawing.Size(756, 400);
            this.gcDanhMucNhomKhachHang.TabIndex = 0;
            this.gcDanhMucNhomKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMucNhomKhachHang});
            this.gcDanhMucNhomKhachHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcDanhMucNhomKhachHang_KeyDown);
            // 
            // gvDanhMucNhomKhachHang
            // 
            this.gvDanhMucNhomKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaNhomKhachHang,
            this.gcolTenNhomKhachHang,
            this.gcolPhanTramLoiNhuan,
            this.gcolGhiChu});
            this.gvDanhMucNhomKhachHang.GridControl = this.gcDanhMucNhomKhachHang;
            this.gvDanhMucNhomKhachHang.Name = "gvDanhMucNhomKhachHang";
            this.gvDanhMucNhomKhachHang.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gvDanhMucNhomKhachHang.OptionsSelection.MultiSelect = true;
            this.gvDanhMucNhomKhachHang.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhMucNhomKhachHang.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDanhMucNhomKhachHang.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhMucNhomKhachHang.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDanhMucNhomKhachHang_InitNewRow);
            this.gvDanhMucNhomKhachHang.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMucNhomKhachHang_RowUpdated);
            // 
            // gcolId
            // 
            this.gcolId.Caption = "Id";
            this.gcolId.FieldName = "Id";
            this.gcolId.Name = "gcolId";
            // 
            // gcolMaNhomKhachHang
            // 
            this.gcolMaNhomKhachHang.Caption = "Mã nhóm khách hàng";
            this.gcolMaNhomKhachHang.FieldName = "MaNhomKhachHang";
            this.gcolMaNhomKhachHang.Name = "gcolMaNhomKhachHang";
            this.gcolMaNhomKhachHang.Visible = true;
            this.gcolMaNhomKhachHang.VisibleIndex = 1;
            // 
            // gcolTenNhomKhachHang
            // 
            this.gcolTenNhomKhachHang.Caption = "Tên nhóm khách hàng";
            this.gcolTenNhomKhachHang.FieldName = "TenNhomKhachHang";
            this.gcolTenNhomKhachHang.Name = "gcolTenNhomKhachHang";
            this.gcolTenNhomKhachHang.Visible = true;
            this.gcolTenNhomKhachHang.VisibleIndex = 2;
            // 
            // gcolGhiChu
            // 
            this.gcolGhiChu.Caption = "Ghi chú";
            this.gcolGhiChu.FieldName = "GhiChu";
            this.gcolGhiChu.Name = "gcolGhiChu";
            this.gcolGhiChu.Visible = true;
            this.gcolGhiChu.VisibleIndex = 4;
            // 
            // controlNavigator1
            // 
            this.controlNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.controlNavigator1.Buttons.CancelEdit.Enabled = false;
            this.controlNavigator1.Buttons.CancelEdit.Visible = false;
            this.controlNavigator1.Buttons.Edit.Enabled = false;
            this.controlNavigator1.Buttons.Edit.Visible = false;
            this.controlNavigator1.Buttons.EndEdit.Visible = false;
            this.controlNavigator1.Buttons.Remove.Enabled = false;
            this.controlNavigator1.Buttons.Remove.Visible = false;
            this.controlNavigator1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.controlNavigator1.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton()});
            this.controlNavigator1.Location = new System.Drawing.Point(14, 418);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.NavigatableControl = this.gcDanhMucNhomKhachHang;
            this.controlNavigator1.Size = new System.Drawing.Size(301, 24);
            this.controlNavigator1.TabIndex = 7;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.controlNavigator1.TextStringFormat = " {0} của {1}";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(680, 419);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 30);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(584, 419);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 30);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gcolPhanTramLoiNhuan
            // 
            this.gcolPhanTramLoiNhuan.Caption = "% lợi nhuận";
            this.gcolPhanTramLoiNhuan.FieldName = "PhanTramLoiNhuan";
            this.gcolPhanTramLoiNhuan.Name = "gcolPhanTramLoiNhuan";
            this.gcolPhanTramLoiNhuan.Visible = true;
            this.gcolPhanTramLoiNhuan.VisibleIndex = 3;
            // 
            // fDanhMucNhomKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.controlNavigator1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gcDanhMucNhomKhachHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fDanhMucNhomKhachHang";
            this.Text = "Danh mục nhóm khách hàng";
            this.Load += new System.EventHandler(this.fDanhMucNhomKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucNhomKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucNhomKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhMucNhomKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMucNhomKhachHang;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaNhomKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenNhomKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gcolGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn gcolPhanTramLoiNhuan;
    }
}