namespace BCIT_Solutions_QuanLyNhaThuoc
{
    partial class fDanhMucPhanHe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhMucPhanHe));
            this.gcDanhMucPhanHe = new DevExpress.XtraGrid.GridControl();
            this.gvDanhMucPhanHe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcolId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolMaPhanHe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolTenPhanHe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlNavigator1 = new DevExpress.XtraEditors.ControlNavigator();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucPhanHe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucPhanHe)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDanhMucPhanHe
            // 
            this.gcDanhMucPhanHe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDanhMucPhanHe.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDanhMucPhanHe.Location = new System.Drawing.Point(14, 12);
            this.gcDanhMucPhanHe.MainView = this.gvDanhMucPhanHe;
            this.gcDanhMucPhanHe.Name = "gcDanhMucPhanHe";
            this.gcDanhMucPhanHe.Size = new System.Drawing.Size(756, 400);
            this.gcDanhMucPhanHe.TabIndex = 8;
            this.gcDanhMucPhanHe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhMucPhanHe});
            // 
            // gvDanhMucPhanHe
            // 
            this.gvDanhMucPhanHe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcolId,
            this.gcolMaPhanHe,
            this.gcolTenPhanHe});
            this.gvDanhMucPhanHe.GridControl = this.gcDanhMucPhanHe;
            this.gvDanhMucPhanHe.Name = "gvDanhMucPhanHe";
            this.gvDanhMucPhanHe.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gvDanhMucPhanHe.OptionsSelection.MultiSelect = true;
            this.gvDanhMucPhanHe.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvDanhMucPhanHe.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvDanhMucPhanHe.OptionsView.ShowAutoFilterRow = true;
            this.gvDanhMucPhanHe.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvDanhMucPhanHe_InitNewRow);
            this.gvDanhMucPhanHe.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvDanhMucPhanHe_RowUpdated);
            this.gvDanhMucPhanHe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvDanhMucPhanHe_KeyDown);
            // 
            // gcolId
            // 
            this.gcolId.Caption = "Id";
            this.gcolId.FieldName = "Id";
            this.gcolId.Name = "gcolId";
            // 
            // gcolMaPhanHe
            // 
            this.gcolMaPhanHe.Caption = "Mã phân hệ";
            this.gcolMaPhanHe.FieldName = "MaPhanHe";
            this.gcolMaPhanHe.Name = "gcolMaPhanHe";
            this.gcolMaPhanHe.Visible = true;
            this.gcolMaPhanHe.VisibleIndex = 1;
            // 
            // gcolTenPhanHe
            // 
            this.gcolTenPhanHe.Caption = "Tên phân hệ";
            this.gcolTenPhanHe.FieldName = "TenPhanHe";
            this.gcolTenPhanHe.Name = "gcolTenPhanHe";
            this.gcolTenPhanHe.Visible = true;
            this.gcolTenPhanHe.VisibleIndex = 2;
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
            this.controlNavigator1.NavigatableControl = this.gcDanhMucPhanHe;
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
            // fDanhMucPhanHe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.gcDanhMucPhanHe);
            this.Controls.Add(this.controlNavigator1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Name = "fDanhMucPhanHe";
            this.Text = "Phân hệ";
            this.Load += new System.EventHandler(this.fDanhMucPhanHe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhMucPhanHe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhMucPhanHe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhMucPhanHe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhMucPhanHe;
        private DevExpress.XtraGrid.Columns.GridColumn gcolId;
        private DevExpress.XtraGrid.Columns.GridColumn gcolMaPhanHe;
        private DevExpress.XtraGrid.Columns.GridColumn gcolTenPhanHe;
        private DevExpress.XtraEditors.ControlNavigator controlNavigator1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
    }
}