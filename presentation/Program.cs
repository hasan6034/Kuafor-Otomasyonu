using Core.DTOs;
using Core.IServices;
using Repository.Repositories;
using Service.Services;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kuafor_Otomasyonu
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IKullaniciService _kullaniciService = new KullaniciService(
                    new KullaniciRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

            IGenelService _genelService = new GenelService(
            new GenelRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

            if (Settings.Default.KullaniciAdi != "" && Settings.Default.Sifre != "")
            {
                try
                {
                    KullanicilarDTO kullanici = _kullaniciService.KullaniciGiris(Settings.Default.KullaniciAdi, Settings.Default.Sifre);
                    StaticClass.KulID = kullanici.KulID;
                    StaticClass.RoleID = kullanici.RolID;
                    StaticClass.AdSoyad = kullanici.AdSoyad;
                    StaticClass.KulAdi = Settings.Default.KullaniciAdi;
                    StaticClass.Yetkiler = _kullaniciService.RolYetkileriGetir(StaticClass.RoleID);
                    Application.Run(new frmAnaEkran());
                }
                catch (SqlException ex)
                {
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Hata");
                    Application.Run(new FrmGiris());
                }
                catch (Exception ex)
                {
                    try
                    {
                        SonucDTO sonuc = _genelService.HataKaydet(ex.HResult, ex.Message, "Main", StaticClass.KulID);
                        var errorID = sonuc.Sonuc;
                        GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, string.Format("Beklenmedik Bir Hata Oluştu. [HataID:{0}]", errorID), "Hata");
                    }
                    catch (Exception)
                    {
                        GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Hata");
                    }
                    finally
                    {
                        Application.Run(new FrmGiris());
                    }
                }
            }
            else
            {
                Application.Run(new FrmGiris());
            }
        }
    }
}
