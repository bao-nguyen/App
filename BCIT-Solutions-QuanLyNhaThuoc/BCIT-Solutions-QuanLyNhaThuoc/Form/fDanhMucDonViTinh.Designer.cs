namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fDanhMucDonViTinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucDonViTinh));
            this.gcDanhMucDonViTinh = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMucDonViTinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucDonViTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDanhMucDonViTinh
            // 
            this.gcDanhMucDonViTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhMucDonViTinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDanhMucDonViTinh.Location = new System.Drawing.Point(14, 12);
            this.gcDanhMucDonViTinh.MainView = this.gvDanhMucDonViTinh;
            this.gcDanhMucDonViTinh.Name = "gcDanhMucDonViTinh";
            this.gcDanhMucDonViTinh.Size = new System.Drawing.Size(756, 400);
            this.gcDanhMucDonViTinh.TabIndex = 16;
            this.gcDanhMucDonViTinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMucDonViTinh});
            // 
            // gvDanhMucDonViTinh
            // 
            this.gvDanhMucDonViTinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaDonViTinh,
            this.gcolTenDonViTinh,
            this.gcolGhiChu});
            this.gvDanhMucDonViTinh.GridControl = this.gcDanhMucDonViTinh;
            this.gvDanhMucDonViTinh.Name = "gvDanhMucDonViTinh";
            this.gvDanhMucDonViTinh.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gvDanhMucDonViTinh.OptionsSelection.MultiSelect = true;
            this.gvDanhMucDonViTinh.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhMucDonViTinh.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDanhMucDonViTinh.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhMucDonViTinh.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDanhMucDonViTinh_InitNewRow);
            this.gvDanhMucDonViTinh.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMucDonViTinh_RowUpdated);
            this.gvDanhMucDonViTinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvDanhMucDonViTinh_KeyDown);
            // 
            // gcolId
            // 
            this.gcolId.Caption = "Id";
            this.gcolId.FieldName = "Id";
            this.gcolId.Name = "gcolId";
            // 
            // gcolMaDonViTinh
            // 
            this.gcolMaDonViTinh.Caption = "Mã đơn vị tính";
            this.gcolMaDonViTinh.FieldName = "MaDonViTinh";
            this.gcolMaDonViTinh.Name = "gcolMaDonViTinh";
            this.gcolMaDonViTinh.Visible = true;
            this.gcolMaDonViTinh.VisibleIndex = 1;
            // 
            // gcolTenDonViTinh
            // 
            this.gcolTenDonViTinh.Caption = "Tên đơn vị tính";
            this.gcolTenDonViTinh.FieldName = "TenDonViTinh";
            this.gcolTenDonViTinh.Name = "gcolTenDonViTinh";
            this.gcolTenDonViTinh.Visible = true;
            this.gcolTenDonViTinh.VisibleIndex = 2;
            // 
            // gcolGhiChu
            // 
            this.gcolGhiChu.Caption = "Ghi chú";
            this.gcolGhiChu.FieldName = "GhiChu";
            this.gcolGhiChu.Name = "gcolGhiChu";
            this.gcolGhiChu.Visible = true;
            this.gcolGhiChu.VisibleIndex = 3;
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
            this.controlNavigator1.NavigatableControl = this.gcDanhMucDonViTinh;
            this.controlNavigator1.Size = new System.Drawing.Size(301, 24);
            this.controlNavigator1.TabIndex = 19;
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
            this.btnThoat.TabIndex = 18;
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
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // fDanhMucDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.gcDanhMucDonViTinh);
            this.Controls.Add(this.controlNavigator1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Name = "fDanhMucDonViTinh";
            this.Text = "Đơn vị tính";
            this.Load += new System.EventHandler(this.fDonViTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucDonViTinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhMucDonViTinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMucDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn gcolGhiChu;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
    }
}