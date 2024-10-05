using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using DevExpress.XtraGrid.Views.Base;
using Core.IServices;
using Service.Services;
using Repository.Repositories;
using Kuafor_Otomasyonu;
using Core.DTOs;
using Core.Enums;

namespace Kuafor_Otomasyonu
{
    public partial class FrmKullaniciIslemleri : XtraForm
    {
        public FrmKullaniciIslemleri()
        {
            InitializeComponent();
        }

        #region ..: Declare :..

        private readonly IKullaniciService _KullaniciService = new KullaniciService(
            new KullaniciRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

        private readonly IGenelService _genelService = new GenelService(
                   new GenelRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

        #endregion

        #region ..: Form Event :..

        private void FrmKullaniciIslemleri_Load(object sender, EventArgs e)
        {
            try
            {
				this.Text = this.Text + " - " + StaticClass.KulAdi;

				var kullaniciListesi = _KullaniciService.KullaniciGetir(-1);
                gridControl_KullaniciListesi.DataSource = kullaniciListesi;
                IEnumerable<RollerDTO> rolListesi = _KullaniciService.RolGetir(-1);
                lookUpEdit_Rol.Properties.DataSource = rolListesi.Where(x => x.RolID != -1);
                lookUpEdit_Rol.Properties.DisplayMember = "RolAdi";
                lookUpEdit_Rol.Properties.ValueMember = "RolID";
                lookUpEdit_Rol.Properties.NullText = "Rol seçiniz";
                Dictionary<int, string> colorEnums = Enum.GetValues(typeof(Durumlar))
                    .Cast<Durumlar>().ToDictionary(x => (int)x, x => x.ToString());

                lookUpEdit_Durum.Properties.DataSource = colorEnums;
                lookUpEdit_Durum.Properties.ValueMember = "Key";
                lookUpEdit_Durum.Properties.DisplayMember = "Value";
                tileView_KullaniciListesi.FocusedRowHandle = 0;
                tileView_KullaniciListesi.SelectRow(0);
            }
            catch (SqlException ex)
            {
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Hata");
            }
            catch (Exception ex)
            {
                try
                {
                    SonucDTO sonuc = _genelService.HataKaydet(ex.HResult, ex.Message, "frmKullaniciIslemleri_Load", StaticClass.KulID);
                    var errorID = sonuc.Sonuc;
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, string.Format("Beklenmedik Bir Hata Oluştu. [HataID:{0}]", errorID), "Hata");
                }
                catch (Exception)
                {
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Hata");
                }
            }
        }

        #endregion

        #region ..: Simple Button Event :..

        private void SimpleButton_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int kulID = Convert.ToInt32(tileView_KullaniciListesi.GetFocusedRowCellValue(tileViewColumn_KulID));
                if (kulID == -1)
                {
                    if (StaticClass.Yetkiler.FirstOrDefault(x => x.SayfaID == (int)Sayfalar.Kullanici_Islemleri).Yazma != 1)
                    {
                        GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Kullanıcı Ekleme Yetkiniz Bulunamadı.", "Yetkisiz Erişim");
                        return;
                    }
                }
                else
                {
                    if (StaticClass.Yetkiler.FirstOrDefault(x => x.SayfaID == (int)Sayfalar.Kullanici_Islemleri).Duzenleme != 1)
                    {
                        GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Kullanıcı Düzenleme Yetkiniz Bulunamadı.", "Yetkisiz Erişim");
                        return;
                    }

                }
                string adi = textEdit_Adi.Text;
                string soyadi = textEdit_Soyadi.Text;
                if (lookUpEdit_Rol.EditValue.ToString() == "" || lookUpEdit_Durum.EditValue.ToString() == "")
                {
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Rol ve/veya Durum Boş Geçilemez", "Kullanıcı Kaydedilemedi.");
                    return;
                }
                int rolID = Convert.ToInt32(lookUpEdit_Rol.EditValue);
                int durumID = Convert.ToInt32(lookUpEdit_Durum.EditValue);
                string kulAdi = textEdit_KullaniciAdi.Text;
                string kulSifre = textEdit_Sifre.Text;

                if (adi == "" || soyadi == "" || rolID == -1 || durumID == -1 || kulAdi == "" || kulSifre == "")
                {
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Lütfen Tüm Alanları Doldurun.", "Kullanıcı Kaydedilemedi.");
                    return;
                }
                KullanicilarDTO dto = new KullanicilarDTO
                {
                    Adi = adi,
                    Soyadi = soyadi,
                    RolID = rolID,
                    DurumID = durumID,
                    KulAdi = kulAdi,
                    KulSifre = kulSifre,
                    KulID = kulID
                };
                var sonuc = _KullaniciService.KullaniciSAVE(dto, (int)Sayfalar.Kullanici_Islemleri, StaticClass.KulID);
                gridControl_KullaniciListesi.DataSource = _KullaniciService.KullaniciGetir(-1);
                int rowHandle = tileView_KullaniciListesi.LocateByValue("KulID", sonuc.Sonuc);
                tileView_KullaniciListesi.FocusedRowHandle = rowHandle;
                tileView_KullaniciListesi.SelectRow(rowHandle);
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Bilgi, "Kullanıcı Bilgileri Başarıyla Kaydedildi.", "Kullanıcı Kaydetme");
            }
            catch (SqlException ex)
            {
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Hata");
            }
            catch (Exception ex)
            {
                try
                {
                    SonucDTO sonuc = _genelService.HataKaydet(ex.HResult, ex.Message, "simpleButton_Kaydet_Click", StaticClass.KulID);
                    var errorID = sonuc.Sonuc;
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, string.Format("Beklenmedik Bir Hata Oluştu. [HataID:{0}]", errorID), "Hata");
                }
                catch (Exception)
                {
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Hata");
                }
            }

        }

        private void SimpleButton_KulSil_Click(object sender, EventArgs e)
        {
            try
            {

                int kulID = Convert.ToInt32(tileView_KullaniciListesi.GetFocusedRowCellValue(tileViewColumn_KulID));
                if (kulID == -1)
                {
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Silmek İstediğiniz Kullanıcıyı Seçin.", "Kullanıcı Seçin");
                    return;
                }
                if (StaticClass.Yetkiler.FirstOrDefault(x => x.SayfaID == (int)Sayfalar.Kullanici_Islemleri).Silme != 1)
                {
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Kullanıcı Silme Yetkiniz Bulunamadı.", "Yetkisiz Erişim");
                    return;
                }
                _KullaniciService.KullaniciDELETE(kulID, (int)Sayfalar.Kullanici_Islemleri, StaticClass.KulID);
                gridControl_KullaniciListesi.DataSource = _KullaniciService.KullaniciGetir(-1);
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Kullanıcı Başarıyla Silindi", "Kullanıcı Silme");
            }
            catch (SqlException ex)
            {
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Hata");
            }
            catch (Exception ex)
            {
                try
                {
                    SonucDTO sonuc = _genelService.HataKaydet(ex.HResult, ex.Message, "frmKullaniciIslemleri_Load", StaticClass.KulID);
                    var errorID = sonuc.Sonuc;
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, string.Format("Beklenmedik Bir Hata Oluştu. [HataID:{0}]", errorID), "Hata");
                }
                catch (Exception)
                {
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Hata");
                }
            }
        }

        #endregion

        #region ..: Other Events :..

        private void TileView_KullaniciListesi_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridControl_KullaniciListesi.DataSource == null)
                {
                    return;
                }
                Temizle();
                if (Convert.ToInt32(tileView_KullaniciListesi.GetFocusedRowCellValue(tileViewColumn_KulID)) != -1 && e.FocusedRowHandle >= 0)
                {
                    textEdit_Adi.Text = tileView_KullaniciListesi.GetFocusedRowCellValue(tileViewColumn_Adi).ToString();
                    textEdit_Soyadi.Text = tileView_KullaniciListesi.GetFocusedRowCellValue(tileViewColumn_Soyadi).ToString();
                    lookUpEdit_Rol.EditValue = tileView_KullaniciListesi.GetFocusedRowCellValue(tileViewColumn_RolID).ToString();
                    lookUpEdit_Durum.EditValue = tileView_KullaniciListesi.GetFocusedRowCellValue(tileViewColumn_DurumID).ToString();
                    textEdit_KullaniciAdi.Text = tileView_KullaniciListesi.GetFocusedRowCellValue(tileViewColumn_KulAdi).ToString();
                    textEdit_Sifre.Text = tileView_KullaniciListesi.GetFocusedRowCellValue(tileViewColumn_KulSifre).ToString();
                }
            }
            catch (Exception ex)
            {
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Hata");
            }
        }

        #endregion

        #region ..: Methods :..

        private void Temizle()
        {
            textEdit_Adi.Text = "";
            textEdit_Soyadi.Text = "";
            lookUpEdit_Rol.EditValue = "";
            lookUpEdit_Durum.EditValue = "";
            textEdit_KullaniciAdi.Text = "";
            textEdit_Sifre.Text = "";
        }

        #endregion

    }
}