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
            this.btnHizmetEkle = new System.Windows.Forms.Button();
            this.btnHizmetSil = new System.Windows.Forms.Button();
            this.textEdit_HizmetAdi = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewHizmetler = new System.Windows.Forms.ListView();
            this.groupControl_HizmetListesi = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_HizmetListesi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HizmetAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_HizmetListesi)).BeginInit();
            this.groupControl_HizmetListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_HizmetListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHizmetEkle
            // 
            this.btnHizmetEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHizmetEkle.Location = new System.Drawing.Point(982, 431);
            this.btnHizmetEkle.Name = "btnHizmetEkle";
            this.btnHizmetEkle.Size = new System.Drawing.Size(110, 45);
            this.btnHizmetEkle.TabIndex = 0;
            this.btnHizmetEkle.Text = "Ekle";
            this.btnHizmetEkle.UseVisualStyleBackColor = true;
            // 
            // btnHizmetSil
            // 
            this.btnHizmetSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHizmetSil.Location = new System.Drawing.Point(812, 431);
            this.btnHizmetSil.Name = "btnHizmetSil";
            this.btnHizmetSil.Size = new System.Drawing.Size(116, 45);
            this.btnHizmetSil.TabIndex = 1;
            this.btnHizmetSil.Text = "Sil";
            this.btnHizmetSil.UseVisualStyleBackColor = true;
            // 
            // textEdit_HizmetAdi
            // 
            this.textEdit_HizmetAdi.Location = new System.Drawing.Point(812, 55);
            this.textEdit_HizmetAdi.Name = "textEdit_HizmetAdi";
            this.textEdit_HizmetAdi.Size = new System.Drawing.Size(280, 34);
            this.textEdit_HizmetAdi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(708, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hizmet Adı :";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(812, 106);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(280, 34);
            this.textEdit1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(690, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hizmet Ücreti :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(637, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mevcut Hizmetlerimiz :";
            // 
            // listViewHizmetler
            // 
            this.listViewHizmetler.HideSelection = false;
            this.listViewHizmetler.Location = new System.Drawing.Point(812, 163);
            this.listViewHizmetler.Name = "listViewHizmetler";
            this.listViewHizmetler.Size = new System.Drawing.Size(280, 262);
            this.listViewHizmetler.TabIndex = 7;
            this.listViewHizmetler.UseCompatibleStateImageBehavior = false;
            // 
            // groupControl_HizmetListesi
            // 
            this.groupControl_HizmetListesi.Controls.Add(this.gridControl_HizmetListesi);
            this.groupControl_HizmetListesi.Location = new System.Drawing.Point(0, 0);
            this.groupControl_HizmetListesi.Name = "groupControl_HizmetListesi";
            this.groupControl_HizmetListesi.Size = new System.Drawing.Size(407, 524);
            this.groupControl_HizmetListesi.TabIndex = 8;
            this.groupControl_HizmetListesi.Text = "Hizmet Listesi";
            // 
            // gridControl_HizmetListesi
            // 
            this.gridControl_HizmetListesi.Location = new System.Drawing.Point(0, 33);
            this.gridControl_HizmetListesi.MainView = this.gridView1;
            this.gridControl_HizmetListesi.Name = "gridControl_HizmetListesi";
            this.gridControl_HizmetListesi.Size = new System.Drawing.Size(407, 491);
            this.gridControl_HizmetListesi.TabIndex = 0;
            this.gridControl_HizmetListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_HizmetListesi;
            this.gridView1.Name = "gridView1";
            // 
            // FrmHizmetIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 524);
            this.Controls.Add(this.groupControl_HizmetListesi);
            this.Controls.Add(this.listViewHizmetler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEdit_HizmetAdi);
            this.Controls.Add(this.btnHizmetSil);
            this.Controls.Add(this.btnHizmetEkle);
            this.Name = "FrmHizmetIslemleri";
            this.Text = "Hizmet İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HizmetAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_HizmetListesi)).EndInit();
            this.groupControl_HizmetListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_HizmetListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHizmetEkle;
        private System.Windows.Forms.Button btnHizmetSil;
        private DevExpress.XtraEditors.TextEdit textEdit_HizmetAdi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewHizmetler;
        private DevExpress.XtraEditors.GroupControl groupControl_HizmetListesi;
        private DevExpress.XtraGrid.GridControl gridControl_HizmetListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}