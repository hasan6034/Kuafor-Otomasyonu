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
using Core.Enums;
using Core.IServices;
using DevExpress.XtraEditors;
using Repository.Repositories;
using Service.Services;

namespace Kuafor_Otomasyonu
{
    public partial class FrmHizmetIslemleri : DevExpress.XtraEditors.XtraForm
    {
        public FrmHizmetIslemleri()
        {
            InitializeComponent();
        }

        #region ..: Declare :..

        private readonly IHizmetService _hizmetService = new HizmetService(
           new HizmetRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

        private readonly IGenelService _genelService = new GenelService(
           new GenelRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

        #endregion

        private void FrmHizmetIslemleri_Load(object sender, EventArgs e)
        {
            HizmetListele();
        }

        private void HizmetListele()
        {
            gridControl_Hizmetler.DataSource = _hizmetService.GetHizmetler(-1);
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButtonSil_Click(object sender, EventArgs e)
        {
            int hizmetId = Convert.ToInt32(tileView_Hizmetler.GetFocusedRowCellValue("HizmetID"));
            if (hizmetId == -1)
            {
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Dikkat, "Hizmet Seç", "Uyarı");
                return;
            }
            DialogResult dialogResult = XtraMessageBox.Show("Seçilen Hizmeti Silmek İstediğinize Emin Misiniz?", "Hizmet Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                _hizmetService.HizmetDELETE(hizmetId,(int)Sayfalar.Hizmet_Islemleri,StaticClass.KulID);
                HizmetListele();
                GenelFonksiyonlar.MesajGoster(GenelFonksiyonlar.MesajTipleri.Bilgi, "Hizmet Silindi", "Bilgilendirme");
            }
        }

        private void simpleButton_Kaydet_Click(object sender, EventArgs e)
        {
            string hizmetAdi = textEdit_HizmetAdi.Text.Trim();
            double hizmetFiyati = Convert.ToDouble(textEdit_HizmetFiyati.Text.Trim());
            int hizmetId = Convert.ToInt32(tileView_Hizmetler.GetFocusedRowCellValue("HizmetID"));

            _hizmetService.HizmetSAVE(hizmetId, hizmetAdi, hizmetFiyati, (int)Sayfalar.Hizmet_Islemleri, StaticClass.KulID);
            HizmetListele();
        }
    }
}