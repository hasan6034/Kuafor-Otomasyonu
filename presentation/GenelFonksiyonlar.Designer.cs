namespace Kuafor_Otomasyonu
{
    partial class GenelFonksiyonlar
    {

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private static void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenelFonksiyonlar));
            svgImages = new DevExpress.Utils.SvgImageCollection(components);
            htmlMessageTemplateCollection = new DevExpress.Utils.Html.HtmlTemplateCollection();
            Hata = new DevExpress.Utils.Html.HtmlTemplate();
            Uyarı = new DevExpress.Utils.Html.HtmlTemplate();
            Bilgi = new DevExpress.Utils.Html.HtmlTemplate();
            Soru = new DevExpress.Utils.Html.HtmlTemplate();
            print = new DevExpress.Utils.Html.HtmlTemplate();
            ((System.ComponentModel.ISupportInitialize)(svgImages)).BeginInit();
            // 
            // svgImages
            // 
            svgImages.Add("close", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.close"))));
            svgImages.Add("actions_check", "image://svgimages/icon builder/actions_check.svg");
            svgImages.Add("bo_attention", "image://svgimages/business objects/bo_attention.svg");
            svgImages.Add("security_warningcircled1", "image://svgimages/icon builder/security_warningcircled1.svg");
            svgImages.Add("actions_question", "image://svgimages/icon builder/actions_question.svg");
            // 
            // htmlMessageTemplateCollection
            // 
            htmlMessageTemplateCollection.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            Hata,
            Uyarı,
            Bilgi,
            Soru,
            print});
            // 
            // Hata
            // 
            Hata.Name = "Hata";
            Hata.PreviewType = typeof(DevExpress.XtraEditors.XtraMessageBox);
            Hata.Styles = resources.GetString("Hata.Styles");
            Hata.Tag = "Confirmation Message #1";
            Hata.Template = resources.GetString("Hata.Template");
            // 
            // Uyarı
            // 
            Uyarı.Name = "Uyarı";
            Uyarı.PreviewType = typeof(DevExpress.XtraEditors.XtraMessageBox);
            Uyarı.Styles = resources.GetString("Uyarı.Styles");
            Uyarı.Tag = "Confirmation Message #2";
            Uyarı.Template = resources.GetString("Uyarı.Template");
            // 
            // Bilgi
            // 
            Bilgi.Name = "Bilgi";
            Bilgi.PreviewType = typeof(DevExpress.XtraEditors.XtraMessageBox);
            Bilgi.Styles = resources.GetString("Bilgi.Styles");
            Bilgi.Tag = "Notification Message";
            Bilgi.Template = resources.GetString("Bilgi.Template");
            // 
            // Soru
            // 
            Soru.Name = "Soru";
            Soru.Styles = resources.GetString("Soru.Styles");
            Soru.Template = resources.GetString("Soru.Template");
            // 
            // print
            // 
            print.Name = "print";
            print.Styles = resources.GetString("print.Styles");
            print.Template = resources.GetString("print.Template");
            ((System.ComponentModel.ISupportInitialize)(svgImages)).EndInit();

        }

        #endregion

        private static DevExpress.Utils.Html.HtmlTemplate print;
        private static System.ComponentModel.IContainer components;
        private static DevExpress.Utils.SvgImageCollection svgImages;
        private static DevExpress.Utils.Html.HtmlTemplateCollection htmlMessageTemplateCollection;
        private static DevExpress.Utils.Html.HtmlTemplate Hata;
        private static DevExpress.Utils.Html.HtmlTemplate Uyarı;
        private static DevExpress.Utils.Html.HtmlTemplate Bilgi;
        private static DevExpress.Utils.Html.HtmlTemplate Soru;
    }
}
