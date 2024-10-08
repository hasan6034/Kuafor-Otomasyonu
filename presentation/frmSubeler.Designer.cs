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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit_RolAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl_RolListesi = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_SubeListesi = new DevExpress.XtraGrid.GridControl();
            this.tileView_SubeListesi = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.tileViewColumn_SubeAdi = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_SubeID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn_SubedekiElemanSayisi = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.label3 = new System.Windows.Forms.Label();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_RolAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_RolListesi)).BeginInit();
            this.groupControl_RolListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SubeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView_SubeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şube Adı :";
            // 
            // textEdit_RolAdi
            // 
            this.textEdit_RolAdi.EnterMoveNextControl = true;
            this.textEdit_RolAdi.Location = new System.Drawing.Point(77, 21);
            this.textEdit_RolAdi.Name = "textEdit_RolAdi";
            this.textEdit_RolAdi.Size = new System.Drawing.Size(193, 28);
            this.textEdit_RolAdi.TabIndex = 0;
            // 
            // groupControl_RolListesi
            // 
            this.groupControl_RolListesi.Controls.Add(this.gridControl_SubeListesi);
            this.groupControl_RolListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_RolListesi.Location = new System.Drawing.Point(0, 0);
            this.groupControl_RolListesi.Name = "groupControl_RolListesi";
            this.groupControl_RolListesi.Size = new System.Drawing.Size(326, 427);
            this.groupControl_RolListesi.TabIndex = 0;
            this.groupControl_RolListesi.Text = "Rol Listesi";
            // 
            // gridControl_SubeListesi
            // 
            this.gridControl_SubeListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_SubeListesi.Location = new System.Drawing.Point(2, 29);
            this.gridControl_SubeListesi.MainView = this.tileView_SubeListesi;
            this.gridControl_SubeListesi.Name = "gridControl_SubeListesi";
            this.gridControl_SubeListesi.Size = new System.Drawing.Size(322, 396);
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
            tableColumnDefinition2.Length.Value = 140D;
            this.tileView_SubeListesi.TileColumns.Add(tableColumnDefinition2);
            tableRowDefinition3.Length.Value = 25D;
            tableRowDefinition4.Length.Value = 21D;
            this.tileView_SubeListesi.TileRows.Add(tableRowDefinition3);
            this.tileView_SubeListesi.TileRows.Add(tableRowDefinition4);
            tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement3.Column = this.tileViewColumn_SubeAdi;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.Text = "tileViewColumn_RolAdi";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F);
            tileViewItemElement4.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement4.Column = this.tileViewColumn_SubedekiElemanSayisi;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.RowIndex = 1;
            tileViewItemElement4.Text = "tileViewColumn_KullaniciSayisi";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView_SubeListesi.TileTemplate.Add(tileViewItemElement3);
            this.tileView_SubeListesi.TileTemplate.Add(tileViewItemElement4);
            // 
            // tileViewColumn_SubeAdi
            // 
            this.tileViewColumn_SubeAdi.FieldName = "SubeAdi";
            this.tileViewColumn_SubeAdi.Name = "tileViewColumn_SubeAdi";
            this.tileViewColumn_SubeAdi.Visible = true;
            this.tileViewColumn_SubeAdi.VisibleIndex = 0;
            // 
            // tileViewColumn_SubeID
            // 
            this.tileViewColumn_SubeID.FieldName = "SubeID";
            this.tileViewColumn_SubeID.Name = "tileViewColumn_SubeID";
            // 
            // tileViewColumn_SubedekiElemanSayisi
            // 
            this.tileViewColumn_SubedekiElemanSayisi.Caption = "Eleman Sayısı";
            this.tileViewColumn_SubedekiElemanSayisi.FieldName = "ElemanSayisi";
            this.tileViewColumn_SubedekiElemanSayisi.Name = "tileViewColumn_SubedekiElemanSayisi";
            this.tileViewColumn_SubedekiElemanSayisi.Visible = true;
            this.tileViewColumn_SubedekiElemanSayisi.VisibleIndex = 1;
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
            this.splitContainerControl1.Panel2.Controls.Add(this.label3);
            this.splitContainerControl1.Panel2.Controls.Add(this.textEdit2);
            this.splitContainerControl1.Panel2.Controls.Add(this.label1);
            this.splitContainerControl1.Panel2.Controls.Add(this.textEdit_RolAdi);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(934, 427);
            this.splitContainerControl1.SplitterPosition = 326;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefon No :";
            // 
            // textEdit2
            // 
            this.textEdit2.EnterMoveNextControl = true;
            this.textEdit2.Location = new System.Drawing.Point(77, 73);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(193, 28);
            this.textEdit2.TabIndex = 7;
            // 
            // frmSubeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 427);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmSubeler";
            this.Text = "frmSubeler";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_RolAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_RolListesi)).EndInit();
            this.groupControl_RolListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SubeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView_SubeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            this.splitContainerControl1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit_RolAdi;
        private DevExpress.XtraEditors.GroupControl groupControl_RolListesi;
        private DevExpress.XtraGrid.GridControl gridControl_SubeListesi;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView_SubeListesi;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_SubeAdi;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_SubeID;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn_SubedekiElemanSayisi;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
    }
}