﻿using Core.DTOs;
using Core.Enums;
using Core.IServices;
using DevExpress.XtraEditors;
using Repository.Repositories;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using DxDialog = DevExpress.Utils.CommonDialogs.Internal;

namespace Kuafor_Otomasyonu
{
    public partial class frmAnaEkran : XtraForm
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private readonly IGenelService _genelService = new GenelService(
            new GenelRepository(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString));

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {
            tileControl_Menu.ShowGroupText = true;
            this.Text = this.Text + " - " + StaticClass.AdSoyad;
            IEnumerable<MenuGetirDTO> i = _genelService.MenuGetir(StaticClass.RoleID);
            foreach (var item in i)
            {
                switch (item.SayfaID)
                {
                    case (int)Sayfalar.Kullanici_Islemleri:
                        tileItem_KullaniciIslemleri.Visible = true; break;
                    case (int)Sayfalar.Kullanici_Rol_Tanimlari:
                        tileItem_RolTanimlama.Visible = true; break;
                    case (int)Sayfalar.Sube_Islemleri:
                        tileItem_Subeler.Visible = true; break;
                    case (int)Sayfalar.Hizmet_Islemleri:
                        tileItem_Hizmetler.Visible = true; break;
                    case (int)Sayfalar.Musteri_Islemleri:
                        tileItem_MusteriIslemleri.Visible = true; break;
                    case (int)Sayfalar.Randevu_Islemleri:
                        tileItem_Randevu.Visible = true; break;
                    case (int)Sayfalar.Musteri_Bazli_Rapor:
                        tileItem_MusteriRaporu.Visible = true; break;
                    case (int)Sayfalar.Personel_Bazli_Rapor:
                        tileItem_PersonelBazliRapor.Visible = true; break;
                    case (int)Sayfalar.Sube_Bazli_Rapor:
                        tileItem_SubeBazliRapor.Visible = true; break;
                    default:
                        break;
                }
            }
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
            FormAc<FrmKullaniciIslemleri>();
        }

        private void tileItem_RolTanimlama_ItemClick(object sender, TileItemEventArgs e)
        {
            FormAc<FrmRolYetki>();
        }

        public void FormAc<T>(params object[] fparams) where T : Form
        {
            string formName = typeof(T).Name;
            if (Application.OpenForms[formName] == null)
            {
                Form form;
                if (fparams.Length > 0)
                {
                    form = (Form)Activator.CreateInstance(typeof(T), fparams);
                }
                else
                {
                    form = (Form)Activator.CreateInstance(typeof(T));
                }
                form.Show();
            }
            else
            {
                Form acikForm = Application.OpenForms[formName];
                if (acikForm.WindowState == FormWindowState.Minimized)
                {
                    acikForm.WindowState = FormWindowState.Normal;
                }
                acikForm.Activate();
            }
        }
    }
}