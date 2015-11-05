namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fTest
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
            this.gcDonViTinh = new DevExpress.XtraGrid.GridControl();
            this.gvDonViTinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonViTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDonViTinh
            // 
            this.gcDonViTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDonViTinh.Location = new System.Drawing.Point(12, 12);
            this.gcDonViTinh.MainView = this.gvDonViTinh;
            this.gcDonViTinh.Name = "gcDonViTinh";
            this.gcDonViTinh.Size = new System.Drawing.Size(760, 437);
            this.gcDonViTinh.TabIndex = 0;
            this.gcDonViTinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDonViTinh});
            // 
            // gvDonViTinh
            // 
            this.gvDonViTinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaDonViTinh,
            this.gcolTenDonViTinh,
            this.gcolGhiChu});
            this.gvDonViTinh.GridControl = this.gcDonViTinh;
            this.gvDonViTinh.Name = "gvDonViTinh";
            this.gvDonViTinh.OptionsSelection.MultiSelect = true;
            this.gvDonViTinh.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDonViTinh.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDonViTinh.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDonViTinh_InitNewRow);
            this.gvDonViTinh.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMucDonViTinh_RowUpdated);
            // 
            // gcolId
            // 
            this.gcolId.Caption = "Id";
            this.gcolId.FieldName = "Id";
            this.gcolId.Name = "gcolId";
            // 
            // gcolMaDonViTinh
            // 
            this.gcolMaDonViTinh.Caption = "gridColumn1";
            this.gcolMaDonViTinh.FieldName = "MaDonViTinh";
            this.gcolMaDonViTinh.Name = "gcolMaDonViTinh";
            this.gcolMaDonViTinh.Visible = true;
            this.gcolMaDonViTinh.VisibleIndex = 1;
            // 
            // gcolTenDonViTinh
            // 
            this.gcolTenDonViTinh.Caption = "gridColumn1";
            this.gcolTenDonViTinh.FieldName = "TenDonViTinh";
            this.gcolTenDonViTinh.Name = "gcolTenDonViTinh";
            this.gcolTenDonViTinh.Visible = true;
            this.gcolTenDonViTinh.VisibleIndex = 2;
            // 
            // gcolGhiChu
            // 
            this.gcolGhiChu.Caption = "gridColumn1";
            this.gcolGhiChu.FieldName = "GhiChu";
            this.gcolGhiChu.Name = "gcolGhiChu";
            this.gcolGhiChu.Visible = true;
            this.gcolGhiChu.VisibleIndex = 3;
            // 
            // fTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.gcDonViTinh);
            this.Name = "fTest";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.fTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonViTinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDonViTinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn gcolGhiChu;
    }
}