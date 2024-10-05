using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DxDialog = DevExpress.Utils.CommonDialogs.Internal.DialogResult;

namespace Kuafor_Otomasyonu
{
    public partial class GenelFonksiyonlar : Component
    {
        public GenelFonksiyonlar()
        {
            InitializeComponent();
        }

        public GenelFonksiyonlar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public enum MesajTipleri
        {
            Hata,
            Dikkat,
            Bilgi,
            Soru,
            Print
        }

        public static DxDialog MesajGoster(MesajTipleri tip, string mesajStr, string baslik)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            InitializeComponent();

            DxDialog secim = DxDialog.None;
            switch (tip)
            {
                case MesajTipleri.Hata://Hata
                    args.HtmlTemplate.Assign(htmlMessageTemplateCollection.ElementAt(0));
                    args.Caption = baslik;
                    args.Text = mesajStr;
                    args.HtmlImages = svgImages;
                    args.ImageOptions.SvgImage = svgImages.ElementAt(3);
                    secim = (DxDialog)XtraMessageBox.Show(args);
                    break;

                case MesajTipleri.Dikkat://"Dikkat":
                    args.HtmlTemplate.Assign(htmlMessageTemplateCollection.ElementAt(1));
                    args.Caption = baslik;
                    args.Text = mesajStr;
                    args.HtmlImages = svgImages;
                    args.ImageOptions.SvgImage = svgImages.ElementAt(2);
                    secim = (DxDialog)XtraMessageBox.Show(args);
                    break;

                case MesajTipleri.Bilgi:
                    args.HtmlTemplate.Assign(htmlMessageTemplateCollection.ElementAt(2));
                    args.Caption = baslik;
                    args.Text = mesajStr;
                    args.HtmlImages = svgImages;
                    args.ImageOptions.SvgImage = svgImages.ElementAt(1);
                    secim = (DxDialog)XtraMessageBox.Show(args);
                    break;
                case MesajTipleri.Soru:
                    args.HtmlTemplate.Assign(htmlMessageTemplateCollection.ElementAt(3));
                    args.Caption = baslik;
                    args.Text = mesajStr;
                    args.HtmlImages = svgImages;
                    args.ImageOptions.SvgImage = svgImages.ElementAt(4);
                    secim = (DxDialog)XtraMessageBox.Show(args);
                    break;
                case MesajTipleri.Print:
                    args.HtmlTemplate.Assign(htmlMessageTemplateCollection.ElementAt(4));
                    args.Caption = baslik;
                    args.Text = mesajStr;
                    args.HtmlImages = svgImages;
                    args.ImageOptions.SvgImage = svgImages.ElementAt(4);
                    secim = (DxDialog)XtraMessageBox.Show(args);
                    break;
            }
            return secim;
        }
	}
}
