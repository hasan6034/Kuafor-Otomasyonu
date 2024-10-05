namespace Kuafor_Otomasyonu
{
    partial class FrmKullaniciIslemleri
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
            this.tileViewColumn_AdSoyad = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_RolAdi = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_KullaniciListesi = new DevExpress.XtraGrid.GridControl();
            this.tileView_KullaniciListesi = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.tileViewColumn_KulID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_KulAdi = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_RolID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_Adi = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_Soyadi = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_KulSifre = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_DurumID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.simpleButton_KulSil = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_Sifre = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_KullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lookUpEdit_Durum = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit_Rol = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit_Adi = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Soyadi = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_KullaniciListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView_KullaniciListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Sifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_KullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Durum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Rol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Soyadi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tileViewColumn_AdSoyad
            // 
            this.tileViewColumn_AdSoyad.Caption = "Adı Soyadı";
            this.tileViewColumn_AdSoyad.FieldName = "AdSoyad";
            this.tileViewColumn_AdSoyad.Name = "tileViewColumn_AdSoyad";
            this.tileViewColumn_AdSoyad.Visible = true;
            this.tileViewColumn_AdSoyad.VisibleIndex = 0;
            // 
            // tileViewColumn_RolAdi
            // 
            this.tileViewColumn_RolAdi.Caption = "Rol Adı";
            this.tileViewColumn_RolAdi.FieldName = "RolAdi";
            this.tileViewColumn_RolAdi.Name = "tileViewColumn_RolAdi";
            this.tileViewColumn_RolAdi.Visible = true;
            this.tileViewColumn_RolAdi.VisibleIndex = 5;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButton_KulSil);
            this.splitContainerControl1.Panel2.Controls.Add(this.textEdit_Sifre);
            this.splitContainerControl1.Panel2.Controls.Add(this.textEdit_KullaniciAdi);
            this.splitContainerControl1.Panel2.Controls.Add(this.label7);
            this.splitContainerControl1.Panel2.Controls.Add(this.label6);
            this.splitContainerControl1.Panel2.Controls.Add(this.lookUpEdit_Durum);
            this.splitContainerControl1.Panel2.Controls.Add(this.lookUpEdit_Rol);
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButton_Kaydet);
            this.splitContainerControl1.Panel2.Controls.Add(this.label5);
            this.splitContainerControl1.Panel2.Controls.Add(this.label4);
            this.splitContainerControl1.Panel2.Controls.Add(this.label2);
            this.splitContainerControl1.Panel2.Controls.Add(this.label1);
            this.splitContainerControl1.Panel2.Controls.Add(this.textEdit_Adi);
            this.splitContainerControl1.Panel2.Controls.Add(this.textEdit_Soyadi);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(985, 430);
            this.splitContainerControl1.SplitterPosition = 353;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl_KullaniciListesi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(353, 430);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Personel Listesi";
            // 
            // gridControl_KullaniciListesi
            // 
            this.gridControl_KullaniciListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_KullaniciListesi.Location = new System.Drawing.Point(2, 29);
            this.gridControl_KullaniciListesi.MainView = this.tileView_KullaniciListesi;
            this.gridControl_KullaniciListesi.Name = "gridControl_KullaniciListesi";
            this.gridControl_KullaniciListesi.Size = new System.Drawing.Size(349, 399);
            this.gridControl_KullaniciListesi.TabIndex = 0;
            this.gridControl_KullaniciListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView_KullaniciListesi});
            // 
            // tileView_KullaniciListesi
            // 
            this.tileView_KullaniciListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tileViewColumn_KulID,
            this.tileViewColumn_KulAdi,
            this.tileViewColumn_RolID,
            this.tileViewColumn_RolAdi,
            this.tileViewColumn_Adi,
            this.tileViewColumn_Soyadi,
            this.tileViewColumn_AdSoyad,
            this.tileViewColumn_KulSifre,
            this.tileViewColumn_DurumID});
            this.tileView_KullaniciListesi.GridControl = this.gridControl_KullaniciListesi;
            this.tileView_KullaniciListesi.Name = "tileView_KullaniciListesi";
            this.tileView_KullaniciListesi.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView_KullaniciListesi.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView_KullaniciListesi.OptionsTiles.IndentBetweenItems = 0;
            this.tileView_KullaniciListesi.OptionsTiles.ItemSize = new System.Drawing.Size(248, 73);
            this.tileView_KullaniciListesi.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView_KullaniciListesi.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView_KullaniciListesi.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView_KullaniciListesi.OptionsTiles.RowCount = 0;
            this.tileView_KullaniciListesi.TileColumns.Add(tableColumnDefinition1);
            tableRowDefinition1.Length.Value = 21D;
            tableRowDefinition2.Length.Value = 18D;
            this.tileView_KullaniciListesi.TileRows.Add(tableRowDefinition1);
            this.tileView_KullaniciListesi.TileRows.Add(tableRowDefinition2);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Column = this.tileViewColumn_AdSoyad;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "tileViewColumn_AdSoyad";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Column = this.tileViewColumn_RolAdi;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "tileViewColumn_RolAdi";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView_KullaniciListesi.TileTemplate.Add(tileViewItemElement1);
            this.tileView_KullaniciListesi.TileTemplate.Add(tileViewItemElement2);
            this.tileView_KullaniciListesi.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.TileView_KullaniciListesi_FocusedRowChanged);
            // 
            // tileViewColumn_KulID
            // 
            this.tileViewColumn_KulID.Caption = "KulID";
            this.tileViewColumn_KulID.FieldName = "KulID";
            this.tileViewColumn_KulID.Name = "tileViewColumn_KulID";
            // 
            // tileViewColumn_KulAdi
            // 
            this.tileViewColumn_KulAdi.Caption = "KulAdi";
            this.tileViewColumn_KulAdi.FieldName = "KulAdi";
            this.tileViewColumn_KulAdi.Name = "tileViewColumn_KulAdi";
            this.tileViewColumn_KulAdi.Visible = true;
            this.tileViewColumn_KulAdi.VisibleIndex = 1;
            // 
            // tileViewColumn_RolID
            // 
            this.tileViewColumn_RolID.Caption = "RolID";
            this.tileViewColumn_RolID.FieldName = "RolID";
            this.tileViewColumn_RolID.Name = "tileViewColumn_RolID";
            this.tileViewColumn_RolID.Visible = true;
            this.tileViewColumn_RolID.VisibleIndex = 2;
            // 
            // tileViewColumn_Adi
            // 
            this.tileViewColumn_Adi.Caption = "Adi";
            this.tileViewColumn_Adi.FieldName = "Adi";
            this.tileViewColumn_Adi.Name = "tileViewColumn_Adi";
            this.tileViewColumn_Adi.Visible = true;
            this.tileViewColumn_Adi.VisibleIndex = 3;
            // 
            // tileViewColumn_Soyadi
            // 
            this.tileViewColumn_Soyadi.Caption = "Soyadi";
            this.tileViewColumn_Soyadi.FieldName = "Soyadi";
            this.tileViewColumn_Soyadi.Name = "tileViewColumn_Soyadi";
            this.tileViewColumn_Soyadi.Visible = true;
            this.tileViewColumn_Soyadi.VisibleIndex = 4;
            // 
            // tileViewColumn_KulSifre
            // 
            this.tileViewColumn_KulSifre.Caption = "KulSifre";
            this.tileViewColumn_KulSifre.FieldName = "KulSifre";
            this.tileViewColumn_KulSifre.Name = "tileViewColumn_KulSifre";
            this.tileViewColumn_KulSifre.Visible = true;
            this.tileViewColumn_KulSifre.VisibleIndex = 6;
            // 
            // tileViewColumn_DurumID
            // 
            this.tileViewColumn_DurumID.Caption = "DurumID";
            this.tileViewColumn_DurumID.FieldName = "DurumID";
            this.tileViewColumn_DurumID.Name = "tileViewColumn_DurumID";
            this.tileViewColumn_DurumID.Visible = true;
            this.tileViewColumn_DurumID.VisibleIndex = 7;
            // 
            // simpleButton_KulSil
            // 
            this.simpleButton_KulSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton_KulSil.Appearance.Options.UseFont = true;
            this.simpleButton_KulSil.Location = new System.Drawing.Point(390, 140);
            this.simpleButton_KulSil.Name = "simpleButton_KulSil";
            this.simpleButton_KulSil.Size = new System.Drawing.Size(156, 24);
            this.simpleButton_KulSil.TabIndex = 8;
            this.simpleButton_KulSil.Text = "Sil";
            this.simpleButton_KulSil.Click += new System.EventHandler(this.SimpleButton_KulSil_Click);
            // 
            // textEdit_Sifre
            // 
            this.textEdit_Sifre.EnterMoveNextControl = true;
            this.textEdit_Sifre.Location = new System.Drawing.Point(390, 100);
            this.textEdit_Sifre.Name = "textEdit_Sifre";
            this.textEdit_Sifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textEdit_Sifre.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Sifre.Size = new System.Drawing.Size(156, 34);
            this.textEdit_Sifre.TabIndex = 6;
            // 
            // textEdit_KullaniciAdi
            // 
            this.textEdit_KullaniciAdi.EnterMoveNextControl = true;
            this.textEdit_KullaniciAdi.Location = new System.Drawing.Point(142, 100);
            this.textEdit_KullaniciAdi.Name = "textEdit_KullaniciAdi";
            this.textEdit_KullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textEdit_KullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.textEdit_KullaniciAdi.Size = new System.Drawing.Size(156, 34);
            this.textEdit_KullaniciAdi.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(343, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(7, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // lookUpEdit_Durum
            // 
            this.lookUpEdit_Durum.EnterMoveNextControl = true;
            this.lookUpEdit_Durum.Location = new System.Drawing.Point(390, 60);
            this.lookUpEdit_Durum.Name = "lookUpEdit_Durum";
            this.lookUpEdit_Durum.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lookUpEdit_Durum.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_Durum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_Durum.Size = new System.Drawing.Size(156, 34);
            this.lookUpEdit_Durum.TabIndex = 4;
            // 
            // lookUpEdit_Rol
            // 
            this.lookUpEdit_Rol.EnterMoveNextControl = true;
            this.lookUpEdit_Rol.Location = new System.Drawing.Point(142, 60);
            this.lookUpEdit_Rol.Name = "lookUpEdit_Rol";
            this.lookUpEdit_Rol.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lookUpEdit_Rol.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_Rol.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_Rol.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RolID", "RolID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RolAdi", "Rol Adı")});
            this.lookUpEdit_Rol.Size = new System.Drawing.Size(156, 34);
            this.lookUpEdit_Rol.TabIndex = 3;
            // 
            // simpleButton_Kaydet
            // 
            this.simpleButton_Kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.simpleButton_Kaydet.Appearance.Options.UseFont = true;
            this.simpleButton_Kaydet.Location = new System.Drawing.Point(142, 140);
            this.simpleButton_Kaydet.Name = "simpleButton_Kaydet";
            this.simpleButton_Kaydet.Size = new System.Drawing.Size(156, 23);
            this.simpleButton_Kaydet.TabIndex = 7;
            this.simpleButton_Kaydet.Text = "Kaydet";
            this.simpleButton_Kaydet.Click += new System.EventHandler(this.SimpleButton_Kaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(317, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Durumu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rolü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(317, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Adı ";
            // 
            // textEdit_Adi
            // 
            this.textEdit_Adi.EnterMoveNextControl = true;
            this.textEdit_Adi.Location = new System.Drawing.Point(142, 20);
            this.textEdit_Adi.Name = "textEdit_Adi";
            this.textEdit_Adi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textEdit_Adi.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Adi.Size = new System.Drawing.Size(156, 34);
            this.textEdit_Adi.TabIndex = 1;
            // 
            // textEdit_Soyadi
            // 
            this.textEdit_Soyadi.EnterMoveNextControl = true;
            this.textEdit_Soyadi.Location = new System.Drawing.Point(390, 17);
            this.textEdit_Soyadi.Name = "textEdit_Soyadi";
            this.textEdit_Soyadi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textEdit_Soyadi.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Soyadi.Size = new System.Drawing.Size(156, 34);
            this.textEdit_Soyadi.TabIndex = 2;
            // 
            // FrmKullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 430);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmKullaniciIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.FrmKullaniciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            this.splitContainerControl1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_KullaniciListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView_KullaniciListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Sifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_KullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Durum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Rol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Soyadi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_Adi;
        private DevExpress.XtraEditors.TextEdit textEdit_Soyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Kaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gridControl_KullaniciListesi;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView_KullaniciListesi;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_KulID;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_AdSoyad;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_RolAdi;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_KulAdi;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_RolID;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_Adi;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_Soyadi;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_KulSifre;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_DurumID;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_Durum;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_Rol;
        private DevExpress.XtraEditors.TextEdit textEdit_Sifre;
        private DevExpress.XtraEditors.TextEdit textEdit_KullaniciAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton simpleButton_KulSil;
    }
}