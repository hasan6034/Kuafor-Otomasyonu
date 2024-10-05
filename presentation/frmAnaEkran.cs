using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using DxDialog = DevExpress.Utils.CommonDialogs.Internal;

namespace Kuafor_Otomasyonu
{
    public partial class frmAnaEkran : DevExpress.XtraEditors.XtraForm
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {
            tileControl_Menu.ShowGroupText = true;
        }

        private void frmAnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tileItem_OturumuKapat_ItemClick(object sender, TileItemEventArgs e)
        {
            if (GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Soru, "Oturumu Kapatmak İstediğinize Emin Misiniz ?", "Oturum Kapat") == DxDialog.DialogResult.OK)
            {
                Settings.Default.KullaniciAdi = "";
                Settings.Default.Sifre = "";
                Settings.Default.Save();
                Application.Exit();
            }
        }

        private void tileItem_KullaniciIslemleri_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmKullaniciIslemleri kullaniciIslemleri = new FrmKullaniciIslemleri();
            kullaniciIslemleri.Show();
        }

        private void tileItem_RolTanimlama_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmRolYetki rolYetki = new FrmRolYetki();
            rolYetki.Show();
        }
    }
}