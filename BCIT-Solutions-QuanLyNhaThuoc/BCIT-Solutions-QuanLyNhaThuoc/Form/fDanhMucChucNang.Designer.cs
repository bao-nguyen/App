namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fDanhMucChucNang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucChucNang));
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.gcDanhMucChucNang = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMucChucNang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolIdPhanHe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gcolTenForm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucChucNang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucChucNang)).BeginInit();
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
            this.controlNavigator1.NavigatableControl = this.gcDanhMucChucNang;
            this.controlNavigator1.Size = new System.Drawing.Size(301, 24);
            this.controlNavigator1.TabIndex = 18;
            this.controlNavigator1.Text = "controlNavigator1";
            this.controlNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.controlNavigator1.TextStringFormat = " {0} của {1}";
            // 
            // gcDanhMucChucNang
            // 
            this.gcDanhMucChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhMucChucNang.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDanhMucChucNang.Location = new System.Drawing.Point(12, 12);
            this.gcDanhMucChucNang.MainView = this.gvDanhMucChucNang;
            this.gcDanhMucChucNang.Name = "gcDanhMucChucNang";
            this.gcDanhMucChucNang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gcDanhMucChucNang.Size = new System.Drawing.Size(760, 400);
            this.gcDanhMucChucNang.TabIndex = 15;
            this.gcDanhMucChucNang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMucChucNang});
            // 
            // gvDanhMucChucNang
            // 
            this.gvDanhMucChucNang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaChucNang,
            this.gcolTenChucNang,
            this.gcolIdPhanHe,
            this.gcolTenForm});
            this.gvDanhMucChucNang.GridControl = this.gcDanhMucChucNang;
            this.gvDanhMucChucNang.Name = "gvDanhMucChucNang";
            this.gvDanhMucChucNang.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gvDanhMucChucNang.OptionsSelection.MultiSelect = true;
            this.gvDanhMucChucNang.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhMucChucNang.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDanhMucChucNang.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhMucChucNang.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDanhMucChucNang_InitNewRow);
            this.gvDanhMucChucNang.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMucChucNang_RowUpdated);
            this.gvDanhMucChucNang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvDanhMucChucNang_KeyDown);
            // 
            // gcolId
            // 
            this.gcolId.Caption = "Id";
            this.gcolId.FieldName = "Id";
            this.gcolId.Name = "gcolId";
            // 
            // gcolMaChucNang
            // 
            this.gcolMaChucNang.Caption = "Mã chức năng";
            this.gcolMaChucNang.FieldName = "MaChucNang";
            this.gcolMaChucNang.Name = "gcolMaChucNang";
            this.gcolMaChucNang.Visible = true;
            this.gcolMaChucNang.VisibleIndex = 1;
            // 
            // gcolTenChucNang
            // 
            this.gcolTenChucNang.Caption = "Tên chức năng";
            this.gcolTenChucNang.FieldName = "TenChucNang";
            this.gcolTenChucNang.Name = "gcolTenChucNang";
            this.gcolTenChucNang.Visible = true;
            this.gcolTenChucNang.VisibleIndex = 2;
            // 
            // gcolIdPhanHe
            // 
            this.gcolIdPhanHe.Caption = "Phân hệ";
            this.gcolIdPhanHe.ColumnEdit = this.repositoryItemComboBox1;
            this.gcolIdPhanHe.FieldName = "IdPhanHe";
            this.gcolIdPhanHe.Name = "gcolIdPhanHe";
            this.gcolIdPhanHe.Visible = true;
            this.gcolIdPhanHe.VisibleIndex = 3;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // gcolTenForm
            // 
            this.gcolTenForm.Caption = "Tên form";
            this.gcolTenForm.FieldName = "TenForm";
            this.gcolTenForm.Name = "gcolTenForm";
            this.gcolTenForm.OptionsColumn.AllowEdit = false;
            this.gcolTenForm.OptionsColumn.ReadOnly = true;
            this.gcolTenForm.Visible = true;
            this.gcolTenForm.VisibleIndex = 5;
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
            // fDanhMucChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.controlNavigator1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.gcDanhMucChucNang);
            this.Name = "fDanhMucChucNang";
            this.Text = "Chức năng";
            this.Load += new System.EventHandler(this.fDanhMucChucNang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucChucNang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private DevExpress.XtraGrid.GridControl gcDanhMucChucNang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMucChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn gcolIdPhanHe;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenForm;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}