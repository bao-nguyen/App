namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fDanhMucNhomHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucNhomHangHoa));
            this.gcDanhMucNhomHangHoa = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMucNhomHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaNhomHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenNhomHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucNhomHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucNhomHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDanhMucNhomHangHoa
            // 
            this.gcDanhMucNhomHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhMucNhomHangHoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDanhMucNhomHangHoa.Location = new System.Drawing.Point(14, 12);
            this.gcDanhMucNhomHangHoa.MainView = this.gvDanhMucNhomHangHoa;
            this.gcDanhMucNhomHangHoa.Name = "gcDanhMucNhomHangHoa";
            this.gcDanhMucNhomHangHoa.Size = new System.Drawing.Size(756, 400);
            this.gcDanhMucNhomHangHoa.TabIndex = 12;
            this.gcDanhMucNhomHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMucNhomHangHoa});
            // 
            // gvDanhMucNhomHangHoa
            // 
            this.gvDanhMucNhomHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaNhomHangHoa,
            this.gcolTenNhomHangHoa,
            this.gcolGhiChu});
            this.gvDanhMucNhomHangHoa.GridControl = this.gcDanhMucNhomHangHoa;
            this.gvDanhMucNhomHangHoa.Name = "gvDanhMucNhomHangHoa";
            this.gvDanhMucNhomHangHoa.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gvDanhMucNhomHangHoa.OptionsSelection.MultiSelect = true;
            this.gvDanhMucNhomHangHoa.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhMucNhomHangHoa.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDanhMucNhomHangHoa.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhMucNhomHangHoa.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDanhMucNhomHangHoa_InitNewRow);
            this.gvDanhMucNhomHangHoa.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMucNhomHangHoa_RowUpdated);
            this.gvDanhMucNhomHangHoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvDanhMucNhomHangHoa_KeyDown);
            // 
            // gcolId
            // 
            this.gcolId.Caption = "Id";
            this.gcolId.FieldName = "Id";
            this.gcolId.Name = "gcolId";
            // 
            // gcolMaNhomHangHoa
            // 
            this.gcolMaNhomHangHoa.Caption = "Mã nhóm hàng hóa";
            this.gcolMaNhomHangHoa.FieldName = "MaNhomHangHoa";
            this.gcolMaNhomHangHoa.Name = "gcolMaNhomHangHoa";
            this.gcolMaNhomHangHoa.Visible = true;
            this.gcolMaNhomHangHoa.VisibleIndex = 1;
            // 
            // gcolTenNhomHangHoa
            // 
            this.gcolTenNhomHangHoa.Caption = "Tên nhóm hàng hóa";
            this.gcolTenNhomHangHoa.FieldName = "TenNhomHangHoa";
            this.gcolTenNhomHangHoa.Name = "gcolTenNhomHangHoa";
            this.gcolTenNhomHangHoa.Visible = true;
            this.gcolTenNhomHangHoa.VisibleIndex = 2;
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
            this.controlNavigator1.NavigatableControl = this.gcDanhMucNhomHangHoa;
            this.controlNavigator1.Size = new System.Drawing.Size(301, 24);
            this.controlNavigator1.TabIndex = 15;
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
            this.btnThoat.TabIndex = 14;
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
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // fDanhMucNhomHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.gcDanhMucNhomHangHoa);
            this.Controls.Add(this.controlNavigator1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Name = "fDanhMucNhomHangHoa";
            this.Text = "Nhóm hàng hóa";
            this.Load += new System.EventHandler(this.fDanhMucNhomHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucNhomHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucNhomHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhMucNhomHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMucNhomHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaNhomHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenNhomHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn gcolGhiChu;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
    }
}