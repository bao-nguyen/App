namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fDanhMucKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucKhachHang));
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.gcDanhMucKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMucKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolHoKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolIdNhomKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gcolDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucKhachHang)).BeginInit();
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
            this.controlNavigator1.NavigatableControl = this.gcDanhMucKhachHang;
            this.controlNavigator1.Size = new System.Drawing.Size(301, 24);
            this.controlNavigator1.TabIndex = 18;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.controlNavigator1.TextStringFormat = " {0} của {1}";
            // 
            // gcDanhMucKhachHang
            // 
            this.gcDanhMucKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhMucKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDanhMucKhachHang.Location = new System.Drawing.Point(12, 12);
            this.gcDanhMucKhachHang.MainView = this.gvDanhMucKhachHang;
            this.gcDanhMucKhachHang.Name = "gcDanhMucKhachHang";
            this.gcDanhMucKhachHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gcDanhMucKhachHang.Size = new System.Drawing.Size(760, 400);
            this.gcDanhMucKhachHang.TabIndex = 15;
            this.gcDanhMucKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMucKhachHang});
            // 
            // gvDanhMucKhachHang
            // 
            this.gvDanhMucKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaKhachHang,
            this.gcolHoKhachHang,
            this.gcolTenKhachHang,
            this.gcolIdNhomKhachHang,
            this.gcolDiaChi,
            this.gcolDienThoai,
            this.gcolNgaySinh,
            this.gcolEmail,
            this.gcolGhiChu});
            this.gvDanhMucKhachHang.GridControl = this.gcDanhMucKhachHang;
            this.gvDanhMucKhachHang.Name = "gvDanhMucKhachHang";
            this.gvDanhMucKhachHang.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gvDanhMucKhachHang.OptionsSelection.MultiSelect = true;
            this.gvDanhMucKhachHang.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhMucKhachHang.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDanhMucKhachHang.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhMucKhachHang.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDanhMucKhachHang_InitNewRow);
            this.gvDanhMucKhachHang.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMucKhachHang_RowUpdated);
            this.gvDanhMucKhachHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvDanhMucKhachHang_KeyDown);
            // 
            // gcolId
            // 
            this.gcolId.Caption = "Id";
            this.gcolId.FieldName = "Id";
            this.gcolId.Name = "gcolId";
            // 
            // gcolMaKhachHang
            // 
            this.gcolMaKhachHang.Caption = "Mã khách hàng";
            this.gcolMaKhachHang.FieldName = "MaKhachHang";
            this.gcolMaKhachHang.Name = "gcolMaKhachHang";
            this.gcolMaKhachHang.Visible = true;
            this.gcolMaKhachHang.VisibleIndex = 1;
            // 
            // gcolHoKhachHang
            // 
            this.gcolHoKhachHang.Caption = "Họ";
            this.gcolHoKhachHang.FieldName = "HoKhachHang";
            this.gcolHoKhachHang.Name = "gcolHoKhachHang";
            this.gcolHoKhachHang.Visible = true;
            this.gcolHoKhachHang.VisibleIndex = 2;
            // 
            // gcolTenKhachHang
            // 
            this.gcolTenKhachHang.Caption = "Tên";
            this.gcolTenKhachHang.FieldName = "TenKhachHang";
            this.gcolTenKhachHang.Name = "gcolTenKhachHang";
            this.gcolTenKhachHang.Visible = true;
            this.gcolTenKhachHang.VisibleIndex = 3;
            // 
            // gcolIdNhomKhachHang
            // 
            this.gcolIdNhomKhachHang.Caption = "Nhóm khách hàng";
            this.gcolIdNhomKhachHang.ColumnEdit = this.repositoryItemComboBox1;
            this.gcolIdNhomKhachHang.FieldName = "IdNhomKhachHang";
            this.gcolIdNhomKhachHang.Name = "gcolIdNhomKhachHang";
            this.gcolIdNhomKhachHang.Visible = true;
            this.gcolIdNhomKhachHang.VisibleIndex = 5;
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
            this.gcolDiaChi.VisibleIndex = 6;
            // 
            // gcolDienThoai
            // 
            this.gcolDienThoai.Caption = "Điện thoại";
            this.gcolDienThoai.FieldName = "DienThoai";
            this.gcolDienThoai.Name = "gcolDienThoai";
            this.gcolDienThoai.Visible = true;
            this.gcolDienThoai.VisibleIndex = 7;
            // 
            // gcolNgaySinh
            // 
            this.gcolNgaySinh.Caption = "Ngày sinh";
            this.gcolNgaySinh.FieldName = "NgaySinh";
            this.gcolNgaySinh.Name = "gcolNgaySinh";
            this.gcolNgaySinh.Visible = true;
            this.gcolNgaySinh.VisibleIndex = 8;
            // 
            // gcolEmail
            // 
            this.gcolEmail.Caption = "Email";
            this.gcolEmail.FieldName = "Email";
            this.gcolEmail.Name = "gcolEmail";
            this.gcolEmail.Visible = true;
            this.gcolEmail.VisibleIndex = 4;
            // 
            // gcolGhiChu
            // 
            this.gcolGhiChu.Caption = "Ghi chú";
            this.gcolGhiChu.Name = "gcolGhiChu";
            this.gcolGhiChu.Visible = true;
            this.gcolGhiChu.VisibleIndex = 9;
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
            this.btnXoa.TabIndex = 16;
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
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // fDanhMucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.controlNavigator1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.gcDanhMucKhachHang);
            this.Name = "fDanhMucKhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.fDanhMucKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.XtraGrid.GridControl gcDanhMucKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMucKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gcolIdNhomKhachHang;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn gcolDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn gcolDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn gcolNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn gcolGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn gcolEmail;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraGrid.Columns.GridColumn gcolHoKhachHang;
    }
}