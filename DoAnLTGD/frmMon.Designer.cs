namespace DoAnLTGD
{
    partial class frmMon
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
            this.barBtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutCtrlMon = new DevExpress.XtraLayout.LayoutControl();
            this.txtEditTenMon = new DevExpress.XtraEditors.TextEdit();
            this.txtEditMaMon = new DevExpress.XtraEditors.TextEdit();
            this.txtEditNangKhieu = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridCtrlMon = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCtrlMon)).BeginInit();
            this.layoutCtrlMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTenMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMaMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditNangKhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlMon)).BeginInit();
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
            this.barBtnThem,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnSua, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barBtnThem
            // 
            this.barBtnThem.Caption = "Thêm";
            this.barBtnThem.Glyph = global::DoAnLTGD.Properties.Resources.Actions_list_add_user_icon1;
            this.barBtnThem.Id = 0;
            this.barBtnThem.Name = "barBtnThem";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1036, 62);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 773);
            this.barDockControlBottom.Size = new System.Drawing.Size(1036, 28);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 62);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 711);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1036, 62);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 711);
            // 
            // layoutCtrlMon
            // 
            this.layoutCtrlMon.Controls.Add(this.txtEditTenMon);
            this.layoutCtrlMon.Controls.Add(this.txtEditMaMon);
            this.layoutCtrlMon.Controls.Add(this.txtEditNangKhieu);
            this.layoutCtrlMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutCtrlMon.Location = new System.Drawing.Point(0, 62);
            this.layoutCtrlMon.Name = "layoutCtrlMon";
            this.layoutCtrlMon.Root = this.layoutControlGroup1;
            this.layoutCtrlMon.Size = new System.Drawing.Size(1036, 224);
            this.layoutCtrlMon.TabIndex = 4;
            this.layoutCtrlMon.Text = "layoutControl1";
            // 
            // txtEditTenMon
            // 
            this.txtEditTenMon.Location = new System.Drawing.Point(145, 64);
            this.txtEditTenMon.MenuManager = this.barManager1;
            this.txtEditTenMon.Name = "txtEditTenMon";
            this.txtEditTenMon.Size = new System.Drawing.Size(867, 32);
            this.txtEditTenMon.StyleController = this.layoutCtrlMon;
            this.txtEditTenMon.TabIndex = 6;
            // 
            // txtEditMaMon
            // 
            this.txtEditMaMon.Location = new System.Drawing.Point(145, 24);
            this.txtEditMaMon.MenuManager = this.barManager1;
            this.txtEditMaMon.Name = "txtEditMaMon";
            this.txtEditMaMon.Size = new System.Drawing.Size(867, 32);
            this.txtEditMaMon.StyleController = this.layoutCtrlMon;
            this.txtEditMaMon.TabIndex = 5;
            // 
            // txtEditNangKhieu
            // 
            this.txtEditNangKhieu.Location = new System.Drawing.Point(145, 104);
            this.txtEditNangKhieu.MenuManager = this.barManager1;
            this.txtEditNangKhieu.Name = "txtEditNangKhieu";
            this.txtEditNangKhieu.Size = new System.Drawing.Size(867, 32);
            this.txtEditNangKhieu.StyleController = this.layoutCtrlMon;
            this.txtEditNangKhieu.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1036, 224);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtEditNangKhieu;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(996, 104);
            this.layoutControlItem1.Text = "Năng Khiếu:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(115, 25);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtEditMaMon;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(996, 40);
            this.layoutControlItem2.Text = "Mã Môn:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(115, 25);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtEditTenMon;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(996, 40);
            this.layoutControlItem3.Text = "Tên Môn:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(115, 25);
            // 
            // gridCtrlMon
            // 
            this.gridCtrlMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCtrlMon.Location = new System.Drawing.Point(0, 286);
            this.gridCtrlMon.MainView = this.gridView1;
            this.gridCtrlMon.MenuManager = this.barManager1;
            this.gridCtrlMon.Name = "gridCtrlMon";
            this.gridCtrlMon.Size = new System.Drawing.Size(1036, 487);
            this.gridCtrlMon.TabIndex = 5;
            this.gridCtrlMon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridCtrlMon;
            this.gridView1.Name = "gridView1";
            // 
            // frmMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 801);
            this.Controls.Add(this.gridCtrlMon);
            this.Controls.Add(this.layoutCtrlMon);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMon";
            this.Text = "QUẢN LÝ MÔN HỌC";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCtrlMon)).EndInit();
            this.layoutCtrlMon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEditTenMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditMaMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditNangKhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCtrlMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnThem;
        private DevExpress.XtraBars.BarButtonItem barBtnXoa;
        private DevExpress.XtraBars.BarButtonItem barBtnSua;
        private DevExpress.XtraBars.BarButtonItem barBtnThoat;
        private DevExpress.XtraGrid.GridControl gridCtrlMon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutCtrlMon;
        private DevExpress.XtraEditors.TextEdit txtEditTenMon;
        private DevExpress.XtraEditors.TextEdit txtEditMaMon;
        private DevExpress.XtraEditors.TextEdit txtEditNangKhieu;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}