namespace Kuafor_Otomasyonu
{
    partial class frmAnaEkran
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl_Menu = new DevExpress.XtraEditors.TileControl();
            this.tileGroup_Kullanici = new DevExpress.XtraEditors.TileGroup();
            this.tileItem_KullaniciIslemleri = new DevExpress.XtraEditors.TileItem();
            this.tileItem_RolTanimlama = new DevExpress.XtraEditors.TileItem();
            this.tileGroup_IsletmeAyarlari = new DevExpress.XtraEditors.TileGroup();
            this.tileItem_Subeler = new DevExpress.XtraEditors.TileItem();
            this.tileItem_Hizmetler = new DevExpress.XtraEditors.TileItem();
            this.tileGroup_Musteri = new DevExpress.XtraEditors.TileGroup();
            this.tileItem_MusteriIslemleri = new DevExpress.XtraEditors.TileItem();
            this.tileItem_Randevu = new DevExpress.XtraEditors.TileItem();
            this.tileGroup_Raporlar = new DevExpress.XtraEditors.TileGroup();
            this.tileItem_MusteriRaporu = new DevExpress.XtraEditors.TileItem();
            this.tileItem_PersonelBazliRapor = new DevExpress.XtraEditors.TileItem();
            this.tileItem_SubeBazliRapor = new DevExpress.XtraEditors.TileItem();
            this.tileGroup_Oturum = new DevExpress.XtraEditors.TileGroup();
            this.tileItem_OturumuKapat = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tileControl_Menu
            // 
            this.tileControl_Menu.AllowDrag = false;
            this.tileControl_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl_Menu.Groups.Add(this.tileGroup_Kullanici);
            this.tileControl_Menu.Groups.Add(this.tileGroup_IsletmeAyarlari);
            this.tileControl_Menu.Groups.Add(this.tileGroup_Musteri);
            this.tileControl_Menu.Groups.Add(this.tileGroup_Raporlar);
            this.tileControl_Menu.Groups.Add(this.tileGroup_Oturum);
            this.tileControl_Menu.Location = new System.Drawing.Point(0, 0);
            this.tileControl_Menu.MaxId = 10;
            this.tileControl_Menu.Name = "tileControl_Menu";
            this.tileControl_Menu.Size = new System.Drawing.Size(1202, 432);
            this.tileControl_Menu.TabIndex = 0;
            this.tileControl_Menu.Tag = "";
            // 
            // tileGroup_Kullanici
            // 
            this.tileGroup_Kullanici.Items.Add(this.tileItem_KullaniciIslemleri);
            this.tileGroup_Kullanici.Items.Add(this.tileItem_RolTanimlama);
            this.tileGroup_Kullanici.Name = "tileGroup_Kullanici";
            this.tileGroup_Kullanici.Text = "Kullanıcı";
            // 
            // tileItem_KullaniciIslemleri
            // 
            this.tileItem_KullaniciIslemleri.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tileItem_KullaniciIslemleri.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement1.Text = "Kullanıcı İşlemleri";
            this.tileItem_KullaniciIslemleri.Elements.Add(tileItemElement1);
            this.tileItem_KullaniciIslemleri.Id = 0;
            this.tileItem_KullaniciIslemleri.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem_KullaniciIslemleri.Name = "tileItem_KullaniciIslemleri";
            this.tileItem_KullaniciIslemleri.Visible = false;
            this.tileItem_KullaniciIslemleri.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem_KullaniciIslemleri_ItemClick);
            // 
            // tileItem_RolTanimlama
            // 
            this.tileItem_RolTanimlama.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tileItem_RolTanimlama.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement2.Text = "Kullanıcı Rol Tanımları";
            this.tileItem_RolTanimlama.Elements.Add(tileItemElement2);
            this.tileItem_RolTanimlama.Id = 1;
            this.tileItem_RolTanimlama.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem_RolTanimlama.Name = "tileItem_RolTanimlama";
            this.tileItem_RolTanimlama.Visible = false;
            this.tileItem_RolTanimlama.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem_RolTanimlama_ItemClick);
            // 
            // tileGroup_IsletmeAyarlari
            // 
            this.tileGroup_IsletmeAyarlari.Items.Add(this.tileItem_Subeler);
            this.tileGroup_IsletmeAyarlari.Items.Add(this.tileItem_Hizmetler);
            this.tileGroup_IsletmeAyarlari.Name = "tileGroup_IsletmeAyarlari";
            this.tileGroup_IsletmeAyarlari.Text = "İşletme Ayaraları";
            // 
            // tileItem_Subeler
            // 
            this.tileItem_Subeler.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tileItem_Subeler.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement3.Text = "Şube İşlemleri";
            this.tileItem_Subeler.Elements.Add(tileItemElement3);
            this.tileItem_Subeler.Id = 2;
            this.tileItem_Subeler.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem_Subeler.Name = "tileItem_Subeler";
            this.tileItem_Subeler.Visible = false;
            // 
            // tileItem_Hizmetler
            // 
            this.tileItem_Hizmetler.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tileItem_Hizmetler.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement4.Text = "Hizmet İşlemleri";
            this.tileItem_Hizmetler.Elements.Add(tileItemElement4);
            this.tileItem_Hizmetler.Id = 3;
            this.tileItem_Hizmetler.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem_Hizmetler.Name = "tileItem_Hizmetler";
            this.tileItem_Hizmetler.Visible = false;
            // 
            // tileGroup_Musteri
            // 
            this.tileGroup_Musteri.Items.Add(this.tileItem_MusteriIslemleri);
            this.tileGroup_Musteri.Items.Add(this.tileItem_Randevu);
            this.tileGroup_Musteri.Name = "tileGroup_Musteri";
            this.tileGroup_Musteri.Text = "Müşteri";
            // 
            // tileItem_MusteriIslemleri
            // 
            this.tileItem_MusteriIslemleri.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tileItem_MusteriIslemleri.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement5.Text = "Müşteri İşlemleri";
            this.tileItem_MusteriIslemleri.Elements.Add(tileItemElement5);
            this.tileItem_MusteriIslemleri.Id = 4;
            this.tileItem_MusteriIslemleri.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem_MusteriIslemleri.Name = "tileItem_MusteriIslemleri";
            this.tileItem_MusteriIslemleri.Visible = false;
            // 
            // tileItem_Randevu
            // 
            this.tileItem_Randevu.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tileItem_Randevu.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement6.Text = "Randevu İşlemleri";
            this.tileItem_Randevu.Elements.Add(tileItemElement6);
            this.tileItem_Randevu.Id = 5;
            this.tileItem_Randevu.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem_Randevu.Name = "tileItem_Randevu";
            this.tileItem_Randevu.Visible = false;
            // 
            // tileGroup_Raporlar
            // 
            this.tileGroup_Raporlar.Items.Add(this.tileItem_MusteriRaporu);
            this.tileGroup_Raporlar.Items.Add(this.tileItem_PersonelBazliRapor);
            this.tileGroup_Raporlar.Items.Add(this.tileItem_SubeBazliRapor);
            this.tileGroup_Raporlar.Name = "tileGroup_Raporlar";
            this.tileGroup_Raporlar.Text = "Raporlar";
            // 
            // tileItem_MusteriRaporu
            // 
            this.tileItem_MusteriRaporu.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tileItem_MusteriRaporu.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement7.Text = "Müşteri Bazlı Rapor";
            this.tileItem_MusteriRaporu.Elements.Add(tileItemElement7);
            this.tileItem_MusteriRaporu.Id = 7;
            this.tileItem_MusteriRaporu.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem_MusteriRaporu.Name = "tileItem_MusteriRaporu";
            this.tileItem_MusteriRaporu.Visible = false;
            // 
            // tileItem_PersonelBazliRapor
            // 
            this.tileItem_PersonelBazliRapor.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tileItem_PersonelBazliRapor.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement8.Text = "Personel Bazlı Rapor";
            this.tileItem_PersonelBazliRapor.Elements.Add(tileItemElement8);
            this.tileItem_PersonelBazliRapor.Id = 8;
            this.tileItem_PersonelBazliRapor.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem_PersonelBazliRapor.Name = "tileItem_PersonelBazliRapor";
            this.tileItem_PersonelBazliRapor.Visible = false;
            // 
            // tileItem_SubeBazliRapor
            // 
            this.tileItem_SubeBazliRapor.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tileItem_SubeBazliRapor.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement9.Text = "Şube Bazlı Rapor";
            this.tileItem_SubeBazliRapor.Elements.Add(tileItemElement9);
            this.tileItem_SubeBazliRapor.Id = 9;
            this.tileItem_SubeBazliRapor.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem_SubeBazliRapor.Name = "tileItem_SubeBazliRapor";
            this.tileItem_SubeBazliRapor.Visible = false;
            // 
            // tileGroup_Oturum
            // 
            this.tileGroup_Oturum.Items.Add(this.tileItem_OturumuKapat);
            this.tileGroup_Oturum.Name = "tileGroup_Oturum";
            this.tileGroup_Oturum.Text = "Oturum";
            // 
            // tileItem_OturumuKapat
            // 
            this.tileItem_OturumuKapat.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            this.tileItem_OturumuKapat.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement10.Text = "Oturumu Kapat";
            this.tileItem_OturumuKapat.Elements.Add(tileItemElement10);
            this.tileItem_OturumuKapat.Id = 6;
            this.tileItem_OturumuKapat.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem_OturumuKapat.Name = "tileItem_OturumuKapat";
            this.tileItem_OturumuKapat.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem_OturumuKapat_ItemClick);
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 432);
            this.Controls.Add(this.tileControl_Menu);
            this.Name = "frmAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kmu Berber Otomasyonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAnaEkran_FormClosed);
            this.Load += new System.EventHandler(this.frmAnaEkran_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl_Menu;
        private DevExpress.XtraEditors.TileGroup tileGroup_Kullanici;
        private DevExpress.XtraEditors.TileItem tileItem_KullaniciIslemleri;
        private DevExpress.XtraEditors.TileItem tileItem_RolTanimlama;
        private DevExpress.XtraEditors.TileGroup tileGroup_IsletmeAyarlari;
        private DevExpress.XtraEditors.TileItem tileItem_Subeler;
        private DevExpress.XtraEditors.TileGroup tileGroup_Musteri;
        private DevExpress.XtraEditors.TileItem tileItem_Hizmetler;
        private DevExpress.XtraEditors.TileItem tileItem_MusteriIslemleri;
        private DevExpress.XtraEditors.TileItem tileItem_Randevu;
        private DevExpress.XtraEditors.TileGroup tileGroup_Oturum;
        private DevExpress.XtraEditors.TileItem tileItem_OturumuKapat;
        private DevExpress.XtraEditors.TileGroup tileGroup_Raporlar;
        private DevExpress.XtraEditors.TileItem tileItem_MusteriRaporu;
        private DevExpress.XtraEditors.TileItem tileItem_PersonelBazliRapor;
        private DevExpress.XtraEditors.TileItem tileItem_SubeBazliRapor;
    }
}