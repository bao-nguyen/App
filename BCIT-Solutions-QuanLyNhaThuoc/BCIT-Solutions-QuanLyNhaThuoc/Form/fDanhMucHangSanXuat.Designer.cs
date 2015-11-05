namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fDanhMucHangSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucHangSanXuat));
            this.gcDanhMucHangSanXuat = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMucHangSanXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaHangSanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenHangSanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucHangSanXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucHangSanXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDanhMucHangSanXuat
            // 
            this.gcDanhMucHangSanXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhMucHangSanXuat.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDanhMucHangSanXuat.Location = new System.Drawing.Point(14, 12);
            this.gcDanhMucHangSanXuat.MainView = this.gvDanhMucHangSanXuat;
            this.gcDanhMucHangSanXuat.Name = "gcDanhMucHangSanXuat";
            this.gcDanhMucHangSanXuat.Size = new System.Drawing.Size(756, 400);
            this.gcDanhMucHangSanXuat.TabIndex = 8;
            this.gcDanhMucHangSanXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMucHangSanXuat});
            // 
            // gvDanhMucHangSanXuat
            // 
            this.gvDanhMucHangSanXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaHangSanXuat,
            this.gcolTenHangSanXuat,
            this.gcolGhiChu});
            this.gvDanhMucHangSanXuat.GridControl = this.gcDanhMucHangSanXuat;
            this.gvDanhMucHangSanXuat.Name = "gvDanhMucHangSanXuat";
            this.gvDanhMucHangSanXuat.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gvDanhMucHangSanXuat.OptionsSelection.MultiSelect = true;
            this.gvDanhMucHangSanXuat.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhMucHangSanXuat.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDanhMucHangSanXuat.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhMucHangSanXuat.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDanhMucHangSanXuat_InitNewRow);
            this.gvDanhMucHangSanXuat.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMucHangSanXuat_RowUpdated);
            this.gvDanhMucHangSanXuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvDanhMucHangSanXuat_KeyDown);
            // 
            // gcolId
            // 
            this.gcolId.Caption = "Id";
            this.gcolId.FieldName = "Id";
            this.gcolId.Name = "gcolId";
            // 
            // gcolMaHangSanXuat
            // 
            this.gcolMaHangSanXuat.Caption = "Mã hãng sản xuất";
            this.gcolMaHangSanXuat.FieldName = "MaHangSanXuat";
            this.gcolMaHangSanXuat.Name = "gcolMaHangSanXuat";
            this.gcolMaHangSanXuat.Visible = true;
            this.gcolMaHangSanXuat.VisibleIndex = 1;
            // 
            // gcolTenHangSanXuat
            // 
            this.gcolTenHangSanXuat.Caption = "Tên hãng sản xuất";
            this.gcolTenHangSanXuat.FieldName = "TenHangSanXuat";
            this.gcolTenHangSanXuat.Name = "gcolTenHangSanXuat";
            this.gcolTenHangSanXuat.Visible = true;
            this.gcolTenHangSanXuat.VisibleIndex = 2;
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
            this.controlNavigator1.NavigatableControl = this.gcDanhMucHangSanXuat;
            this.controlNavigator1.Size = new System.Drawing.Size(301, 24);
            this.controlNavigator1.TabIndex = 11;
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
            this.btnThoat.TabIndex = 10;
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
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // fDanhMucHangSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.gcDanhMucHangSanXuat);
            this.Controls.Add(this.controlNavigator1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Name = "fDanhMucHangSanXuat";
            this.Text = "Hãng sản xuất";
            this.Load += new System.EventHandler(this.fDanhMucHangSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucHangSanXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucHangSanXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhMucHangSanXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMucHangSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaHangSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenHangSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn gcolGhiChu;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
    }
}