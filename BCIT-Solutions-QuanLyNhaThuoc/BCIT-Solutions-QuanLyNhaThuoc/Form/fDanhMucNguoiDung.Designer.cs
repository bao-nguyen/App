namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fDanhMucNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucNguoiDung));
            this.gcDanhMucNguoiDung = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMucNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolIdChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gcolDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolNgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolNgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolVoHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gcolMatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDanhMucNguoiDung
            // 
            this.gcDanhMucNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhMucNguoiDung.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDanhMucNguoiDung.Location = new System.Drawing.Point(12, 12);
            this.gcDanhMucNguoiDung.MainView = this.gvDanhMucNguoiDung;
            this.gcDanhMucNguoiDung.Name = "gcDanhMucNguoiDung";
            this.gcDanhMucNguoiDung.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gcDanhMucNguoiDung.Size = new System.Drawing.Size(760, 400);
            this.gcDanhMucNguoiDung.TabIndex = 0;
            this.gcDanhMucNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMucNguoiDung});
            this.gcDanhMucNguoiDung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcDanhMucNguoiDung_KeyDown);
            // 
            // gvDanhMucNguoiDung
            // 
            this.gvDanhMucNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaNguoiDung,
            this.gcolTenNguoiDung,
            this.gcolIdChucDanh,
            this.gcolDiaChi,
            this.gcolDienThoai,
            this.gcolNgayBatDau,
            this.gcolNgayKetThuc,
            this.gcolVoHieu,
            this.gcolGhiChu,
            this.gcolMatKhau});
            this.gvDanhMucNguoiDung.GridControl = this.gcDanhMucNguoiDung;
            this.gvDanhMucNguoiDung.Name = "gvDanhMucNguoiDung";
            this.gvDanhMucNguoiDung.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gvDanhMucNguoiDung.OptionsSelection.MultiSelect = true;
            this.gvDanhMucNguoiDung.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhMucNguoiDung.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDanhMucNguoiDung.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhMucNguoiDung.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDanhMucNguoiDung_InitNewRow);
            this.gvDanhMucNguoiDung.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMucNguoiDung_RowUpdated);
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
            this.gcolMaNguoiDung.VisibleIndex = 1;
            // 
            // gcolTenNguoiDung
            // 
            this.gcolTenNguoiDung.Caption = "Tên người dùng";
            this.gcolTenNguoiDung.FieldName = "TenNguoiDung";
            this.gcolTenNguoiDung.Name = "gcolTenNguoiDung";
            this.gcolTenNguoiDung.Visible = true;
            this.gcolTenNguoiDung.VisibleIndex = 2;
            // 
            // gcolIdChucDanh
            // 
            this.gcolIdChucDanh.Caption = "Chức danh";
            this.gcolIdChucDanh.ColumnEdit = this.repositoryItemComboBox1;
            this.gcolIdChucDanh.FieldName = "IdChucDanh";
            this.gcolIdChucDanh.Name = "gcolIdChucDanh";
            this.gcolIdChucDanh.Visible = true;
            this.gcolIdChucDanh.VisibleIndex = 4;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // gcolDiaChi
            // 
            this.gcolDiaChi.Caption = "Địa chỉ";
            this.gcolDiaChi.FieldName = "DiaChi";
            this.gcolDiaChi.Name = "gcolDiaChi";
            this.gcolDiaChi.Visible = true;
            this.gcolDiaChi.VisibleIndex = 5;
            // 
            // gcolDienThoai
            // 
            this.gcolDienThoai.Caption = "Điện thoại";
            this.gcolDienThoai.FieldName = "DienThoai";
            this.gcolDienThoai.Name = "gcolDienThoai";
            this.gcolDienThoai.Visible = true;
            this.gcolDienThoai.VisibleIndex = 6;
            // 
            // gcolNgayBatDau
            // 
            this.gcolNgayBatDau.Caption = "Ngày bắt đầu";
            this.gcolNgayBatDau.FieldName = "NgayBatDau";
            this.gcolNgayBatDau.Name = "gcolNgayBatDau";
            this.gcolNgayBatDau.Visible = true;
            this.gcolNgayBatDau.VisibleIndex = 7;
            // 
            // gcolNgayKetThuc
            // 
            this.gcolNgayKetThuc.Caption = "Ngày kết thúc";
            this.gcolNgayKetThuc.FieldName = "NgayKetThuc";
            this.gcolNgayKetThuc.Name = "gcolNgayKetThuc";
            this.gcolNgayKetThuc.Visible = true;
            this.gcolNgayKetThuc.VisibleIndex = 8;
            // 
            // gcolVoHieu
            // 
            this.gcolVoHieu.Caption = "Vô hiệu thời gian";
            this.gcolVoHieu.FieldName = "VoHieu";
            this.gcolVoHieu.Name = "gcolVoHieu";
            this.gcolVoHieu.Visible = true;
            this.gcolVoHieu.VisibleIndex = 9;
            // 
            // gcolGhiChu
            // 
            this.gcolGhiChu.Caption = "Ghi chú";
            this.gcolGhiChu.Name = "gcolGhiChu";
            this.gcolGhiChu.Visible = true;
            this.gcolGhiChu.VisibleIndex = 10;
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
            this.controlNavigator1.Location = new System.Drawing.Point(12, 418);
            this.controlNavigator1.Name = "controlNavigator1";
            this.controlNavigator1.NavigatableControl = this.gcDanhMucNguoiDung;
            this.controlNavigator1.Size = new System.Drawing.Size(301, 24);
            this.controlNavigator1.TabIndex = 14;
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
            this.btnThoat.Location = new System.Drawing.Point(682, 419);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 30);
            this.btnThoat.TabIndex = 13;
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
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gcolMatKhau
            // 
            this.gcolMatKhau.Caption = "Mật khẩu";
            this.gcolMatKhau.FieldName = "MatKhau";
            this.gcolMatKhau.Name = "gcolMatKhau";
            this.gcolMatKhau.Visible = true;
            this.gcolMatKhau.VisibleIndex = 3;
            // 
            // fDanhMucNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.controlNavigator1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gcDanhMucNguoiDung);
            this.Name = "fDanhMucNguoiDung";
            this.Text = "Danh mục người dùng";
            this.Load += new System.EventHandler(this.fDanhMucNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhMucNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMucNguoiDung;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn gcolVoHieu;
        private DevExpress.XtraGrid.Columns.GridColumn gcolIdChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn gcolDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn gcolDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn gcolNgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn gcolNgayKetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn gcolGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMatKhau;
    }
}