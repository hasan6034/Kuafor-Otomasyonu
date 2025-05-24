using Core.DTOs;
using Core.Enums;
using Core.IServices;
using DevExpress.XtraEditors;
using Repository.Repositories;
using Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuafor_Otomasyonu
{
    public partial class frmSubeler : DevExpress.XtraEditors.XtraForm
    {
        public frmSubeler()
        {
            InitializeComponent();
        }

        #region ..: Declare :..

        private readonly ISubeService _subeService = new SubeService(
           new SubeRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

        private readonly IGenelService _genelService = new GenelService(
           new GenelRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

        #endregion

        private void frmSubeler_Load(object sender, EventArgs e)
        {
            SubeListesi();
        }

        private void SubeListesi()
        {
            gridControl_SubeListesi.DataSource = _subeService.SubeList(-1);
            tileView_SubeListesi.FocusedRowHandle = 0;
            tileView_SubeListesi.SelectRow(0);
        }

        private void simpleButton_Kaydet_Click(object sender, EventArgs e)
        {
            if (tileView_SubeListesi.FocusedRowHandle < 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(textEdit_SubeAdi.Text))
            {
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Şube Adı boş bırakılamaz.", "Uyarı");
                return;
            }
            if (string.IsNullOrEmpty(textEdit_TelefonNo.Text))
            {
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Telefon boş bırakılamaz.", "Uyarı");
                return;
            }
            if (string.IsNullOrEmpty(memoEdit_Adres.Text))
            {
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Adres boş bırakılamaz.", "Uyarı");
                return;
            }

            _subeService.SubeEkle(Convert.ToInt32(tileView_SubeListesi.GetFocusedRowCellValue(tileViewColumn_SubeID).ToString()), textEdit_SubeAdi.Text, textEdit_TelefonNo.Text, memoEdit_Adres.Text, (int)Sayfalar.Sube_Islemleri, StaticClass.KulID);
            GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Bilgi, "Şube başarıyla eklendi.", "Başarılı");
            SubeListesi();
        }

        private void simpleButton_Sil_Click(object sender, EventArgs e)
        {
            if (tileView_SubeListesi.FocusedRowHandle < 0 || (int)tileView_SubeListesi.GetFocusedRowCellValue(tileViewColumn_SubeID) == -1)
            {
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Lütfen silmek istediğiniz şubeyi seçiniz.", "Uyarı");
                return;
            }
            _subeService.SubeSil(Convert.ToInt32(tileView_SubeListesi.GetFocusedRowCellValue(tileViewColumn_SubeID).ToString()), (int)Sayfalar.Sube_Islemleri, StaticClass.KulID);
            GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Bilgi, "Şube başarıyla silindi.", "Başarılı");
            SubeListesi();

        }

        private void tileView_SubeListesi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
                return;
            if ((int)tileView_SubeListesi.GetRowCellValue(e.FocusedRowHandle, tileViewColumn_SubeID) == -1)
            {
                textEdit_SubeAdi.Text = string.Empty;
                textEdit_TelefonNo.Text = string.Empty;
                memoEdit_Adres.Text = string.Empty;
                return;
            }

                textEdit_SubeAdi.Text = tileView_SubeListesi.GetFocusedRowCellValue(tileViewColumn_SubeAdi).ToString();
                textEdit_TelefonNo.Text = tileView_SubeListesi.GetFocusedRowCellValue(tileViewColumn_TelefonNo).ToString();
                memoEdit_Adres.Text = tileView_SubeListesi.GetFocusedRowCellValue(tileViewColumn_Adres).ToString();
        }
    }
}