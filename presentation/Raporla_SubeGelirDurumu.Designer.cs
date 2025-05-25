namespace Kuafor_Otomasyonu
{
    partial class Raporla_SubeGelirDurumu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporla_SubeGelirDurumu));
            DevExpress.XtraReports.UI.XRWatermark xrWatermark1 = new DevExpress.XtraReports.UI.XRWatermark();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.detailTable = new DevExpress.XtraReports.UI.XRTable();
            this.detailTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.productName = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.productDescription = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.detailTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.vendorContactsTable = new DevExpress.XtraReports.UI.XRTable();
            this.vendorContactsRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.vendorWebsite = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorEmail = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.invoiceInfoTable = new DevExpress.XtraReports.UI.XRTable();
            this.invoiceDateRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.invoiceDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.customerTable = new DevExpress.XtraReports.UI.XRTable();
            this.customerNameRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.customerName = new DevExpress.XtraReports.UI.XRTableCell();
            this.customerContactNameRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.customerContactName = new DevExpress.XtraReports.UI.XRTableCell();
            this.customerAddressRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.customerAddress = new DevExpress.XtraReports.UI.XRTableCell();
            this.customerCityRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.customerCity = new DevExpress.XtraReports.UI.XRTableCell();
            this.vendorLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.totalTable = new DevExpress.XtraReports.UI.XRTable();
            this.totalCaptionRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.subtotalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.taxCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.totalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.totalRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.subtotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.tax = new DevExpress.XtraReports.UI.XRTableCell();
            this.total = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.headerTable = new DevExpress.XtraReports.UI.XRTable();
            this.headerTableRow = new DevExpress.XtraReports.UI.XRTableRow();
            this.quantityCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.unitPriceCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.lineTotalCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.productNameCaption = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.baseControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorContactsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceInfoTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.detailTable});
            this.Detail.HeightF = 72F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StyleName = "baseControlStyle";
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine1
            // 
            this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(203)))), ((int)(((byte)(200)))));
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0.0001926422F, 70F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(699.9998F, 2F);
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // detailTable
            // 
            this.detailTable.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(25.00006F, 0F);
            this.detailTable.Name = "detailTable";
            this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.detailTableRow1,
            this.detailTableRow2});
            this.detailTable.SizeF = new System.Drawing.SizeF(649.9999F, 70F);
            this.detailTable.StylePriority.UseBorderColor = false;
            this.detailTable.StylePriority.UseBorders = false;
            this.detailTable.StylePriority.UseFont = false;
            // 
            // detailTableRow1
            // 
            this.detailTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productName,
            this.unitPrice,
            this.lineTotal});
            this.detailTableRow1.Name = "detailTableRow1";
            this.detailTableRow1.Weight = 10.58D;
            // 
            // productName
            // 
            this.productName.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.productName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SubeAdi]")});
            this.productName.Name = "productName";
            this.productName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 15, 0, 100F);
            this.productName.StylePriority.UseBackColor = false;
            this.productName.StylePriority.UseBorders = false;
            this.productName.StylePriority.UseFont = false;
            this.productName.StylePriority.UsePadding = false;
            this.productName.StylePriority.UseTextAlignment = false;
            this.productName.Text = "ProductName";
            this.productName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.productName.Weight = 1.2443615075852237D;
            // 
            // unitPrice
            // 
            this.unitPrice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SubeKDV]")});
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.unitPrice.RowSpan = 2;
            this.unitPrice.StylePriority.UseBackColor = false;
            this.unitPrice.StylePriority.UseBorders = false;
            this.unitPrice.StylePriority.UseFont = false;
            this.unitPrice.StylePriority.UsePadding = false;
            this.unitPrice.StylePriority.UseTextAlignment = false;
            this.unitPrice.Text = "0,00₺";
            this.unitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.unitPrice.TextFormatString = "{0:$0.00}";
            this.unitPrice.Weight = 0.30808933066042288D;
            // 
            // lineTotal
            // 
            this.lineTotal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ToplamGelir]")});
            this.lineTotal.Name = "lineTotal";
            this.lineTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 5, 0, 100F);
            this.lineTotal.RowSpan = 2;
            this.lineTotal.StylePriority.UseBackColor = false;
            this.lineTotal.StylePriority.UseBorders = false;
            this.lineTotal.StylePriority.UseFont = false;
            this.lineTotal.StylePriority.UseForeColor = false;
            this.lineTotal.StylePriority.UsePadding = false;
            this.lineTotal.StylePriority.UseTextAlignment = false;
            this.lineTotal.Text = "0,00₺";
            this.lineTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lineTotal.TextFormatString = "{0:$0.00}";
            this.lineTotal.Weight = 0.32149706758539826D;
            // 
            // detailTableRow2
            // 
            this.detailTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.productDescription,
            this.detailTableCell2,
            this.detailTableCell5});
            this.detailTableRow2.Name = "detailTableRow2";
            this.detailTableRow2.Weight = 10.58D;
            // 
            // productDescription
            // 
            this.productDescription.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Adres]")});
            this.productDescription.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8.75F);
            this.productDescription.ForeColor = System.Drawing.Color.Gray;
            this.productDescription.Name = "productDescription";
            this.productDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 15, 100F);
            this.productDescription.StylePriority.UseBackColor = false;
            this.productDescription.StylePriority.UseBorders = false;
            this.productDescription.StylePriority.UseFont = false;
            this.productDescription.StylePriority.UseForeColor = false;
            this.productDescription.StylePriority.UsePadding = false;
            this.productDescription.Text = "ProductDescription";
            this.productDescription.Weight = 1.2443615075852237D;
            // 
            // detailTableCell2
            // 
            this.detailTableCell2.Name = "detailTableCell2";
            this.detailTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.detailTableCell2.StylePriority.UsePadding = false;
            this.detailTableCell2.StylePriority.UseTextAlignment = false;
            this.detailTableCell2.Weight = 0.30808933066042288D;
            // 
            // detailTableCell5
            // 
            this.detailTableCell5.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.detailTableCell5.Name = "detailTableCell5";
            this.detailTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100F);
            this.detailTableCell5.StylePriority.UseFont = false;
            this.detailTableCell5.StylePriority.UsePadding = false;
            this.detailTableCell5.StylePriority.UseTextAlignment = false;
            this.detailTableCell5.Weight = 0.32149706758539826D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 75F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.StylePriority.UseBackColor = false;
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.vendorContactsTable});
            this.BottomMargin.HeightF = 125F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // vendorContactsTable
            // 
            this.vendorContactsTable.BorderColor = System.Drawing.Color.Gray;
            this.vendorContactsTable.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8.75F);
            this.vendorContactsTable.LocationFloat = new DevExpress.Utils.PointFloat(25.00014F, 9.999906F);
            this.vendorContactsTable.Name = "vendorContactsTable";
            this.vendorContactsTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.vendorContactsTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.vendorContactsRow});
            this.vendorContactsTable.SizeF = new System.Drawing.SizeF(649.9999F, 44.58339F);
            this.vendorContactsTable.StylePriority.UseBorderColor = false;
            this.vendorContactsTable.StylePriority.UseFont = false;
            this.vendorContactsTable.StylePriority.UsePadding = false;
            // 
            // vendorContactsRow
            // 
            this.vendorContactsRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.vendorWebsite,
            this.vendorEmail});
            this.vendorContactsRow.Name = "vendorContactsRow";
            this.vendorContactsRow.Weight = 1D;
            // 
            // vendorWebsite
            // 
            this.vendorWebsite.Font = new DevExpress.Drawing.DXFont("Segoe UI", 8.75F, DevExpress.Drawing.DXFontStyle.Bold);
            this.vendorWebsite.Name = "vendorWebsite";
            this.vendorWebsite.StylePriority.UseFont = false;
            this.vendorWebsite.StylePriority.UseTextAlignment = false;
            this.vendorWebsite.Text = "Website:";
            this.vendorWebsite.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.vendorWebsite.Weight = 0.52962963100373006D;
            // 
            // vendorEmail
            // 
            this.vendorEmail.Name = "vendorEmail";
            this.vendorEmail.StylePriority.UseBorders = false;
            this.vendorEmail.StylePriority.UseTextAlignment = false;
            this.vendorEmail.Text = "www.kmukuafor.com.tr";
            this.vendorEmail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.vendorEmail.Weight = 1.5819903590008908D;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 220F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StyleName = "baseControlStyle";
            this.GroupHeader2.StylePriority.UseBackColor = false;
            this.GroupHeader2.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1});
            // 
            // xrPanel1
            // 
            this.xrPanel1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.invoiceInfoTable,
            this.xrLabel2,
            this.xrLabel1,
            this.customerTable,
            this.vendorLogo});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(7.152557E-05F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(700F, 220F);
            this.xrPanel1.StylePriority.UseBackColor = false;
            // 
            // invoiceInfoTable
            // 
            this.invoiceInfoTable.LocationFloat = new DevExpress.Utils.PointFloat(10.00006F, 179.9999F);
            this.invoiceInfoTable.Name = "invoiceInfoTable";
            this.invoiceInfoTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.invoiceDateRow});
            this.invoiceInfoTable.SizeF = new System.Drawing.SizeF(224.3567F, 20.00008F);
            // 
            // invoiceDateRow
            // 
            this.invoiceDateRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.invoiceDate});
            this.invoiceDateRow.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AccessibleDescription", "[SimdikiTarihSaat]")});
            this.invoiceDateRow.Name = "invoiceDateRow";
            this.invoiceDateRow.Weight = 1.0335367382568692D;
            // 
            // invoiceDate
            // 
            this.invoiceDate.CanGrow = false;
            this.invoiceDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SimdikiTarihSaat]")});
            this.invoiceDate.Font = new DevExpress.Drawing.DXFont("Segoe UI", 12F);
            this.invoiceDate.Name = "invoiceDate";
            this.invoiceDate.StylePriority.UseFont = false;
            this.invoiceDate.StylePriority.UseTextAlignment = false;
            this.invoiceDate.Text = "InvoiceDate";
            this.invoiceDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.invoiceDate.TextFormatString = "{0:dd.MM.yyyy HH:mm}";
            this.invoiceDate.Weight = 0.912698488401723D;
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10F, 130F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(224.3568F, 19.63325F);
            this.xrLabel2.Text = "RAPORUN OLUŞTURULMA ZAMANI";
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(204.3589F, 40.83333F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(348.6057F, 19.63325F);
            this.xrLabel1.Text = "KMÜ KUAFÖR OTOMASYONU RAPORLAMA SİSTEMİ";
            // 
            // customerTable
            // 
            this.customerTable.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
            this.customerTable.LocationFloat = new DevExpress.Utils.PointFloat(419.9999F, 130F);
            this.customerTable.Name = "customerTable";
            this.customerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.customerNameRow,
            this.customerContactNameRow,
            this.customerAddressRow,
            this.customerCityRow});
            this.customerTable.SizeF = new System.Drawing.SizeF(255F, 90F);
            // 
            // customerNameRow
            // 
            this.customerNameRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.customerName});
            this.customerNameRow.Name = "customerNameRow";
            this.customerNameRow.Weight = 0.87272687850147868D;
            // 
            // customerName
            // 
            this.customerName.CanShrink = true;
            this.customerName.Font = new DevExpress.Drawing.DXFont("Segoe UI", 16F);
            this.customerName.Name = "customerName";
            this.customerName.StylePriority.UseFont = false;
            this.customerName.StylePriority.UsePadding = false;
            this.customerName.StylePriority.UseTextAlignment = false;
            this.customerName.Text = "ANA FİRMA        ";
            this.customerName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.customerName.Weight = 1.3674163189595685D;
            // 
            // customerContactNameRow
            // 
            this.customerContactNameRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.customerContactName});
            this.customerContactNameRow.Name = "customerContactNameRow";
            this.customerContactNameRow.Weight = 0.58181797314197325D;
            // 
            // customerContactName
            // 
            this.customerContactName.CanShrink = true;
            this.customerContactName.Name = "customerContactName";
            this.customerContactName.StylePriority.UseFont = false;
            this.customerContactName.StylePriority.UsePadding = false;
            this.customerContactName.StylePriority.UseTextAlignment = false;
            this.customerContactName.Text = "ÖZ ORAK TAHHÜT İNŞAAT EMLAK";
            this.customerContactName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.customerContactName.Weight = 1.3674163189595685D;
            // 
            // customerAddressRow
            // 
            this.customerAddressRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.customerAddress});
            this.customerAddressRow.Name = "customerAddressRow";
            this.customerAddressRow.Weight = 0.58181796653648D;
            // 
            // customerAddress
            // 
            this.customerAddress.CanShrink = true;
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.StylePriority.UseFont = false;
            this.customerAddress.StylePriority.UseTextAlignment = false;
            this.customerAddress.Text = "VERGİ NO:6621270230";
            this.customerAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.customerAddress.Weight = 1.3674163189595685D;
            // 
            // customerCityRow
            // 
            this.customerCityRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.customerCity});
            this.customerCityRow.Name = "customerCityRow";
            this.customerCityRow.Weight = 0.58181796653648D;
            // 
            // customerCity
            // 
            this.customerCity.Name = "customerCity";
            this.customerCity.StylePriority.UseFont = false;
            this.customerCity.StylePriority.UseTextAlignment = false;
            this.customerCity.Text = "VERGİ DAİRESİ: DİKİMEVİ VERGİ DAİRESİ";
            this.customerCity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.customerCity.Weight = 1.3674163189595685D;
            // 
            // vendorLogo
            // 
            this.vendorLogo.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.TopLeft;
            this.vendorLogo.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::Kuafor_Otomasyonu.Properties.Resources.Kuafor, true);
            this.vendorLogo.LocationFloat = new DevExpress.Utils.PointFloat(0.000131925F, 0F);
            this.vendorLogo.Name = "vendorLogo";
            this.vendorLogo.SizeF = new System.Drawing.SizeF(146.3974F, 110F);
            this.vendorLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.vendorLogo.StylePriority.UseBorderColor = false;
            this.vendorLogo.StylePriority.UseBorders = false;
            this.vendorLogo.StylePriority.UsePadding = false;
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2});
            this.SubBand1.HeightF = 110F;
            this.SubBand1.Name = "SubBand1";
            // 
            // xrPanel2
            // 
            this.xrPanel2.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 0F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(700F, 110F);
            this.xrPanel2.StylePriority.UseBackColor = false;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.totalTable});
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 85F;
            this.GroupFooter1.KeepTogether = true;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.PrintAtBottom = true;
            this.GroupFooter1.StyleName = "baseControlStyle";
            // 
            // totalTable
            // 
            this.totalTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.totalTable.LocationFloat = new DevExpress.Utils.PointFloat(25.00006F, 0F);
            this.totalTable.Name = "totalTable";
            this.totalTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.totalCaptionRow,
            this.totalRow});
            this.totalTable.SizeF = new System.Drawing.SizeF(650F, 85F);
            this.totalTable.StylePriority.UseBackColor = false;
            // 
            // totalCaptionRow
            // 
            this.totalCaptionRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.subtotalCaption,
            this.taxCaption,
            this.totalCaption});
            this.totalCaptionRow.Name = "totalCaptionRow";
            this.totalCaptionRow.Weight = 0.41551542553740262D;
            // 
            // subtotalCaption
            // 
            this.subtotalCaption.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10.5F);
            this.subtotalCaption.Name = "subtotalCaption";
            this.subtotalCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.subtotalCaption.StylePriority.UseBackColor = false;
            this.subtotalCaption.StylePriority.UseFont = false;
            this.subtotalCaption.StylePriority.UsePadding = false;
            this.subtotalCaption.StylePriority.UseTextAlignment = false;
            this.subtotalCaption.Text = "Ara Toplam \"Vergiler Hariç\"";
            this.subtotalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.subtotalCaption.Weight = 1.082124518663595D;
            // 
            // taxCaption
            // 
            this.taxCaption.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10.5F);
            this.taxCaption.Name = "taxCaption";
            this.taxCaption.StylePriority.UseBackColor = false;
            this.taxCaption.StylePriority.UseFont = false;
            this.taxCaption.StylePriority.UseTextAlignment = false;
            this.taxCaption.Text = "Toplam KDV (%20)";
            this.taxCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.taxCaption.Weight = 0.49391183865966282D;
            // 
            // totalCaption
            // 
            this.totalCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.totalCaption.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10.5F);
            this.totalCaption.ForeColor = System.Drawing.Color.White;
            this.totalCaption.Name = "totalCaption";
            this.totalCaption.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.totalCaption.StylePriority.UseBackColor = false;
            this.totalCaption.StylePriority.UseFont = false;
            this.totalCaption.StylePriority.UseForeColor = false;
            this.totalCaption.StylePriority.UsePadding = false;
            this.totalCaption.StylePriority.UseTextAlignment = false;
            this.totalCaption.Text = "Genel Toplam (KDV Dahildir)";
            this.totalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
            this.totalCaption.Weight = 0.88333756348854675D;
            // 
            // totalRow
            // 
            this.totalRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.subtotal,
            this.tax,
            this.total});
            this.totalRow.Name = "totalRow";
            this.totalRow.Weight = 0.99723707212708534D;
            // 
            // subtotal
            // 
            this.subtotal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ToplamUcret]-[ToplamKDV]")});
            this.subtotal.Font = new DevExpress.Drawing.DXFont("Segoe UI", 16F);
            this.subtotal.Name = "subtotal";
            this.subtotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100F);
            this.subtotal.StylePriority.UseBackColor = false;
            this.subtotal.StylePriority.UseFont = false;
            this.subtotal.StylePriority.UsePadding = false;
            this.subtotal.StylePriority.UseTextAlignment = false;
            this.subtotal.Text = "0,00₺";
            this.subtotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.subtotal.TextFormatString = "{0:$0.00}";
            this.subtotal.Weight = 1.0821245162427311D;
            // 
            // tax
            // 
            this.tax.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ToplamKDV]")});
            this.tax.Font = new DevExpress.Drawing.DXFont("Segoe UI", 16F);
            this.tax.Name = "tax";
            this.tax.StylePriority.UseBackColor = false;
            this.tax.StylePriority.UseFont = false;
            this.tax.StylePriority.UseTextAlignment = false;
            this.tax.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tax.TextFormatString = "{0:$0.00}";
            this.tax.Weight = 0.4939118390364145D;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.total.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ToplamUcret]")});
            this.total.Font = new DevExpress.Drawing.DXFont("Segoe UI", 27F);
            this.total.ForeColor = System.Drawing.Color.White;
            this.total.Name = "total";
            this.total.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.total.StylePriority.UseBackColor = false;
            this.total.StylePriority.UseFont = false;
            this.total.StylePriority.UseForeColor = false;
            this.total.StylePriority.UsePadding = false;
            this.total.StylePriority.UseTextAlignment = false;
            this.total.Text = "0,00₺";
            this.total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.total.TextFormatString = "{0:$0.00}";
            this.total.Weight = 0.88333756352868242D;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel3});
            this.GroupHeader1.HeightF = 45F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            this.GroupHeader1.StyleName = "baseControlStyle";
            // 
            // xrPanel3
            // 
            this.xrPanel3.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.headerTable});
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(700F, 45F);
            this.xrPanel3.StylePriority.UseBackColor = false;
            // 
            // headerTable
            // 
            this.headerTable.Font = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            this.headerTable.LocationFloat = new DevExpress.Utils.PointFloat(25.00003F, 10.00001F);
            this.headerTable.Name = "headerTable";
            this.headerTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.headerTableRow});
            this.headerTable.SizeF = new System.Drawing.SizeF(650F, 35F);
            this.headerTable.StylePriority.UseFont = false;
            this.headerTable.StylePriority.UsePadding = false;
            // 
            // headerTableRow
            // 
            this.headerTableRow.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.quantityCaption,
            this.unitPriceCaption,
            this.lineTotalCaption});
            this.headerTableRow.Name = "headerTableRow";
            this.headerTableRow.Weight = 11.5D;
            // 
            // quantityCaption
            // 
            this.quantityCaption.Name = "quantityCaption";
            this.quantityCaption.StylePriority.UseBackColor = false;
            this.quantityCaption.StylePriority.UseFont = false;
            this.quantityCaption.StylePriority.UseForeColor = false;
            this.quantityCaption.StylePriority.UseTextAlignment = false;
            this.quantityCaption.Text = "ŞUBE BİLGİSİ";
            this.quantityCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.quantityCaption.Weight = 0.47339979826376616D;
            // 
            // unitPriceCaption
            // 
            this.unitPriceCaption.BorderColor = System.Drawing.Color.White;
            this.unitPriceCaption.Name = "unitPriceCaption";
            this.unitPriceCaption.StylePriority.UseBackColor = false;
            this.unitPriceCaption.StylePriority.UseBorderColor = false;
            this.unitPriceCaption.StylePriority.UseBorders = false;
            this.unitPriceCaption.StylePriority.UseFont = false;
            this.unitPriceCaption.StylePriority.UseForeColor = false;
            this.unitPriceCaption.StylePriority.UseTextAlignment = false;
            this.unitPriceCaption.Text = "KDV";
            this.unitPriceCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.unitPriceCaption.Weight = 0.11720831174144691D;
            // 
            // lineTotalCaption
            // 
            this.lineTotalCaption.BorderColor = System.Drawing.Color.White;
            this.lineTotalCaption.Name = "lineTotalCaption";
            this.lineTotalCaption.StylePriority.UseBackColor = false;
            this.lineTotalCaption.StylePriority.UseBorderColor = false;
            this.lineTotalCaption.StylePriority.UseBorders = false;
            this.lineTotalCaption.StylePriority.UseFont = false;
            this.lineTotalCaption.StylePriority.UseForeColor = false;
            this.lineTotalCaption.StylePriority.UseTextAlignment = false;
            this.lineTotalCaption.Text = "TOPLAM";
            this.lineTotalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lineTotalCaption.Weight = 0.12230904049113747D;
            // 
            // productNameCaption
            // 
            this.productNameCaption.Name = "productNameCaption";
            this.productNameCaption.StylePriority.UseBackColor = false;
            this.productNameCaption.StylePriority.UseFont = false;
            this.productNameCaption.StylePriority.UseForeColor = false;
            this.productNameCaption.StylePriority.UsePadding = false;
            this.productNameCaption.StylePriority.UseTextAlignment = false;
            this.productNameCaption.Text = "TASK DESCRIPTION";
            this.productNameCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.productNameCaption.Weight = 0.92679294563676229D;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "DBConnection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "Raporla_SubeGelirDurumu";
            storedProcQuery1.StoredProcName = "Raporla_SubeGelirDurumu";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // baseControlStyle
            // 
            this.baseControlStyle.Font = new DevExpress.Drawing.DXFont("Segoe UI", 9.75F);
            this.baseControlStyle.Name = "baseControlStyle";
            this.baseControlStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // Raporla_SubeGelirDurumu
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader2,
            this.GroupFooter1,
            this.GroupHeader1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "Raporla_SubeGelirDurumu";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new DevExpress.Drawing.DXMargins(75F, 75F, 75F, 125F);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.baseControlStyle});
            this.Version = "24.2";
            xrWatermark1.Id = "Watermark1";
            this.Watermarks.AddRange(new DevExpress.XtraPrinting.Drawing.Watermark[] {
            xrWatermark1});
            ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorContactsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceInfoTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRTable detailTable;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell productName;
        private DevExpress.XtraReports.UI.XRTableCell unitPrice;
        private DevExpress.XtraReports.UI.XRTableCell lineTotal;
        private DevExpress.XtraReports.UI.XRTableRow detailTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell productDescription;
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell detailTableCell5;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRTable vendorContactsTable;
        private DevExpress.XtraReports.UI.XRTableRow vendorContactsRow;
        private DevExpress.XtraReports.UI.XRTableCell vendorWebsite;
        private DevExpress.XtraReports.UI.XRTableCell vendorEmail;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRTable customerTable;
        private DevExpress.XtraReports.UI.XRTableRow customerNameRow;
        private DevExpress.XtraReports.UI.XRTableCell customerName;
        private DevExpress.XtraReports.UI.XRTableRow customerContactNameRow;
        private DevExpress.XtraReports.UI.XRTableCell customerContactName;
        private DevExpress.XtraReports.UI.XRTableRow customerAddressRow;
        private DevExpress.XtraReports.UI.XRTableCell customerAddress;
        private DevExpress.XtraReports.UI.XRTableRow customerCityRow;
        private DevExpress.XtraReports.UI.XRTableCell customerCity;
        private DevExpress.XtraReports.UI.XRPictureBox vendorLogo;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.XRTable invoiceInfoTable;
        private DevExpress.XtraReports.UI.XRTableRow invoiceDateRow;
        private DevExpress.XtraReports.UI.XRTableCell invoiceDate;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRTable totalTable;
        private DevExpress.XtraReports.UI.XRTableRow totalCaptionRow;
        private DevExpress.XtraReports.UI.XRTableCell subtotalCaption;
        private DevExpress.XtraReports.UI.XRTableCell taxCaption;
        private DevExpress.XtraReports.UI.XRTableCell totalCaption;
        private DevExpress.XtraReports.UI.XRTableRow totalRow;
        private DevExpress.XtraReports.UI.XRTableCell subtotal;
        private DevExpress.XtraReports.UI.XRTableCell tax;
        private DevExpress.XtraReports.UI.XRTableCell total;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel3;
        private DevExpress.XtraReports.UI.XRTable headerTable;
        private DevExpress.XtraReports.UI.XRTableRow headerTableRow;
        private DevExpress.XtraReports.UI.XRTableCell productNameCaption;
        private DevExpress.XtraReports.UI.XRTableCell quantityCaption;
        private DevExpress.XtraReports.UI.XRTableCell lineTotalCaption;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle baseControlStyle;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTableCell unitPriceCaption;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    }
}
