namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fDanhMucChucDanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucChucDanh));
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gcDanhMucChucDanh = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMucChuDanh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucChucDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucChuDanh)).BeginInit();
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
            this.btnThoat.Location = new System.Drawing.Point(682, 419);
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
            // gcDanhMucChucDanh
            // 
            this.gcDanhMucChucDanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhMucChucDanh.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDanhMucChucDanh.Location = new System.Drawing.Point(12, 12);
            this.gcDanhMucChucDanh.MainView = this.gvDanhMucChuDanh;
            this.gcDanhMucChucDanh.Name = "gcDanhMucChucDanh";
            this.gcDanhMucChucDanh.Size = new System.Drawing.Size(760, 400);
            this.gcDanhMucChucDanh.TabIndex = 12;
            this.gcDanhMucChucDanh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMucChuDanh});
            this.gcDanhMucChucDanh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcDanhMucChucDanh_KeyDown);
            // 
            // gvDanhMucChuDanh
            // 
            this.gvDanhMucChuDanh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaChucDanh,
            this.gcolChucDanh,
            this.gcolGhiChu});
            this.gvDanhMucChuDanh.GridControl = this.gcDanhMucChucDanh;
            this.gvDanhMucChuDanh.Name = "gvDanhMucChuDanh";
            this.gvDanhMucChuDanh.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gvDanhMucChuDanh.OptionsSelection.MultiSelect = true;
            this.gvDanhMucChuDanh.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhMucChuDanh.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDanhMucChuDanh.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhMucChuDanh.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDanhMucChuDanh_InitNewRow);
            this.gvDanhMucChuDanh.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMucChuDanh_RowUpdated);
            // 
            // gcolId
            // 
            this.gcolId.Caption = "Id";
            this.gcolId.FieldName = "Id";
            this.gcolId.Name = "gcolId";
            // 
            // gcolMaChucDanh
            // 
            this.gcolMaChucDanh.Caption = "Mã chức danh";
            this.gcolMaChucDanh.FieldName = "MaChucDanh";
            this.gcolMaChucDanh.Name = "gcolMaChucDanh";
            this.gcolMaChucDanh.Visible = true;
            this.gcolMaChucDanh.VisibleIndex = 1;
            // 
            // gcolChucDanh
            // 
            this.gcolChucDanh.Caption = "Chức danh";
            this.gcolChucDanh.FieldName = "TenChucDanh";
            this.gcolChucDanh.Name = "gcolChucDanh";
            this.gcolChucDanh.Visible = true;
            this.gcolChucDanh.VisibleIndex = 2;
            // 
            // gcolGhiChu
            // 
            this.gcolGhiChu.Caption = "Ghi chú";
            this.gcolGhiChu.FieldName = "GhiChu";
            this.gcolGhiChu.Name = "gcolGhiChu";
            this.gcolGhiChu.Visible = true;
            this.gcolGhiChu.VisibleIndex = 3;
            // 
            // fDanhMucChucDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.gcDanhMucChucDanh);
            this.Controls.Add(this.controlNavigator1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Name = "fDanhMucChucDanh";
            this.Text = "Danh mục chức danh";
            this.Load += new System.EventHandler(this.fDanhMucChucDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucChucDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucChuDanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private DevExpress.XtraGrid.GridControl gcDanhMucChucDanh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMucChuDanh;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn gcolChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn gcolGhiChu;
    }
}