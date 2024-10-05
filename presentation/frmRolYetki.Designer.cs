namespace Kuafor_Otomasyonu
{
    partial class FrmRolYetki
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.tileViewColumn_RolAdi = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_KullaniciSayisi = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridControl_RolListesi = new DevExpress.XtraGrid.GridControl();
            this.tileView_RolListesi = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.tileViewColumn_RolID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl_RolListesi = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton_RolSil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_RolKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit_RolAdi = new DevExpress.XtraEditors.TextEdit();
            this.gridControl_RolYetki = new DevExpress.XtraGrid.GridControl();
            this.gridView_RolYetki = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_RolID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_RolAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_SayfaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_SayfaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_ModulAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_Okuma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_Yazma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_Duzenleme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_Silme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_RolListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView_RolListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_RolListesi)).BeginInit();
            this.groupControl_RolListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_RolAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_RolYetki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_RolYetki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileViewColumn_RolAdi
            // 
            this.tileViewColumn_RolAdi.FieldName = "RolAdi";
            this.tileViewColumn_RolAdi.Name = "tileViewColumn_RolAdi";
            this.tileViewColumn_RolAdi.Visible = true;
            this.tileViewColumn_RolAdi.VisibleIndex = 0;
            // 
            // tileViewColumn_KullaniciSayisi
            // 
            this.tileViewColumn_KullaniciSayisi.Caption = "Kullanıcı Sayısı";
            this.tileViewColumn_KullaniciSayisi.FieldName = "KullaniciSayisi";
            this.tileViewColumn_KullaniciSayisi.Name = "tileViewColumn_KullaniciSayisi";
            this.tileViewColumn_KullaniciSayisi.Visible = true;
            this.tileViewColumn_KullaniciSayisi.VisibleIndex = 1;
            // 
            // gridControl_RolListesi
            // 
            this.gridControl_RolListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_RolListesi.Location = new System.Drawing.Point(2, 29);
            this.gridControl_RolListesi.MainView = this.tileView_RolListesi;
            this.gridControl_RolListesi.Name = "gridControl_RolListesi";
            this.gridControl_RolListesi.Size = new System.Drawing.Size(322, 420);
            this.gridControl_RolListesi.TabIndex = 0;
            this.gridControl_RolListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView_RolListesi});
            // 
            // tileView_RolListesi
            // 
            this.tileView_RolListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tileViewColumn_RolAdi,
            this.tileViewColumn_RolID,
            this.tileViewColumn_KullaniciSayisi});
            this.tileView_RolListesi.GridControl = this.gridControl_RolListesi;
            this.tileView_RolListesi.Name = "tileView_RolListesi";
            this.tileView_RolListesi.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView_RolListesi.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView_RolListesi.OptionsTiles.IndentBetweenItems = 0;
            this.tileView_RolListesi.OptionsTiles.ItemSize = new System.Drawing.Size(246, 62);
            this.tileView_RolListesi.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView_RolListesi.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView_RolListesi.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView_RolListesi.OptionsTiles.RowCount = 0;
            tableColumnDefinition1.Length.Value = 140D;
            this.tileView_RolListesi.TileColumns.Add(tableColumnDefinition1);
            tableRowDefinition1.Length.Value = 25D;
            tableRowDefinition2.Length.Value = 21D;
            this.tileView_RolListesi.TileRows.Add(tableRowDefinition1);
            this.tileView_RolListesi.TileRows.Add(tableRowDefinition2);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Column = this.tileViewColumn_RolAdi;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "tileViewColumn_RolAdi";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Column = this.tileViewColumn_KullaniciSayisi;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "tileViewColumn_KullaniciSayisi";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView_RolListesi.TileTemplate.Add(tileViewItemElement1);
            this.tileView_RolListesi.TileTemplate.Add(tileViewItemElement2);
            this.tileView_RolListesi.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.tileView_RolListesi_FocusedRowChanged);
            // 
            // tileViewColumn_RolID
            // 
            this.tileViewColumn_RolID.FieldName = "RolID";
            this.tileViewColumn_RolID.Name = "tileViewColumn_RolID";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl_RolListesi);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButton_RolSil);
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButton_RolKaydet);
            this.splitContainerControl1.Panel2.Controls.Add(this.label1);
            this.splitContainerControl1.Panel2.Controls.Add(this.textEdit_RolAdi);
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl_RolYetki);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(944, 451);
            this.splitContainerControl1.SplitterPosition = 326;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // groupControl_RolListesi
            // 
            this.groupControl_RolListesi.Controls.Add(this.gridControl_RolListesi);
            this.groupControl_RolListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_RolListesi.Location = new System.Drawing.Point(0, 0);
            this.groupControl_RolListesi.Name = "groupControl_RolListesi";
            this.groupControl_RolListesi.Size = new System.Drawing.Size(326, 451);
            this.groupControl_RolListesi.TabIndex = 0;
            this.groupControl_RolListesi.Text = "Rol Listesi";
            // 
            // simpleButton_RolSil
            // 
            this.simpleButton_RolSil.Location = new System.Drawing.Point(290, 24);
            this.simpleButton_RolSil.Name = "simpleButton_RolSil";
            this.simpleButton_RolSil.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_RolSil.TabIndex = 2;
            this.simpleButton_RolSil.Text = "Sil";
            this.simpleButton_RolSil.Click += new System.EventHandler(this.SimpleButton_RolSil_Click);
            // 
            // simpleButton_RolKaydet
            // 
            this.simpleButton_RolKaydet.Location = new System.Drawing.Point(209, 24);
            this.simpleButton_RolKaydet.Name = "simpleButton_RolKaydet";
            this.simpleButton_RolKaydet.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_RolKaydet.TabIndex = 1;
            this.simpleButton_RolKaydet.Text = "Kaydet";
            this.simpleButton_RolKaydet.Click += new System.EventHandler(this.SimpleButton_RolKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rol Adı";
            // 
            // textEdit_RolAdi
            // 
            this.textEdit_RolAdi.EnterMoveNextControl = true;
            this.textEdit_RolAdi.Location = new System.Drawing.Point(77, 21);
            this.textEdit_RolAdi.Name = "textEdit_RolAdi";
            this.textEdit_RolAdi.Size = new System.Drawing.Size(126, 28);
            this.textEdit_RolAdi.TabIndex = 0;
            // 
            // gridControl_RolYetki
            // 
            this.gridControl_RolYetki.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl_RolYetki.Location = new System.Drawing.Point(0, 57);
            this.gridControl_RolYetki.MainView = this.gridView_RolYetki;
            this.gridControl_RolYetki.Name = "gridControl_RolYetki";
            this.gridControl_RolYetki.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl_RolYetki.Size = new System.Drawing.Size(602, 394);
            this.gridControl_RolYetki.TabIndex = 3;
            this.gridControl_RolYetki.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_RolYetki});
            // 
            // gridView_RolYetki
            // 
            this.gridView_RolYetki.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_RolID,
            this.gridColumn_RolAdi,
            this.gridColumn_SayfaID,
            this.gridColumn_SayfaAdi,
            this.gridColumn_ModulAdi,
            this.gridColumn_Okuma,
            this.gridColumn_Yazma,
            this.gridColumn_Duzenleme,
            this.gridColumn_Silme});
            this.gridView_RolYetki.GridControl = this.gridControl_RolYetki;
            this.gridView_RolYetki.GroupCount = 1;
            this.gridView_RolYetki.Name = "gridView_RolYetki";
            this.gridView_RolYetki.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView_RolYetki.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView_RolYetki.OptionsSelection.MultiSelect = true;
            this.gridView_RolYetki.OptionsView.ColumnAutoWidth = false;
            this.gridView_RolYetki.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridView_RolYetki.OptionsView.ShowAutoFilterRow = true;
            this.gridView_RolYetki.OptionsView.ShowFooter = true;
            this.gridView_RolYetki.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn_ModulAdi, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn_RolID
            // 
            this.gridColumn_RolID.Caption = "Rol ID";
            this.gridColumn_RolID.FieldName = "RolID";
            this.gridColumn_RolID.Name = "gridColumn_RolID";
            // 
            // gridColumn_RolAdi
            // 
            this.gridColumn_RolAdi.Caption = "RolAdi";
            this.gridColumn_RolAdi.FieldName = "RolAdi";
            this.gridColumn_RolAdi.Name = "gridColumn_RolAdi";
            // 
            // gridColumn_SayfaID
            // 
            this.gridColumn_SayfaID.Caption = "SayfaID";
            this.gridColumn_SayfaID.FieldName = "SayfaID";
            this.gridColumn_SayfaID.Name = "gridColumn_SayfaID";
            // 
            // gridColumn_SayfaAdi
            // 
            this.gridColumn_SayfaAdi.Caption = "Sayfa Adı";
            this.gridColumn_SayfaAdi.FieldName = "SayfaAdi";
            this.gridColumn_SayfaAdi.Name = "gridColumn_SayfaAdi";
            this.gridColumn_SayfaAdi.Visible = true;
            this.gridColumn_SayfaAdi.VisibleIndex = 0;
            // 
            // gridColumn_ModulAdi
            // 
            this.gridColumn_ModulAdi.Caption = "Modül Adı";
            this.gridColumn_ModulAdi.FieldName = "ModulAdi";
            this.gridColumn_ModulAdi.Name = "gridColumn_ModulAdi";
            this.gridColumn_ModulAdi.Visible = true;
            this.gridColumn_ModulAdi.VisibleIndex = 5;
            // 
            // gridColumn_Okuma
            // 
            this.gridColumn_Okuma.Caption = "Okuma";
            this.gridColumn_Okuma.FieldName = "Okuma";
            this.gridColumn_Okuma.Name = "gridColumn_Okuma";
            this.gridColumn_Okuma.Visible = true;
            this.gridColumn_Okuma.VisibleIndex = 1;
            // 
            // gridColumn_Yazma
            // 
            this.gridColumn_Yazma.Caption = "Yazma";
            this.gridColumn_Yazma.FieldName = "Yazma";
            this.gridColumn_Yazma.Name = "gridColumn_Yazma";
            this.gridColumn_Yazma.Visible = true;
            this.gridColumn_Yazma.VisibleIndex = 2;
            // 
            // gridColumn_Duzenleme
            // 
            this.gridColumn_Duzenleme.Caption = "Duzenleme";
            this.gridColumn_Duzenleme.FieldName = "Duzenleme";
            this.gridColumn_Duzenleme.Name = "gridColumn_Duzenleme";
            this.gridColumn_Duzenleme.Visible = true;
            this.gridColumn_Duzenleme.VisibleIndex = 3;
            // 
            // gridColumn_Silme
            // 
            this.gridColumn_Silme.Caption = "Silme";
            this.gridColumn_Silme.FieldName = "Silme";
            this.gridColumn_Silme.Name = "gridColumn_Silme";
            this.gridColumn_Silme.Visible = true;
            this.gridColumn_Silme.VisibleIndex = 4;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // FrmRolYetki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 451);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmRolYetki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rol Yetki";
            this.Load += new System.EventHandler(this.FrmRolYetki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_RolListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView_RolListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            this.splitContainerControl1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_RolListesi)).EndInit();
            this.groupControl_RolListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_RolAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_RolYetki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_RolYetki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_RolListesi;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView_RolListesi;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_RolAdi;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_RolID;
        private DevExpress.XtraEditors.GroupControl groupControl_RolListesi;
        private DevExpress.XtraGrid.GridControl gridControl_RolYetki;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_RolYetki;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_RolID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_RolAdi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_SayfaID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_ModulAdi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_Okuma;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_Yazma;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_Duzenleme;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_Silme;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_SayfaAdi;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_RolSil;
        private DevExpress.XtraEditors.SimpleButton simpleButton_RolKaydet;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit_RolAdi;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_KullaniciSayisi;
    }
}