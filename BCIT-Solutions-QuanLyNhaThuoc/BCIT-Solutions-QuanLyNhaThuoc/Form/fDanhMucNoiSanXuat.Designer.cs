namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fDanhMucNoiSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucNoiSanXuat));
            this.gcDanhMucNoiSanXuat = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMucNoiSanXuat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaNoiSanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenNoiSanXuat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucNoiSanXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucNoiSanXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDanhMucNoiSanXuat
            // 
            this.gcDanhMucNoiSanXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhMucNoiSanXuat.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDanhMucNoiSanXuat.Location = new System.Drawing.Point(14, 12);
            this.gcDanhMucNoiSanXuat.MainView = this.gvDanhMucNoiSanXuat;
            this.gcDanhMucNoiSanXuat.Name = "gcDanhMucNoiSanXuat";
            this.gcDanhMucNoiSanXuat.Size = new System.Drawing.Size(756, 400);
            this.gcDanhMucNoiSanXuat.TabIndex = 12;
            this.gcDanhMucNoiSanXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMucNoiSanXuat});
            // 
            // gvDanhMucNoiSanXuat
            // 
            this.gvDanhMucNoiSanXuat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaNoiSanXuat,
            this.gcolTenNoiSanXuat,
            this.gcolGhiChu});
            this.gvDanhMucNoiSanXuat.GridControl = this.gcDanhMucNoiSanXuat;
            this.gvDanhMucNoiSanXuat.Name = "gvDanhMucNoiSanXuat";
            this.gvDanhMucNoiSanXuat.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gvDanhMucNoiSanXuat.OptionsSelection.MultiSelect = true;
            this.gvDanhMucNoiSanXuat.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhMucNoiSanXuat.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDanhMucNoiSanXuat.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhMucNoiSanXuat.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDanhMucNoiSanXuat_InitNewRow);
            this.gvDanhMucNoiSanXuat.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMucNoiSanXuat_RowUpdated);
            this.gvDanhMucNoiSanXuat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvDanhMucNoiSanXuat_KeyDown);
            // 
            // gcolId
            // 
            this.gcolId.Caption = "Id";
            this.gcolId.FieldName = "Id";
            this.gcolId.Name = "gcolId";
            // 
            // gcolMaNoiSanXuat
            // 
            this.gcolMaNoiSanXuat.Caption = "Mã nơi sản xuất";
            this.gcolMaNoiSanXuat.FieldName = "MaNoiSanXuat";
            this.gcolMaNoiSanXuat.Name = "gcolMaNoiSanXuat";
            this.gcolMaNoiSanXuat.Visible = true;
            this.gcolMaNoiSanXuat.VisibleIndex = 1;
            // 
            // gcolTenNoiSanXuat
            // 
            this.gcolTenNoiSanXuat.Caption = "Nơi sản xuất";
            this.gcolTenNoiSanXuat.FieldName = "TenNoiSanXuat";
            this.gcolTenNoiSanXuat.Name = "gcolTenNoiSanXuat";
            this.gcolTenNoiSanXuat.Visible = true;
            this.gcolTenNoiSanXuat.VisibleIndex = 2;
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
            this.controlNavigator1.NavigatableControl = this.gcDanhMucNoiSanXuat;
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
            // fDanhMucNoiSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.gcDanhMucNoiSanXuat);
            this.Controls.Add(this.controlNavigator1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Name = "fDanhMucNoiSanXuat";
            this.Text = "Nơi sản xuất";
            this.Load += new System.EventHandler(this.fDanhMucNoiSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucNoiSanXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucNoiSanXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhMucNoiSanXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMucNoiSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaNoiSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenNoiSanXuat;
        private DevExpress.XtraGrid.Columns.GridColumn gcolGhiChu;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
    }
}