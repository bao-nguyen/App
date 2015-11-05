namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fDanhMucBacSy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucBacSy));
            this.gcDanhMucBacSy = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMucBacSy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaBacSy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenBacSy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucBacSy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucBacSy)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDanhMucBacSy
            // 
            this.gcDanhMucBacSy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhMucBacSy.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDanhMucBacSy.Location = new System.Drawing.Point(12, 12);
            this.gcDanhMucBacSy.MainView = this.gvDanhMucBacSy;
            this.gcDanhMucBacSy.Name = "gcDanhMucBacSy";
            this.gcDanhMucBacSy.Size = new System.Drawing.Size(760, 400);
            this.gcDanhMucBacSy.TabIndex = 0;
            this.gcDanhMucBacSy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMucBacSy});
            this.gcDanhMucBacSy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcDanhMucBacSy_KeyDown);
            // 
            // gvDanhMucBacSy
            // 
            this.gvDanhMucBacSy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaBacSy,
            this.gcolTenBacSy,
            this.gcolDiaChi,
            this.gcolDienThoai,
            this.gcolGhiChu});
            this.gvDanhMucBacSy.GridControl = this.gcDanhMucBacSy;
            this.gvDanhMucBacSy.Name = "gvDanhMucBacSy";
            this.gvDanhMucBacSy.NewItemRowText = "Bấm vào đây để thêm mới";
            this.gvDanhMucBacSy.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gvDanhMucBacSy.OptionsSelection.MultiSelect = true;
            this.gvDanhMucBacSy.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhMucBacSy.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDanhMucBacSy.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhMucBacSy.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDanhMucBacSy_InitNewRow);
            this.gvDanhMucBacSy.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMucBacSy_RowUpdated);
            // 
            // gcolId
            // 
            this.gcolId.Caption = "Id";
            this.gcolId.FieldName = "IdBacSy";
            this.gcolId.Name = "gcolId";
            // 
            // gcolMaBacSy
            // 
            this.gcolMaBacSy.Caption = "Mã  bác sỹ";
            this.gcolMaBacSy.FieldName = "MaBacSy";
            this.gcolMaBacSy.Name = "gcolMaBacSy";
            this.gcolMaBacSy.Visible = true;
            this.gcolMaBacSy.VisibleIndex = 1;
            this.gcolMaBacSy.Width = 40;
            // 
            // gcolTenBacSy
            // 
            this.gcolTenBacSy.Caption = "Tên bác sỹ";
            this.gcolTenBacSy.FieldName = "TenBacSy";
            this.gcolTenBacSy.Name = "gcolTenBacSy";
            this.gcolTenBacSy.Visible = true;
            this.gcolTenBacSy.VisibleIndex = 2;
            this.gcolTenBacSy.Width = 150;
            // 
            // gcolDiaChi
            // 
            this.gcolDiaChi.Caption = "Địa chỉ";
            this.gcolDiaChi.FieldName = "DiaChi";
            this.gcolDiaChi.Name = "gcolDiaChi";
            this.gcolDiaChi.Visible = true;
            this.gcolDiaChi.VisibleIndex = 3;
            this.gcolDiaChi.Width = 250;
            // 
            // gcolDienThoai
            // 
            this.gcolDienThoai.Caption = "Điện thoại";
            this.gcolDienThoai.FieldName = "DienThoai";
            this.gcolDienThoai.Name = "gcolDienThoai";
            this.gcolDienThoai.Visible = true;
            this.gcolDienThoai.VisibleIndex = 4;
            this.gcolDienThoai.Width = 60;
            // 
            // gcolGhiChu
            // 
            this.gcolGhiChu.Caption = "Ghi chú";
            this.gcolGhiChu.FieldName = "GhiChu";
            this.gcolGhiChu.Name = "gcolGhiChu";
            this.gcolGhiChu.Visible = true;
            this.gcolGhiChu.VisibleIndex = 5;
            this.gcolGhiChu.Width = 93;
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
            this.btnXoa.TabIndex = 2;
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
            this.btnThoat.Location = new System.Drawing.Point(681, 419);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 30);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.controlNavigator1.NavigatableControl = this.gcDanhMucBacSy;
            this.controlNavigator1.Size = new System.Drawing.Size(258, 24);
            this.controlNavigator1.TabIndex = 4;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.controlNavigator1.TextStringFormat = " {0} của {1}";
            // 
            // fDanhMucBacSy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.controlNavigator1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gcDanhMucBacSy);
            this.Name = "fDanhMucBacSy";
            this.Text = "Danh mục bác sỹ";
            this.Load += new System.EventHandler(this.fDanhMucBacSy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucBacSy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucBacSy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhMucBacSy;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMucBacSy;
        private System.Windows.Forms.Button btnXoa;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaBacSy;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenBacSy;
        private DevExpress.XtraGrid.Columns.GridColumn gcolDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn gcolDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn gcolGhiChu;
        private System.Windows.Forms.Button btnThoat;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
    }
}