namespace BilgisayarSatisveTeknikServisOtomasyonu
{
    partial class frmBilgisayarEkle
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
            this.components = new System.ComponentModel.Container();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.tBLMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilgisayarDataSet = new BilgisayarSatisveTeknikServisOtomasyonu.BilgisayarDataSet();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.fKTBLModelTBLMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.txtImeiNo = new System.Windows.Forms.TextBox();
            this.dateUretim = new System.Windows.Forms.DateTimePicker();
            this.dateGelis = new System.Windows.Forms.DateTimePicker();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.txtSatisFİyati = new System.Windows.Forms.TextBox();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.txtIslemci = new System.Windows.Forms.TextBox();
            this.txtIsletimSistemi = new System.Windows.Forms.TextBox();
            this.txtHafiza = new System.Windows.Forms.TextBox();
            this.txtCozunurluk = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblSeriNo = new System.Windows.Forms.Label();
            this.lblGelisTarihi = new System.Windows.Forms.Label();
            this.lblUretimTarihi = new System.Windows.Forms.Label();
            this.lblImeiNo = new System.Windows.Forms.Label();
            this.lblKDV = new System.Windows.Forms.Label();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.lblAlisFiyati = new System.Windows.Forms.Label();
            this.lblHafiza = new System.Windows.Forms.Label();
            this.lblIsletimSistemi = new System.Windows.Forms.Label();
            this.lblİslemci = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblCozunurluk = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.tBLMarkaTableAdapter = new BilgisayarSatisveTeknikServisOtomasyonu.BilgisayarDataSetTableAdapters.TBLMarkaTableAdapter();
            this.tBLModelTableAdapter = new BilgisayarSatisveTeknikServisOtomasyonu.BilgisayarDataSetTableAdapters.TBLModelTableAdapter();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.lblMiktari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLModelTBLMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMarka
            // 
            this.comboMarka.DataSource = this.tBLMarkaBindingSource;
            this.comboMarka.DisplayMember = "Marka";
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(174, 36);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(121, 21);
            this.comboMarka.TabIndex = 0;
            // 
            // tBLMarkaBindingSource
            // 
            this.tBLMarkaBindingSource.DataMember = "TBLMarka";
            this.tBLMarkaBindingSource.DataSource = this.bilgisayarDataSet;
            // 
            // bilgisayarDataSet
            // 
            this.bilgisayarDataSet.DataSetName = "BilgisayarDataSet";
            this.bilgisayarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboModel
            // 
            this.comboModel.DataSource = this.fKTBLModelTBLMarkaBindingSource;
            this.comboModel.DisplayMember = "Model";
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(174, 63);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(121, 21);
            this.comboModel.TabIndex = 1;
            // 
            // fKTBLModelTBLMarkaBindingSource
            // 
            this.fKTBLModelTBLMarkaBindingSource.DataMember = "FK_TBLModel_TBLMarka";
            this.fKTBLModelTBLMarkaBindingSource.DataSource = this.tBLMarkaBindingSource;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(174, 91);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(121, 20);
            this.txtSeriNo.TabIndex = 2;
            // 
            // txtImeiNo
            // 
            this.txtImeiNo.Location = new System.Drawing.Point(174, 118);
            this.txtImeiNo.Name = "txtImeiNo";
            this.txtImeiNo.Size = new System.Drawing.Size(121, 20);
            this.txtImeiNo.TabIndex = 3;
            // 
            // dateUretim
            // 
            this.dateUretim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateUretim.Location = new System.Drawing.Point(174, 145);
            this.dateUretim.Name = "dateUretim";
            this.dateUretim.Size = new System.Drawing.Size(121, 20);
            this.dateUretim.TabIndex = 4;
            // 
            // dateGelis
            // 
            this.dateGelis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGelis.Location = new System.Drawing.Point(174, 172);
            this.dateGelis.Name = "dateGelis";
            this.dateGelis.Size = new System.Drawing.Size(121, 20);
            this.dateGelis.TabIndex = 5;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(174, 199);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(121, 20);
            this.txtAlisFiyati.TabIndex = 6;
            // 
            // txtSatisFİyati
            // 
            this.txtSatisFİyati.Location = new System.Drawing.Point(174, 225);
            this.txtSatisFİyati.Name = "txtSatisFİyati";
            this.txtSatisFİyati.Size = new System.Drawing.Size(121, 20);
            this.txtSatisFİyati.TabIndex = 7;
            // 
            // txtKDV
            // 
            this.txtKDV.Location = new System.Drawing.Point(174, 281);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(121, 20);
            this.txtKDV.TabIndex = 8;
            // 
            // txtIslemci
            // 
            this.txtIslemci.Location = new System.Drawing.Point(174, 307);
            this.txtIslemci.Name = "txtIslemci";
            this.txtIslemci.Size = new System.Drawing.Size(121, 20);
            this.txtIslemci.TabIndex = 9;
            // 
            // txtIsletimSistemi
            // 
            this.txtIsletimSistemi.Location = new System.Drawing.Point(174, 333);
            this.txtIsletimSistemi.Name = "txtIsletimSistemi";
            this.txtIsletimSistemi.Size = new System.Drawing.Size(121, 20);
            this.txtIsletimSistemi.TabIndex = 10;
            // 
            // txtHafiza
            // 
            this.txtHafiza.Location = new System.Drawing.Point(174, 359);
            this.txtHafiza.Name = "txtHafiza";
            this.txtHafiza.Size = new System.Drawing.Size(121, 20);
            this.txtHafiza.TabIndex = 11;
            // 
            // txtCozunurluk
            // 
            this.txtCozunurluk.Location = new System.Drawing.Point(174, 385);
            this.txtCozunurluk.Name = "txtCozunurluk";
            this.txtCozunurluk.Size = new System.Drawing.Size(121, 20);
            this.txtCozunurluk.TabIndex = 12;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(174, 411);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(121, 20);
            this.txtRenk.TabIndex = 13;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMarka.Location = new System.Drawing.Point(97, 43);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(37, 13);
            this.lblMarka.TabIndex = 15;
            this.lblMarka.Text = "Marka";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblModel.Location = new System.Drawing.Point(97, 69);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 16;
            this.lblModel.Text = "Model";
            // 
            // lblSeriNo
            // 
            this.lblSeriNo.AutoSize = true;
            this.lblSeriNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSeriNo.Location = new System.Drawing.Point(97, 95);
            this.lblSeriNo.Name = "lblSeriNo";
            this.lblSeriNo.Size = new System.Drawing.Size(42, 13);
            this.lblSeriNo.TabIndex = 17;
            this.lblSeriNo.Text = "Seri No";
            // 
            // lblGelisTarihi
            // 
            this.lblGelisTarihi.AutoSize = true;
            this.lblGelisTarihi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGelisTarihi.Location = new System.Drawing.Point(97, 173);
            this.lblGelisTarihi.Name = "lblGelisTarihi";
            this.lblGelisTarihi.Size = new System.Drawing.Size(59, 13);
            this.lblGelisTarihi.TabIndex = 20;
            this.lblGelisTarihi.Text = "Geliş Tarihi";
            // 
            // lblUretimTarihi
            // 
            this.lblUretimTarihi.AutoSize = true;
            this.lblUretimTarihi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUretimTarihi.Location = new System.Drawing.Point(97, 151);
            this.lblUretimTarihi.Name = "lblUretimTarihi";
            this.lblUretimTarihi.Size = new System.Drawing.Size(66, 13);
            this.lblUretimTarihi.TabIndex = 19;
            this.lblUretimTarihi.Text = "Üretim Tarihi";
            // 
            // lblImeiNo
            // 
            this.lblImeiNo.AutoSize = true;
            this.lblImeiNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblImeiNo.Location = new System.Drawing.Point(97, 121);
            this.lblImeiNo.Name = "lblImeiNo";
            this.lblImeiNo.Size = new System.Drawing.Size(43, 13);
            this.lblImeiNo.TabIndex = 18;
            this.lblImeiNo.Text = "Imei No";
            // 
            // lblKDV
            // 
            this.lblKDV.AutoSize = true;
            this.lblKDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKDV.Location = new System.Drawing.Point(97, 281);
            this.lblKDV.Name = "lblKDV";
            this.lblKDV.Size = new System.Drawing.Size(29, 13);
            this.lblKDV.TabIndex = 23;
            this.lblKDV.Text = "KDV";
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSatisFiyati.Location = new System.Drawing.Point(97, 225);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(57, 13);
            this.lblSatisFiyati.TabIndex = 22;
            this.lblSatisFiyati.Text = "Satış Fiyatı";
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.AutoSize = true;
            this.lblAlisFiyati.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAlisFiyati.Location = new System.Drawing.Point(97, 199);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(50, 13);
            this.lblAlisFiyati.TabIndex = 21;
            this.lblAlisFiyati.Text = "Alış Fiyati";
            // 
            // lblHafiza
            // 
            this.lblHafiza.AutoSize = true;
            this.lblHafiza.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHafiza.Location = new System.Drawing.Point(97, 359);
            this.lblHafiza.Name = "lblHafiza";
            this.lblHafiza.Size = new System.Drawing.Size(37, 13);
            this.lblHafiza.TabIndex = 26;
            this.lblHafiza.Text = "Hafıza";
            // 
            // lblIsletimSistemi
            // 
            this.lblIsletimSistemi.AutoSize = true;
            this.lblIsletimSistemi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIsletimSistemi.Location = new System.Drawing.Point(97, 333);
            this.lblIsletimSistemi.Name = "lblIsletimSistemi";
            this.lblIsletimSistemi.Size = new System.Drawing.Size(72, 13);
            this.lblIsletimSistemi.TabIndex = 25;
            this.lblIsletimSistemi.Text = "İşletim Sistemi";
            // 
            // lblİslemci
            // 
            this.lblİslemci.AutoSize = true;
            this.lblİslemci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblİslemci.Location = new System.Drawing.Point(97, 307);
            this.lblİslemci.Name = "lblİslemci";
            this.lblİslemci.Size = new System.Drawing.Size(39, 13);
            this.lblİslemci.TabIndex = 24;
            this.lblİslemci.Text = "İslemci";
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRenk.Location = new System.Drawing.Point(97, 411);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(33, 13);
            this.lblRenk.TabIndex = 28;
            this.lblRenk.Text = "Renk";
            // 
            // lblCozunurluk
            // 
            this.lblCozunurluk.AutoSize = true;
            this.lblCozunurluk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCozunurluk.Location = new System.Drawing.Point(97, 385);
            this.lblCozunurluk.Name = "lblCozunurluk";
            this.lblCozunurluk.Size = new System.Drawing.Size(60, 13);
            this.lblCozunurluk.TabIndex = 27;
            this.lblCozunurluk.Text = "Çözünürlük";
            // 
            // btnEkle
            // 
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEkle.Location = new System.Drawing.Point(147, 446);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 30;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIptal.Location = new System.Drawing.Point(238, 446);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 31;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(332, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResimSec.Location = new System.Drawing.Point(332, 188);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(137, 24);
            this.btnResimSec.TabIndex = 33;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // tBLMarkaTableAdapter
            // 
            this.tBLMarkaTableAdapter.ClearBeforeFill = true;
            // 
            // tBLModelTableAdapter
            // 
            this.tBLModelTableAdapter.ClearBeforeFill = true;
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(174, 252);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(121, 20);
            this.txtMiktari.TabIndex = 34;
            // 
            // lblMiktari
            // 
            this.lblMiktari.AutoSize = true;
            this.lblMiktari.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMiktari.Location = new System.Drawing.Point(97, 255);
            this.lblMiktari.Name = "lblMiktari";
            this.lblMiktari.Size = new System.Drawing.Size(38, 13);
            this.lblMiktari.TabIndex = 35;
            this.lblMiktari.Text = "Miktarı";
            // 
            // frmBilgisayarEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(526, 494);
            this.Controls.Add(this.lblMiktari);
            this.Controls.Add(this.txtMiktari);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.lblCozunurluk);
            this.Controls.Add(this.lblHafiza);
            this.Controls.Add(this.lblIsletimSistemi);
            this.Controls.Add(this.lblİslemci);
            this.Controls.Add(this.lblKDV);
            this.Controls.Add(this.lblSatisFiyati);
            this.Controls.Add(this.lblAlisFiyati);
            this.Controls.Add(this.lblGelisTarihi);
            this.Controls.Add(this.lblUretimTarihi);
            this.Controls.Add(this.lblImeiNo);
            this.Controls.Add(this.lblSeriNo);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.txtCozunurluk);
            this.Controls.Add(this.txtHafiza);
            this.Controls.Add(this.txtIsletimSistemi);
            this.Controls.Add(this.txtIslemci);
            this.Controls.Add(this.txtKDV);
            this.Controls.Add(this.txtSatisFİyati);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.dateGelis);
            this.Controls.Add(this.dateUretim);
            this.Controls.Add(this.txtImeiNo);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.comboModel);
            this.Controls.Add(this.comboMarka);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "frmBilgisayarEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgisayar Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmBilgisayarEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLModelTBLMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.TextBox txtImeiNo;
        private System.Windows.Forms.DateTimePicker dateUretim;
        private System.Windows.Forms.DateTimePicker dateGelis;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.TextBox txtSatisFİyati;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.TextBox txtIslemci;
        private System.Windows.Forms.TextBox txtIsletimSistemi;
        private System.Windows.Forms.TextBox txtHafiza;
        private System.Windows.Forms.TextBox txtCozunurluk;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblSeriNo;
        private System.Windows.Forms.Label lblGelisTarihi;
        private System.Windows.Forms.Label lblUretimTarihi;
        private System.Windows.Forms.Label lblImeiNo;
        private System.Windows.Forms.Label lblKDV;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.Label lblHafiza;
        private System.Windows.Forms.Label lblIsletimSistemi;
        private System.Windows.Forms.Label lblİslemci;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblCozunurluk;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResimSec;
        private BilgisayarDataSet bilgisayarDataSet;
        private System.Windows.Forms.BindingSource tBLMarkaBindingSource;
        private BilgisayarDataSetTableAdapters.TBLMarkaTableAdapter tBLMarkaTableAdapter;
        private System.Windows.Forms.BindingSource fKTBLModelTBLMarkaBindingSource;
        private BilgisayarDataSetTableAdapters.TBLModelTableAdapter tBLModelTableAdapter;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.Label lblMiktari;
    }
}