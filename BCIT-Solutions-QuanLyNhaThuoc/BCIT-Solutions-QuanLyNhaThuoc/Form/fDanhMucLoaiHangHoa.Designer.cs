namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fDanhMucLoaiHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucLoaiHangHoa));
            this.gcDanhMucLoaiHangHoa = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMucLoaiHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaLoaiHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenLoaiHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucLoaiHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucLoaiHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDanhMucLoaiHangHoa
            // 
            this.gcDanhMucLoaiHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhMucLoaiHangHoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDanhMucLoaiHangHoa.Location = new System.Drawing.Point(14, 12);
            this.gcDanhMucLoaiHangHoa.MainView = this.gvDanhMucLoaiHangHoa;
            this.gcDanhMucLoaiHangHoa.Name = "gcDanhMucLoaiHangHoa";
            this.gcDanhMucLoaiHangHoa.Size = new System.Drawing.Size(756, 400);
            this.gcDanhMucLoaiHangHoa.TabIndex = 12;
            this.gcDanhMucLoaiHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMucLoaiHangHoa});
            // 
            // gvDanhMucLoaiHangHoa
            // 
            this.gvDanhMucLoaiHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaLoaiHangHoa,
            this.gcolTenLoaiHangHoa,
            this.gcolGhiChu});
            this.gvDanhMucLoaiHangHoa.GridControl = this.gcDanhMucLoaiHangHoa;
            this.gvDanhMucLoaiHangHoa.Name = "gvDanhMucLoaiHangHoa";
            this.gvDanhMucLoaiHangHoa.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gvDanhMucLoaiHangHoa.OptionsSelection.MultiSelect = true;
            this.gvDanhMucLoaiHangHoa.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhMucLoaiHangHoa.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDanhMucLoaiHangHoa.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhMucLoaiHangHoa.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDanhMucLoaiHangHoa_InitNewRow);
            this.gvDanhMucLoaiHangHoa.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMucLoaiHangHoa_RowUpdated);
            this.gvDanhMucLoaiHangHoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvDanhMucLoaiHangHoa_KeyDown);
            // 
            // gcolId
            // 
            this.gcolId.Caption = "Id";
            this.gcolId.FieldName = "Id";
            this.gcolId.Name = "gcolId";
            // 
            // gcolMaLoaiHangHoa
            // 
            this.gcolMaLoaiHangHoa.Caption = "Mã loại hàng hóa";
            this.gcolMaLoaiHangHoa.FieldName = "MaLoaiHangHoa";
            this.gcolMaLoaiHangHoa.Name = "gcolMaLoaiHangHoa";
            this.gcolMaLoaiHangHoa.Visible = true;
            this.gcolMaLoaiHangHoa.VisibleIndex = 1;
            // 
            // gcolTenLoaiHangHoa
            // 
            this.gcolTenLoaiHangHoa.Caption = "Tên loại hàng hóa";
            this.gcolTenLoaiHangHoa.FieldName = "TenLoaiHangHoa";
            this.gcolTenLoaiHangHoa.Name = "gcolTenLoaiHangHoa";
            this.gcolTenLoaiHangHoa.Visible = true;
            this.gcolTenLoaiHangHoa.VisibleIndex = 2;
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
            this.controlNavigator1.NavigatableControl = this.gcDanhMucLoaiHangHoa;
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
            // fDanhMucLoaiHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.gcDanhMucLoaiHangHoa);
            this.Controls.Add(this.controlNavigator1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Name = "fDanhMucLoaiHangHoa";
            this.Text = "Loại hàng hóa";
            this.Load += new System.EventHandler(this.fDanhMucLoaiHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucLoaiHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucLoaiHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhMucLoaiHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMucLoaiHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaLoaiHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenLoaiHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn gcolGhiChu;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
    }
}