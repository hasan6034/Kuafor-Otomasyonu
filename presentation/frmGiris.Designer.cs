namespace Kuafor_Otomasyonu
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEdit_KullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Sifre = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton_GirisYap = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit_BeniHatirla = new DevExpress.XtraEditors.CheckEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.simpleButton_vazgec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_KullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Sifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_BeniHatirla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre :";
            // 
            // textEdit_KullaniciAdi
            // 
            this.textEdit_KullaniciAdi.EnterMoveNextControl = true;
            this.textEdit_KullaniciAdi.Location = new System.Drawing.Point(179, 33);
            this.textEdit_KullaniciAdi.Name = "textEdit_KullaniciAdi";
            this.textEdit_KullaniciAdi.Properties.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("textEdit_KullaniciAdi.Properties.ContextImageOptions.SvgImage")));
            this.textEdit_KullaniciAdi.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.textEdit_KullaniciAdi.Size = new System.Drawing.Size(271, 30);
            this.textEdit_KullaniciAdi.TabIndex = 0;
            // 
            // textEdit_Sifre
            // 
            this.textEdit_Sifre.EnterMoveNextControl = true;
            this.textEdit_Sifre.Location = new System.Drawing.Point(179, 66);
            this.textEdit_Sifre.Name = "textEdit_Sifre";
            this.textEdit_Sifre.Properties.ContextImageOptions.ImageUri.Uri = "business%20objects/bo_user";
            this.textEdit_Sifre.Properties.ContextImageOptions.SvgImageSize = new System.Drawing.Size(18, 18);
            this.textEdit_Sifre.Properties.UseSystemPasswordChar = true;
            this.textEdit_Sifre.Size = new System.Drawing.Size(271, 30);
            this.textEdit_Sifre.TabIndex = 1;
            // 
            // simpleButton_GirisYap
            // 
            this.simpleButton_GirisYap.Location = new System.Drawing.Point(327, 160);
            this.simpleButton_GirisYap.Name = "simpleButton_GirisYap";
            this.simpleButton_GirisYap.Size = new System.Drawing.Size(124, 32);
            this.simpleButton_GirisYap.TabIndex = 3;
            this.simpleButton_GirisYap.Text = "Giriş Yap";
            this.simpleButton_GirisYap.Click += new System.EventHandler(this.SimpleButton_GirisYap_Click);
            // 
            // checkEdit_BeniHatirla
            // 
            this.checkEdit_BeniHatirla.EnterMoveNextControl = true;
            this.checkEdit_BeniHatirla.Location = new System.Drawing.Point(180, 102);
            this.checkEdit_BeniHatirla.Name = "checkEdit_BeniHatirla";
            this.checkEdit_BeniHatirla.Properties.Caption = "Beni Hatırla";
            this.checkEdit_BeniHatirla.Size = new System.Drawing.Size(271, 22);
            this.checkEdit_BeniHatirla.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 19);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(89, 77);
            this.pictureEdit1.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(107, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(259, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Hoşgeldiniz ! Lütfen kullanıcın adınızı ve şifrenizi giriniz.";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(-8, 130);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(491, 24);
            this.separatorControl1.TabIndex = 9;
            // 
            // simpleButton_vazgec
            // 
            this.simpleButton_vazgec.Location = new System.Drawing.Point(202, 160);
            this.simpleButton_vazgec.Name = "simpleButton_vazgec";
            this.simpleButton_vazgec.Size = new System.Drawing.Size(119, 32);
            this.simpleButton_vazgec.TabIndex = 4;
            this.simpleButton_vazgec.Text = "Vazgeç";
            this.simpleButton_vazgec.Click += new System.EventHandler(this.SimpleButton_vazgec_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 204);
            this.Controls.Add(this.simpleButton_vazgec);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.checkEdit_BeniHatirla);
            this.Controls.Add(this.simpleButton_GirisYap);
            this.Controls.Add(this.textEdit_Sifre);
            this.Controls.Add(this.textEdit_KullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kulanıcı Girişi";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGiris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_KullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Sifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit_BeniHatirla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEdit_KullaniciAdi;
        private DevExpress.XtraEditors.TextEdit textEdit_Sifre;
        private DevExpress.XtraEditors.SimpleButton simpleButton_GirisYap;
        private DevExpress.XtraEditors.CheckEdit checkEdit_BeniHatirla;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_vazgec;
    }
}