namespace Kuafor_Otomasyonu
{
    partial class FrmHizmetIslemleri
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
            this.tileViewColumn_HizmetAdi = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_HizmetFiyati = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl_Hizmetler = new DevExpress.XtraGrid.GridControl();
            this.tileView_Hizmetler = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.tileViewColumn_HizmetID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.textEdit_HizmetAdi = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_HizmetFiyati = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_Kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Hizmetler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView_Hizmetler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HizmetAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HizmetFiyati.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tileViewColumn_HizmetAdi
            // 
            this.tileViewColumn_HizmetAdi.Caption = "Hizmet Adı";
            this.tileViewColumn_HizmetAdi.FieldName = "HizmetAdi";
            this.tileViewColumn_HizmetAdi.MinWidth = 25;
            this.tileViewColumn_HizmetAdi.Name = "tileViewColumn_HizmetAdi";
            this.tileViewColumn_HizmetAdi.Visible = true;
            this.tileViewColumn_HizmetAdi.VisibleIndex = 1;
            this.tileViewColumn_HizmetAdi.Width = 94;
            // 
            // tileViewColumn_HizmetFiyati
            // 
            this.tileViewColumn_HizmetFiyati.Caption = "Hizmet Fiyatı";
            this.tileViewColumn_HizmetFiyati.FieldName = "HizmetFiyati";
            this.tileViewColumn_HizmetFiyati.MinWidth = 25;
            this.tileViewColumn_HizmetFiyati.Name = "tileViewColumn_HizmetFiyati";
            this.tileViewColumn_HizmetFiyati.Visible = true;
            this.tileViewColumn_HizmetFiyati.VisibleIndex = 2;
            this.tileViewColumn_HizmetFiyati.Width = 94;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl_Hizmetler);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButtonSil);
            this.splitContainerControl1.Panel2.Controls.Add(this.simpleButton_Kaydet);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.textEdit_HizmetAdi);
            this.splitContainerControl1.Panel2.Controls.Add(this.textEdit_HizmetFiyati);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(794, 448);
            this.splitContainerControl1.SplitterPosition = 304;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // gridControl_Hizmetler
            // 
            this.gridControl_Hizmetler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Hizmetler.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Hizmetler.MainView = this.tileView_Hizmetler;
            this.gridControl_Hizmetler.Name = "gridControl_Hizmetler";
            this.gridControl_Hizmetler.Size = new System.Drawing.Size(304, 448);
            this.gridControl_Hizmetler.TabIndex = 0;
            this.gridControl_Hizmetler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView_Hizmetler});
            // 
            // tileView_Hizmetler
            // 
            this.tileView_Hizmetler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tileViewColumn_HizmetID,
            this.tileViewColumn_HizmetAdi,
            this.tileViewColumn_HizmetFiyati});
            this.tileView_Hizmetler.GridControl = this.gridControl_Hizmetler;
            this.tileView_Hizmetler.Name = "tileView_Hizmetler";
            this.tileView_Hizmetler.OptionsTiles.GroupTextPadding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.tileView_Hizmetler.OptionsTiles.IndentBetweenGroups = 0;
            this.tileView_Hizmetler.OptionsTiles.IndentBetweenItems = 0;
            this.tileView_Hizmetler.OptionsTiles.ItemSize = new System.Drawing.Size(248, 76);
            this.tileView_Hizmetler.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.tileView_Hizmetler.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView_Hizmetler.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.tileView_Hizmetler.OptionsTiles.RowCount = 0;
            this.tileView_Hizmetler.TileColumns.Add(tableColumnDefinition1);
            this.tileView_Hizmetler.TileRows.Add(tableRowDefinition1);
            this.tileView_Hizmetler.TileRows.Add(tableRowDefinition2);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Column = this.tileViewColumn_HizmetAdi;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "tileViewColumn_HizmetAdi";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Column = this.tileViewColumn_HizmetFiyati;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "tileViewColumn_HizmetFiyati";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView_Hizmetler.TileTemplate.Add(tileViewItemElement1);
            this.tileView_Hizmetler.TileTemplate.Add(tileViewItemElement2);
            // 
            // tileViewColumn_HizmetID
            // 
            this.tileViewColumn_HizmetID.Caption = "tileViewColumn1";
            this.tileViewColumn_HizmetID.FieldName = "HizmetID";
            this.tileViewColumn_HizmetID.MinWidth = 25;
            this.tileViewColumn_HizmetID.Name = "tileViewColumn_HizmetID";
            this.tileViewColumn_HizmetID.Visible = true;
            this.tileViewColumn_HizmetID.VisibleIndex = 0;
            this.tileViewColumn_HizmetID.Width = 94;
            // 
            // textEdit_HizmetAdi
            // 
            this.textEdit_HizmetAdi.Location = new System.Drawing.Point(141, 141);
            this.textEdit_HizmetAdi.Name = "textEdit_HizmetAdi";
            this.textEdit_HizmetAdi.Size = new System.Drawing.Size(242, 34);
            this.textEdit_HizmetAdi.TabIndex = 1;
            // 
            // textEdit_HizmetFiyati
            // 
            this.textEdit_HizmetFiyati.Location = new System.Drawing.Point(141, 230);
            this.textEdit_HizmetFiyati.Name = "textEdit_HizmetFiyati";
            this.textEdit_HizmetFiyati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit_HizmetFiyati.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEdit_HizmetFiyati.Size = new System.Drawing.Size(243, 34);
            this.textEdit_HizmetFiyati.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(48, 239);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Hizmet Fiyatı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(60, 150);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Hizmet Adı:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // simpleButton_Kaydet
            // 
            this.simpleButton_Kaydet.Location = new System.Drawing.Point(289, 326);
            this.simpleButton_Kaydet.Name = "simpleButton_Kaydet";
            this.simpleButton_Kaydet.Size = new System.Drawing.Size(94, 29);
            this.simpleButton_Kaydet.TabIndex = 5;
            this.simpleButton_Kaydet.Text = "Kaydet";
            this.simpleButton_Kaydet.Click += new System.EventHandler(this.simpleButton_Kaydet_Click);
            // 
            // simpleButtonSil
            // 
            this.simpleButtonSil.Location = new System.Drawing.Point(141, 326);
            this.simpleButtonSil.Name = "simpleButtonSil";
            this.simpleButtonSil.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonSil.TabIndex = 6;
            this.simpleButtonSil.Text = "Sil";
            this.simpleButtonSil.Click += new System.EventHandler(this.simpleButtonSil_Click);
            // 
            // FrmHizmetIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 448);
            this.Controls.Add(this.splitContainerControl1);
            this.IconOptions.Image = global::Kuafor_Otomasyonu.Properties.Resources.Kuafor;
            this.Name = "FrmHizmetIslemleri";
            this.Text = "Hizmet İşlemleri";
            this.Load += new System.EventHandler(this.FrmHizmetIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            this.splitContainerControl1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Hizmetler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView_Hizmetler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HizmetAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HizmetFiyati.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl_Hizmetler;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView_Hizmetler;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_HizmetID;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_HizmetAdi;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_HizmetFiyati;
        private DevExpress.XtraEditors.TextEdit textEdit_HizmetAdi;
        private DevExpress.XtraEditors.SpinEdit textEdit_HizmetFiyati;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSil;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}