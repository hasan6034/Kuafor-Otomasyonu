using Core.DTOs;
using Core.IServices;
using DevExpress.XtraEditors;
using Repository.Repositories;
using Service.Services;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using DxDialog = DevExpress.Utils.CommonDialogs.Internal;

namespace Kuafor_Otomasyonu
{
    public partial class FrmGiris : XtraForm
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        #region ..: Declare :..

        private readonly IGenelService _genelService = new GenelService(
                    new GenelRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

        private readonly IKullaniciService _kullaniciService = new KullaniciService(
                    new KullaniciRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

        #endregion

        #region ..: Form Event :..

        private void FrmGiris_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Soru, "Çıkmak İstediğinize Emin Misiniz ?", "Çıkış") == DxDialog.DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region ..: Simple Button Event :..

        private void SimpleButton_GirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                string kullaniciAdi = textEdit_KullaniciAdi.Text;
                string sifre = textEdit_Sifre.Text;
                KullanicilarDTO kullanici = _kullaniciService.KullaniciGiris(kullaniciAdi, sifre.ToString());
                StaticClass.KulID = kullanici.KulID;
                StaticClass.RoleID = kullanici.RolID;
                StaticClass.AdSoyad = kullanici.AdSoyad;
                if (checkEdit_BeniHatirla.Checked)
                {
                    Settings.Default.KullaniciAdi = kullaniciAdi;
                    Settings.Default.Sifre = sifre;
                    Settings.Default.Save();
                }
                else
                {
                    Settings.Default.KullaniciAdi = "";
                    Settings.Default.Sifre = "";
                    Settings.Default.Save();
                }
                StaticClass.KulAdi = kullaniciAdi;
                StaticClass.Yetkiler = _kullaniciService.RolYetkileriGetir(StaticClass.RoleID);
                frmAnaEkran anaEkran = new frmAnaEkran();
                anaEkran.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Hata");
            }
            catch (Exception ex)
            {
                try
                {
                    SonucDTO sonuc = _genelService.HataKaydet(ex.HResult, ex.Message, "simpleButton_GirisYap_Click", StaticClass.KulID);
                    var errorID = sonuc.Sonuc;
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, string.Format("Beklenmedik Bir Hata Oluştu. [HataID:{0}]", errorID), "Hata");
                }
                catch (Exception)
                {
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Hata");
                }

            }
            finally
            {
                textEdit_KullaniciAdi.Focus();
            }
        }

        private void SimpleButton_vazgec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

    }
}