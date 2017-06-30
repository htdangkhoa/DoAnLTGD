namespace DoAnLTGD
{
    partial class frmDangKy
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
            this.txtEditDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditNhapMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtEditNhapLaiMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.btnĐangKy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.grpCtrlDangKy = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditNhapMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditNhapLaiMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCtrlDangKy)).BeginInit();
            this.grpCtrlDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEditDangNhap
            // 
            this.txtEditDangNhap.Location = new System.Drawing.Point(236, 102);
            this.txtEditDangNhap.Name = "txtEditDangNhap";
            this.txtEditDangNhap.Size = new System.Drawing.Size(466, 32);
            this.txtEditDangNhap.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 105);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(155, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên Đăng Nhập:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 167);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(151, 25);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Nhập Mật Khẩu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 231);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(184, 25);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Nhập Lại Mật Khẩu:";
            // 
            // txtEditNhapMatKhau
            // 
            this.txtEditNhapMatKhau.Location = new System.Drawing.Point(236, 160);
            this.txtEditNhapMatKhau.Name = "txtEditNhapMatKhau";
            this.txtEditNhapMatKhau.Size = new System.Drawing.Size(466, 32);
            this.txtEditNhapMatKhau.TabIndex = 4;
            // 
            // txtEditNhapLaiMatKhau
            // 
            this.txtEditNhapLaiMatKhau.Location = new System.Drawing.Point(236, 228);
            this.txtEditNhapLaiMatKhau.Name = "txtEditNhapLaiMatKhau";
            this.txtEditNhapLaiMatKhau.Size = new System.Drawing.Size(466, 32);
            this.txtEditNhapLaiMatKhau.TabIndex = 5;
            // 
            // btnĐangKy
            // 
            this.btnĐangKy.Location = new System.Drawing.Point(236, 324);
            this.btnĐangKy.Name = "btnĐangKy";
            this.btnĐangKy.Size = new System.Drawing.Size(133, 41);
            this.btnĐangKy.TabIndex = 6;
            this.btnĐangKy.Text = "Đăng Ký";
            this.btnĐangKy.Click += new System.EventHandler(this.btnĐangKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(562, 324);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(140, 41);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            // 
            // grpCtrlDangKy
            // 
            this.grpCtrlDangKy.Controls.Add(this.labelControl1);
            this.grpCtrlDangKy.Controls.Add(this.btnĐangKy);
            this.grpCtrlDangKy.Controls.Add(this.btnThoat);
            this.grpCtrlDangKy.Controls.Add(this.txtEditDangNhap);
            this.grpCtrlDangKy.Controls.Add(this.labelControl2);
            this.grpCtrlDangKy.Controls.Add(this.txtEditNhapLaiMatKhau);
            this.grpCtrlDangKy.Controls.Add(this.txtEditNhapMatKhau);
            this.grpCtrlDangKy.Controls.Add(this.labelControl3);
            this.grpCtrlDangKy.Location = new System.Drawing.Point(90, 53);
            this.grpCtrlDangKy.Name = "grpCtrlDangKy";
            this.grpCtrlDangKy.Size = new System.Drawing.Size(786, 408);
            this.grpCtrlDangKy.TabIndex = 8;
            this.grpCtrlDangKy.Text = "ĐĂNG KÝ";
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 593);
            this.Controls.Add(this.grpCtrlDangKy);
            this.Name = "frmDangKy";
            this.Text = "ĐĂNG KÝ";
            ((System.ComponentModel.ISupportInitialize)(this.txtEditDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditNhapMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditNhapLaiMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCtrlDangKy)).EndInit();
            this.grpCtrlDangKy.ResumeLayout(false);
            this.grpCtrlDangKy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtEditDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtEditNhapMatKhau;
        private DevExpress.XtraEditors.TextEdit txtEditNhapLaiMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnĐangKy;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.GroupControl grpCtrlDangKy;
    }
}