namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fDanhMucNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucNhaCungCap));
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.gcDanhMucNhaCungCap = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMucNhaCungCap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolIdNhomNhaCungCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gcolDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolSoTaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenChiNhanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucNhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
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
            this.controlNavigator1.NavigatableControl = this.gcDanhMucNhaCungCap;
            this.controlNavigator1.Size = new System.Drawing.Size(301, 24);
            this.controlNavigator1.TabIndex = 22;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.controlNavigator1.TextStringFormat = " {0} của {1}";
            // 
            // gcDanhMucNhaCungCap
            // 
            this.gcDanhMucNhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhMucNhaCungCap.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDanhMucNhaCungCap.Location = new System.Drawing.Point(12, 12);
            this.gcDanhMucNhaCungCap.MainView = this.gvDanhMucNhaCungCap;
            this.gcDanhMucNhaCungCap.Name = "gcDanhMucNhaCungCap";
            this.gcDanhMucNhaCungCap.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gcDanhMucNhaCungCap.Size = new System.Drawing.Size(760, 400);
            this.gcDanhMucNhaCungCap.TabIndex = 19;
            this.gcDanhMucNhaCungCap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMucNhaCungCap});
            // 
            // gvDanhMucNhaCungCap
            // 
            this.gvDanhMucNhaCungCap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaNhaCungCap,
            this.gcolTenNhaCungCap,
            this.gcolIdNhomNhaCungCap,
            this.gcolDiaChi,
            this.gcolDienThoai,
            this.gcolEmail,
            this.gcolSoTaiKhoan,
            this.gcolTenNganHang,
            this.gcolTenChiNhanh,
            this.gcolGhiChu});
            this.gvDanhMucNhaCungCap.GridControl = this.gcDanhMucNhaCungCap;
            this.gvDanhMucNhaCungCap.Name = "gvDanhMucNhaCungCap";
            this.gvDanhMucNhaCungCap.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gvDanhMucNhaCungCap.OptionsSelection.MultiSelect = true;
            this.gvDanhMucNhaCungCap.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhMucNhaCungCap.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDanhMucNhaCungCap.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhMucNhaCungCap.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDanhMucNhaCungCap_InitNewRow);
            this.gvDanhMucNhaCungCap.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMucNhaCungCap_RowUpdated);
            this.gvDanhMucNhaCungCap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvDanhMucNhaCungCap_KeyDown);
            // 
            // gcolId
            // 
            this.gcolId.Caption = "Id";
            this.gcolId.FieldName = "Id";
            this.gcolId.Name = "gcolId";
            // 
            // gcolMaNhaCungCap
            // 
            this.gcolMaNhaCungCap.Caption = "Mã nhà cung cấp";
            this.gcolMaNhaCungCap.FieldName = "MaNhaCungCap";
            this.gcolMaNhaCungCap.Name = "gcolMaNhaCungCap";
            this.gcolMaNhaCungCap.Visible = true;
            this.gcolMaNhaCungCap.VisibleIndex = 1;
            // 
            // gcolTenNhaCungCap
            // 
            this.gcolTenNhaCungCap.Caption = "Tên nhà cung cấp";
            this.gcolTenNhaCungCap.FieldName = "TenNhaCungCap";
            this.gcolTenNhaCungCap.Name = "gcolTenNhaCungCap";
            this.gcolTenNhaCungCap.Visible = true;
            this.gcolTenNhaCungCap.VisibleIndex = 2;
            // 
            // gcolIdNhomNhaCungCap
            // 
            this.gcolIdNhomNhaCungCap.Caption = "Nhóm nhà cung cấp";
            this.gcolIdNhomNhaCungCap.ColumnEdit = this.repositoryItemComboBox1;
            this.gcolIdNhomNhaCungCap.FieldName = "IdNhomNhaCungCap";
            this.gcolIdNhomNhaCungCap.Name = "gcolIdNhomNhaCungCap";
            this.gcolIdNhomNhaCungCap.Visible = true;
            this.gcolIdNhomNhaCungCap.VisibleIndex = 3;
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
            this.gcolDiaChi.VisibleIndex = 4;
            // 
            // gcolDienThoai
            // 
            this.gcolDienThoai.Caption = "Điện thoại";
            this.gcolDienThoai.FieldName = "DienThoai";
            this.gcolDienThoai.Name = "gcolDienThoai";
            this.gcolDienThoai.Visible = true;
            this.gcolDienThoai.VisibleIndex = 5;
            // 
            // gcolEmail
            // 
            this.gcolEmail.Caption = "Email";
            this.gcolEmail.FieldName = "Email";
            this.gcolEmail.Name = "gcolEmail";
            this.gcolEmail.Visible = true;
            this.gcolEmail.VisibleIndex = 6;
            // 
            // gcolSoTaiKhoan
            // 
            this.gcolSoTaiKhoan.Caption = "Số tài khoản";
            this.gcolSoTaiKhoan.FieldName = "SoTaiKhoan";
            this.gcolSoTaiKhoan.Name = "gcolSoTaiKhoan";
            this.gcolSoTaiKhoan.Visible = true;
            this.gcolSoTaiKhoan.VisibleIndex = 7;
            // 
            // gcolTenNganHang
            // 
            this.gcolTenNganHang.Caption = "Tên ngân hàng";
            this.gcolTenNganHang.FieldName = "TenNganHang";
            this.gcolTenNganHang.Name = "gcolTenNganHang";
            this.gcolTenNganHang.Visible = true;
            this.gcolTenNganHang.VisibleIndex = 8;
            // 
            // gcolTenChiNhanh
            // 
            this.gcolTenChiNhanh.Caption = "Tên chi nhánh";
            this.gcolTenChiNhanh.FieldName = "TenChiNhanh";
            this.gcolTenChiNhanh.Name = "gcolTenChiNhanh";
            this.gcolTenChiNhanh.Visible = true;
            this.gcolTenChiNhanh.VisibleIndex = 9;
            // 
            // gcolGhiChu
            // 
            this.gcolGhiChu.Caption = "Ghi chú";
            this.gcolGhiChu.FieldName = "GhiChu";
            this.gcolGhiChu.Name = "gcolGhiChu";
            this.gcolGhiChu.Visible = true;
            this.gcolGhiChu.VisibleIndex = 10;
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
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // fDanhMucNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.controlNavigator1);
            this.Controls.Add(this.gcDanhMucNhaCungCap);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Name = "fDanhMucNhaCungCap";
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.fDanhMucNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucNhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.XtraGrid.GridControl gcDanhMucNhaCungCap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMucNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenNhaCungCap;
        private DevExpress.XtraGrid.Columns.GridColumn gcolIdNhomNhaCungCap;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn gcolDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn gcolDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn gcolEmail;
        private DevExpress.XtraGrid.Columns.GridColumn gcolGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn gcolSoTaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenChiNhanh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}