using Core.DTOs;
using Core.Enums;
using Core.IServices;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Repository.Repositories;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace Kuafor_Otomasyonu
{
    public partial class FrmRolYetki : XtraForm
    {
        public FrmRolYetki()
        {
            InitializeComponent();
        }

        #region ..: Declare :..

        private readonly IKullaniciService _kullaniciService = new KullaniciService(
           new KullaniciRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

        private readonly IGenelService _genelService = new GenelService(
           new GenelRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

        #endregion

        #region ..: Form Event :..

        private void FrmRolYetki_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = this.Text + " - " + StaticClass.KulAdi;

                IEnumerable<RollerDTO> rolListesi = _kullaniciService.RolGetir(-1);
                gridControl_RolListesi.DataSource = rolListesi;
                repositoryItemCheckEdit1 = new RepositoryItemCheckEdit
                {
                    ValueChecked = 1,
                    ValueUnchecked = 0
                };
                gridControl_RolYetki.RepositoryItems.Add(repositoryItemCheckEdit1);
                gridView_RolYetki.Columns["Okuma"].ColumnEdit = repositoryItemCheckEdit1;
                gridView_RolYetki.Columns["Yazma"].ColumnEdit = repositoryItemCheckEdit1;
                gridView_RolYetki.Columns["Duzenleme"].ColumnEdit = repositoryItemCheckEdit1;
                gridView_RolYetki.Columns["Silme"].ColumnEdit = repositoryItemCheckEdit1;
                tileView_RolListesi.FocusedRowHandle = 0;
                tileView_RolListesi.SelectRow(0);
            }
            catch (SqlException ex)
            {
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Rol/Yetki");
            }
            catch (Exception ex)
            {
                try
                {
                    SonucDTO sonuc = _genelService.HataKaydet(ex.HResult, ex.Message, "frmRolYetki_Load", StaticClass.KulID);
                    var errorID = sonuc.Sonuc;
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, string.Format("Beklenmedik Bir Hata Oluştu. [HataID:{0}]", errorID), "Hata");
                }
                catch (Exception)
                {
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Rol/Yetki");
                }
            }


        }

        #endregion

        #region ..: Simple Button Event :..

        private void SimpleButton_RolKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int rolID = Convert.ToInt32(tileView_RolListesi.GetFocusedRowCellValue("RolID"));

                if (rolID == -1)
                {
                    if (StaticClass.Yetkiler.FirstOrDefault(x => x.SayfaID == (int)Sayfalar.Kullanici_Rol_Tanimlari).Yazma != 1)
                    {
                        GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Rol Ekleme Yetkiniz Bulunamadı.", "Yetkisiz erişim");
                        return;
                    }
                }
                else
                {
                    if (StaticClass.Yetkiler.FirstOrDefault(x => x.SayfaID == (int)Sayfalar.Kullanici_Rol_Tanimlari).Duzenleme != 1)
                    {
                        GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Rol Düzenleme Yetkiniz Bulunamadı.", "Yetkisiz erişim");
                        return;
                    }
                }

                string rolAdi = textEdit_RolAdi.Text;
                if (rolAdi == "")
                {
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Rol Adı Boş Geçilemez.", "Rol/Yetki");
                }
                if (!(gridControl_RolYetki.DataSource is List<RolYetkileriDTO> rolYetkileriDTOs))
                {
                    return;
                }
                string gidenVeri = "";
                foreach (var item in rolYetkileriDTOs)
                {
                    gidenVeri += item.ToString();
                }

                var sonuc = _kullaniciService.RolYetkiSAVE(rolID, rolAdi, gidenVeri, (int)Sayfalar.Kullanici_Rol_Tanimlari, StaticClass.KulID);
                gridControl_RolYetki.DataSource = null;
                gridControl_RolListesi.DataSource = _kullaniciService.RolGetir(-1);
                int rowHandle = tileView_RolListesi.LocateByValue("RolID", sonuc.Sonuc);
                tileView_RolListesi.FocusedRowHandle = rowHandle;
                tileView_RolListesi.SelectRow(rowHandle);
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Bilgi, textEdit_RolAdi.Text + " Rolü Başarıyla Kaydedildi.", "Rol Kaydedildi");
            }
            catch (SqlException ex)
            {
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Rol/Yetki");
            }
            catch (Exception ex)
            {
                try
                {
                    SonucDTO sonuc = _genelService.HataKaydet(ex.HResult, ex.Message, "simpleButton_RolKaydet_Click", StaticClass.KulID);
                    var errorID = sonuc.Sonuc;
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, string.Format("Beklenmedik Bir Hata Oluştu. [HataID:{0}]", errorID), "Hata");
                }
                catch (Exception)
                {
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Hata");
                }
            }
        }

        private void SimpleButton_RolSil_Click(object sender, EventArgs e)
        {
            try
            {
                int rolID = Convert.ToInt32(tileView_RolListesi.GetFocusedRowCellValue("RolID"));
                if (rolID == -1)
                {
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Silmek İstediğiniz Rolü Seçin.", "Rol Seç");
                    return;
                }
                if (StaticClass.Yetkiler.FirstOrDefault(x => x.SayfaID == (int)Sayfalar.Kullanici_Rol_Tanimlari).Silme != 1)
                {
                    GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Rol Silme Yetkiniz Bulunamadı.", "Yetkisiz Erişim");
                    return;
                }
                _kullaniciService.RolDELETE(rolID, (int)Sayfalar.Kullanici_Rol_Tanimlari, StaticClass.KulID);
                gridControl_RolListesi.DataSource = _kullaniciService.RolGetir(-1);
                int rowHandle = tileView_RolListesi.LocateByValue("RolID", -1);
                tileView_RolListesi.FocusedRowHandle = rowHandle;
                tileView_RolListesi.SelectRow(rowHandle);
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, textEdit_RolAdi.Text + " Rolü Başarıyla Silindi.", "Rol Silindi");

            }
            catch (SqlException ex)
            {
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Hata");
            }
            catch (Exception ex)
            {
                try
                {
                    SonucDTO sonuc = _genelService.HataKaydet(ex.HResult, ex.Message, "simpleButton_RolSil_Click", StaticClass.KulID);
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
        private void tileView_RolListesi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (tileView_RolListesi.RowCount == 0)
                {
                    return;
                }
                int rolID = Convert.ToInt32(tileView_RolListesi.GetFocusedRowCellValue("RolID"));

                if (rolID <= 0)
                {
                    textEdit_RolAdi.Text = "";
                }
                else
                {
                    textEdit_RolAdi.Text = tileView_RolListesi.GetFocusedRowCellValue("RolAdi").ToString();
                }
                IEnumerable<RolYetkileriDTO> rolYetkisi = _kullaniciService.RolYetkileriGetir(rolID);
                gridControl_RolYetki.DataSource = rolYetkisi;
                gridView_RolYetki.ExpandAllGroups();
            }
            catch (SqlException ex)
            {
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Hata, ex.Message, "Hata");
            }
            catch (Exception ex)
            {
                try
                {
                    SonucDTO sonuc = _genelService.HataKaydet(ex.HResult, ex.Message, "tileView_RolListesi_FocusedRowChanged", StaticClass.KulID);
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
    }
}