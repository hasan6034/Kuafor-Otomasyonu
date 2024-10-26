namespace Kuafor_Otomasyonu
{
    partial class frmSubeler
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
            this.tileViewColumn_SubeAdi = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_SubedekiElemanSayisi = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit_SubeAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl_SubeListesi = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_SubeListesi = new DevExpress.XtraGrid.GridControl();
            this.tileView_SubeListesi = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.tileViewColumn_SubeID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.label3 = new System.Windows.Forms.Label();
            this.textEdit_TelefonNo = new DevExpress.XtraEditors.TextEdit();
            this.memoEdit_Adres = new DevExpress.XtraEditors.MemoEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Sil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SubeAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_SubeListesi)).BeginInit();
            this.groupControl_SubeListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SubeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView_SubeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TelefonNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_Adres.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tileViewColumn_SubeAdi
            // 
            this.tileViewColumn_SubeAdi.FieldName = "SubeAdi";
            this.tileViewColumn_SubeAdi.Name = "tileViewColumn_SubeAdi";
            this.tileViewColumn_SubeAdi.Visible = true;
            this.tileViewColumn_SubeAdi.VisibleIndex = 0;
            // 
            // tileViewColumn_SubedekiElemanSayisi
            // 
            this.tileViewColumn_SubedekiElemanSayisi.Caption = "Eleman Sayısı";
            this.tileViewColumn_SubedekiElemanSayisi.FieldName = "ElemanSayisi";
            this.tileViewColumn_SubedekiElemanSayisi.Name = "tileViewColumn_SubedekiElemanSayisi";
            this.tileViewColumn_SubedekiElemanSayisi.Visible = true;
            this.tileViewColumn_SubedekiElemanSayisi.VisibleIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şube Adı :";
            // 
            // textEdit_SubeAdi
            // 
            this.textEdit_SubeAdi.EnterMoveNextControl = true;
            this.textEdit_SubeAdi.Location = new System.Drawing.Point(77, 21);
            this.textEdit_SubeAdi.Name = "textEdit_SubeAdi";
            this.textEdit_SubeAdi.Size = new System.Drawing.Size(292, 28);
            this.textEdit_SubeAdi.TabIndex = 0;
            // 
            // groupControl_SubeListesi
            // 
            this.groupControl_SubeListesi.Controls.Add(this.gridControl_SubeListesi);
            this.groupControl_SubeListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_SubeListesi.Location = new System.Drawing.Point(0, 0);
            this.groupControl_SubeListesi.Name = "groupControl_SubeListesi";
            this.groupControl_SubeListesi.Size = new System.Drawing.Size(352, 427);
            this.groupControl_SubeListesi.TabIndex = 0;
            this.groupControl_SubeListesi.Text = "Şube Listesi";
            // 
            // gridControl_SubeListesi
            // 
            this.gridControl_SubeListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_SubeListesi.Location = new System.Drawing.Point(2, 29);
            this.gridControl_SubeListesi.MainView = this.tileView_SubeListesi;
            this.gridControl_SubeListesi.Name = "gridControl_SubeListesi";
            this.gridControl_SubeListesi.Size = new System.Drawing.Size(348, 396);
            this.gridControl_SubeListesi.TabIndex = 0;
            this.gridControl_SubeListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView_SubeListesi});
            // 
            // tileView_SubeListesi
            // 
            this.tileView_SubeListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tileViewColumn_SubeAdi,
            this.tileViewColumn_SubeID,
            this.tileViewColumn_SubedekiElemanSayisi});
            this.tileView_SubeListesi.GridControl = this.gridControl_SubeListesi;
            this.tileView_SubeListesi.Name = "tileView_SubeListesi";
            this.tileView_SubeListesi.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView_SubeListesi.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView_SubeListesi.OptionsTiles.IndentBetweenItems = 0;
            this.tileView_SubeListesi.OptionsTiles.ItemSize = new System.Drawing.Size(246, 62);
            this.tileView_SubeListesi.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView_SubeListesi.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView_SubeListesi.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView_SubeListesi.OptionsTiles.RowCount = 0;
            tableColumnDefinition1.Length.Value = 140D;
            this.tileView_SubeListesi.TileColumns.Add(tableColumnDefinition1);
            tableRowDefinition1.Length.Value = 25D;
            tableRowDefinition2.Length.Value = 21D;
            this.tileView_SubeListesi.TileRows.Add(tableRowDefinition1);
            this.tileView_SubeListesi.TileRows.Add(tableRowDefinition2);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Column = this.tileViewColumn_SubeAdi;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "tileViewColumn_RolAdi";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Column = this.tileViewColumn_SubedekiElemanSayisi;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "tileViewColumn_KullaniciSayisi";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView_SubeListesi.TileTemplate.Add(tileViewItemElement1);
            this.tileView_SubeListesi.TileTemplate.Add(tileViewItemElement2);
            // 
            // tileViewColumn_SubeID
            // 
            this.tileViewColumn_SubeID.FieldName = "SubeID";
            this.tileViewColumn_SubeID.Name = "tileViewColumn_SubeID";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl_SubeListesi);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButton_Sil);
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButton_Kaydet);
            this.splitContainerControl1.Panel2.Controls.Add(this.label2);
            this.splitContainerControl1.Panel2.Controls.Add(this.memoEdit_Adres);
            this.splitContainerControl1.Panel2.Controls.Add(this.label3);
            this.splitContainerControl1.Panel2.Controls.Add(this.textEdit_TelefonNo);
            this.splitContainerControl1.Panel2.Controls.Add(this.label1);
            this.splitContainerControl1.Panel2.Controls.Add(this.textEdit_SubeAdi);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(758, 427);
            this.splitContainerControl1.SplitterPosition = 352;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefon No :";
            // 
            // textEdit_TelefonNo
            // 
            this.textEdit_TelefonNo.EnterMoveNextControl = true;
            this.textEdit_TelefonNo.Location = new System.Drawing.Point(77, 73);
            this.textEdit_TelefonNo.Name = "textEdit_TelefonNo";
            this.textEdit_TelefonNo.Size = new System.Drawing.Size(292, 28);
            this.textEdit_TelefonNo.TabIndex = 7;
            // 
            // memoEdit_Adres
            // 
            this.memoEdit_Adres.Location = new System.Drawing.Point(77, 121);
            this.memoEdit_Adres.Name = "memoEdit_Adres";
            this.memoEdit_Adres.Size = new System.Drawing.Size(292, 109);
            this.memoEdit_Adres.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Adres :";
            // 
            // simpleButton_Kaydet
            // 
            this.simpleButton_Kaydet.Location = new System.Drawing.Point(294, 248);
            this.simpleButton_Kaydet.Name = "simpleButton_Kaydet";
            this.simpleButton_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_Kaydet.TabIndex = 11;
            this.simpleButton_Kaydet.Text = "Kaydet";
            this.simpleButton_Kaydet.Click += new System.EventHandler(this.simpleButton_Kaydet_Click);
            // 
            // simpleButton_Sil
            // 
            this.simpleButton_Sil.Location = new System.Drawing.Point(213, 248);
            this.simpleButton_Sil.Name = "simpleButton_Sil";
            this.simpleButton_Sil.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_Sil.TabIndex = 12;
            this.simpleButton_Sil.Text = "Sil";
            // 
            // frmSubeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 427);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmSubeler";
            this.Text = "Şube İşlemleri";
            this.Load += new System.EventHandler(this.frmSubeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SubeAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_SubeListesi)).EndInit();
            this.groupControl_SubeListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SubeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView_SubeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            this.splitContainerControl1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TelefonNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_Adres.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit_SubeAdi;
        private DevExpress.XtraEditors.GroupControl groupControl_SubeListesi;
        private DevExpress.XtraGrid.GridControl gridControl_SubeListesi;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView_SubeListesi;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_SubeAdi;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_SubeID;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_SubedekiElemanSayisi;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEdit_TelefonNo;
        private DevExpress.XtraEditors.MemoEdit memoEdit_Adres;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Sil;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Kaydet;
        private System.Windows.Forms.Label label2;
    }
}