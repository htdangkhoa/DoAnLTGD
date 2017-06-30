namespace DoAnLTGD
{
    partial class frmDoiTuongcs
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnThemDoiTuong = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutCtrlDoiTuong = new DevExpress.XtraLayout.LayoutControl();
            this.txtEditNhomUuTien = new DevExpress.XtraEditors.TextEdit();
            this.txtEditTenDoiTuong = new DevExpress.XtraEditors.TextEdit();
            this.txtEditMaDoiTuong = new DevExpress.XtraEditors.TextEdit();
            this.txtDiemCong = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCtrlDoiTuong)).BeginInit();
            this.layoutCtrlDoiTuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditNhomUuTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTenDoiTuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMaDoiTuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnThemDoiTuong,
            this.barBtnXoa,
            this.barBtnSua,
            this.barBtnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThemDoiTuong, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barBtnThemDoiTuong
            // 
            this.barBtnThemDoiTuong.Caption = "Thêm";
            this.barBtnThemDoiTuong.Glyph = global::DoAnLTGD.Properties.Resources.Actions_list_add_user_icon1;
            this.barBtnThemDoiTuong.Id = 0;
            this.barBtnThemDoiTuong.Name = "barBtnThemDoiTuong";
            // 
            // barBtnXoa
            // 
            this.barBtnXoa.Caption = "Xóa";
            this.barBtnXoa.Glyph = global::DoAnLTGD.Properties.Resources.Button_Delete_icon1;
            this.barBtnXoa.Id = 1;
            this.barBtnXoa.Name = "barBtnXoa";
            // 
            // barBtnSua
            // 
            this.barBtnSua.Caption = "Sửa";
            this.barBtnSua.Glyph = global::DoAnLTGD.Properties.Resources.Pencil_icon__1_;
            this.barBtnSua.Id = 2;
            this.barBtnSua.Name = "barBtnSua";
            // 
            // barBtnThoat
            // 
            this.barBtnThoat.Caption = "Thoát";
            this.barBtnThoat.Glyph = global::DoAnLTGD.Properties.Resources.Button_Close_icon;
            this.barBtnThoat.Id = 3;
            this.barBtnThoat.Name = "barBtnThoat";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1138, 62);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 769);
            this.barDockControlBottom.Size = new System.Drawing.Size(1138, 28);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 62);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 707);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1138, 62);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 707);
            // 
            // layoutCtrlDoiTuong
            // 
            this.layoutCtrlDoiTuong.Controls.Add(this.txtEditNhomUuTien);
            this.layoutCtrlDoiTuong.Controls.Add(this.txtEditTenDoiTuong);
            this.layoutCtrlDoiTuong.Controls.Add(this.txtEditMaDoiTuong);
            this.layoutCtrlDoiTuong.Controls.Add(this.txtDiemCong);
            this.layoutCtrlDoiTuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutCtrlDoiTuong.Location = new System.Drawing.Point(0, 62);
            this.layoutCtrlDoiTuong.Name = "layoutCtrlDoiTuong";
            this.layoutCtrlDoiTuong.Root = this.layoutControlGroup1;
            this.layoutCtrlDoiTuong.Size = new System.Drawing.Size(1138, 248);
            this.layoutCtrlDoiTuong.TabIndex = 4;
            this.layoutCtrlDoiTuong.Text = "layoutControl1";
            // 
            // txtEditNhomUuTien
            // 
            this.txtEditNhomUuTien.Location = new System.Drawing.Point(178, 104);
            this.txtEditNhomUuTien.MenuManager = this.barManager1;
            this.txtEditNhomUuTien.Name = "txtEditNhomUuTien";
            this.txtEditNhomUuTien.Size = new System.Drawing.Size(936, 32);
            this.txtEditNhomUuTien.StyleController = this.layoutCtrlDoiTuong;
            this.txtEditNhomUuTien.TabIndex = 7;
            // 
            // txtEditTenDoiTuong
            // 
            this.txtEditTenDoiTuong.Location = new System.Drawing.Point(178, 64);
            this.txtEditTenDoiTuong.MenuManager = this.barManager1;
            this.txtEditTenDoiTuong.Name = "txtEditTenDoiTuong";
            this.txtEditTenDoiTuong.Size = new System.Drawing.Size(936, 32);
            this.txtEditTenDoiTuong.StyleController = this.layoutCtrlDoiTuong;
            this.txtEditTenDoiTuong.TabIndex = 6;
            // 
            // txtEditMaDoiTuong
            // 
            this.txtEditMaDoiTuong.Location = new System.Drawing.Point(178, 24);
            this.txtEditMaDoiTuong.MenuManager = this.barManager1;
            this.txtEditMaDoiTuong.Name = "txtEditMaDoiTuong";
            this.txtEditMaDoiTuong.Size = new System.Drawing.Size(936, 32);
            this.txtEditMaDoiTuong.StyleController = this.layoutCtrlDoiTuong;
            this.txtEditMaDoiTuong.TabIndex = 5;
            // 
            // txtDiemCong
            // 
            this.txtDiemCong.Location = new System.Drawing.Point(178, 144);
            this.txtDiemCong.MenuManager = this.barManager1;
            this.txtDiemCong.Name = "txtDiemCong";
            this.txtDiemCong.Size = new System.Drawing.Size(936, 32);
            this.txtDiemCong.StyleController = this.layoutCtrlDoiTuong;
            this.txtDiemCong.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1138, 248);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtDiemCong;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1098, 88);
            this.layoutControlItem1.Text = "Điểm Cộng:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(148, 25);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtEditMaDoiTuong;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1098, 40);
            this.layoutControlItem2.Text = "Mã Đối Tượng:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(148, 25);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtEditTenDoiTuong;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1098, 40);
            this.layoutControlItem3.Text = "Tên Đối Tượng:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(148, 25);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtEditNhomUuTien;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1098, 40);
            this.layoutControlItem4.Text = "Nhóm Ưu Tiên:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(148, 25);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 310);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1138, 459);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // frmDoiTuongcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 797);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.layoutCtrlDoiTuong);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDoiTuongcs";
            this.Text = "QUẢN LÝ ĐỐI TƯỢNG";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCtrlDoiTuong)).EndInit();
            this.layoutCtrlDoiTuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEditNhomUuTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTenDoiTuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMaDoiTuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barBtnThemDoiTuong;
        private DevExpress.XtraBars.BarButtonItem barBtnXoa;
        private DevExpress.XtraBars.BarButtonItem barBtnSua;
        private DevExpress.XtraBars.BarButtonItem barBtnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutCtrlDoiTuong;
        private DevExpress.XtraEditors.TextEdit txtEditNhomUuTien;
        private DevExpress.XtraEditors.TextEdit txtEditTenDoiTuong;
        private DevExpress.XtraEditors.TextEdit txtEditMaDoiTuong;
        private DevExpress.XtraEditors.TextEdit txtDiemCong;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;

    }
}