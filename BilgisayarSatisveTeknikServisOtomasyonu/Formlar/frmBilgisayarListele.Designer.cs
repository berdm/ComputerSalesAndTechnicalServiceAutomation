namespace BilgisayarSatisveTeknikServisOtomasyonu.Formlar
{
    partial class frmBilgisayarListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bilgisayarDataSet = new BilgisayarSatisveTeknikServisOtomasyonu.BilgisayarDataSet();
            this.bilgisayarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilgisayarDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblToplamKayitSayisi = new System.Windows.Forms.Label();
            this.btnMarkaModelGuncelle = new System.Windows.Forms.Button();
            this.lblYeniModel = new System.Windows.Forms.Label();
            this.lblYeniMarka = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtSeriNoImei = new System.Windows.Forms.TextBox();
            this.lblBilgisayarAra = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblCozunurluk = new System.Windows.Forms.Label();
            this.lblHafiza = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtCozunurluk = new System.Windows.Forms.TextBox();
            this.txtHafiza = new System.Windows.Forms.TextBox();
            this.lblMiktari = new System.Windows.Forms.Label();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.lblIsletimSistemi = new System.Windows.Forms.Label();
            this.lblİslemci = new System.Windows.Forms.Label();
            this.lblKDV = new System.Windows.Forms.Label();
            this.txtIsletimSistemi = new System.Windows.Forms.TextBox();
            this.txtIslemci = new System.Windows.Forms.TextBox();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.lblAlisFiyati = new System.Windows.Forms.Label();
            this.lblGelisTarihi = new System.Windows.Forms.Label();
            this.lblUretimTarihi = new System.Windows.Forms.Label();
            this.txtSatisFİyati = new System.Windows.Forms.TextBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.dateGelis = new System.Windows.Forms.DateTimePicker();
            this.dateUretim = new System.Windows.Forms.DateTimePicker();
            this.lblImeiNo = new System.Windows.Forms.Label();
            this.lblSeriNo = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtImeiNo = new System.Windows.Forms.TextBox();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.fKTBLModelTBLMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.tBLMarkaTableAdapter = new BilgisayarSatisveTeknikServisOtomasyonu.BilgisayarDataSetTableAdapters.TBLMarkaTableAdapter();
            this.tBLModelTableAdapter = new BilgisayarSatisveTeknikServisOtomasyonu.BilgisayarDataSetTableAdapters.TBLModelTableAdapter();
            this.lblToplamMaliyet = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblBilgMarkaAra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayarDataSetBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLModelTBLMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(934, 541);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // bilgisayarDataSet
            // 
            this.bilgisayarDataSet.DataSetName = "BilgisayarDataSet";
            this.bilgisayarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilgisayarDataSetBindingSource
            // 
            this.bilgisayarDataSetBindingSource.DataSource = this.bilgisayarDataSet;
            this.bilgisayarDataSetBindingSource.Position = 0;
            // 
            // bilgisayarDataSetBindingSource1
            // 
            this.bilgisayarDataSetBindingSource1.DataSource = this.bilgisayarDataSet;
            this.bilgisayarDataSetBindingSource1.Position = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblBilgMarkaAra);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblToplamMaliyet);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.btnResimSec);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblToplamKayitSayisi);
            this.panel1.Controls.Add(this.btnMarkaModelGuncelle);
            this.panel1.Controls.Add(this.lblYeniModel);
            this.panel1.Controls.Add(this.lblYeniMarka);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.txtSeriNoImei);
            this.panel1.Controls.Add(this.lblBilgisayarAra);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.lblRenk);
            this.panel1.Controls.Add(this.lblCozunurluk);
            this.panel1.Controls.Add(this.lblHafiza);
            this.panel1.Controls.Add(this.txtRenk);
            this.panel1.Controls.Add(this.txtCozunurluk);
            this.panel1.Controls.Add(this.txtHafiza);
            this.panel1.Controls.Add(this.lblMiktari);
            this.panel1.Controls.Add(this.txtMiktari);
            this.panel1.Controls.Add(this.lblIsletimSistemi);
            this.panel1.Controls.Add(this.lblİslemci);
            this.panel1.Controls.Add(this.lblKDV);
            this.panel1.Controls.Add(this.txtIsletimSistemi);
            this.panel1.Controls.Add(this.txtIslemci);
            this.panel1.Controls.Add(this.txtKDV);
            this.panel1.Controls.Add(this.lblSatisFiyati);
            this.panel1.Controls.Add(this.lblAlisFiyati);
            this.panel1.Controls.Add(this.lblGelisTarihi);
            this.panel1.Controls.Add(this.lblUretimTarihi);
            this.panel1.Controls.Add(this.txtSatisFİyati);
            this.panel1.Controls.Add(this.txtAlisFiyati);
            this.panel1.Controls.Add(this.dateGelis);
            this.panel1.Controls.Add(this.dateUretim);
            this.panel1.Controls.Add(this.lblImeiNo);
            this.panel1.Controls.Add(this.lblSeriNo);
            this.panel1.Controls.Add(this.lblModel);
            this.panel1.Controls.Add(this.lblMarka);
            this.panel1.Controls.Add(this.txtImeiNo);
            this.panel1.Controls.Add(this.txtSeriNo);
            this.panel1.Controls.Add(this.comboModel);
            this.panel1.Controls.Add(this.comboMarka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 292);
            this.panel1.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(79, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(85, 20);
            this.txtID.TabIndex = 62;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(4, 19);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 61;
            this.lblID.Text = "ID";
            // 
            // btnResimSec
            // 
            this.btnResimSec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResimSec.Location = new System.Drawing.Point(418, 173);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(137, 24);
            this.btnResimSec.TabIndex = 60;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(418, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // lblToplamKayitSayisi
            // 
            this.lblToplamKayitSayisi.AutoSize = true;
            this.lblToplamKayitSayisi.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lblToplamKayitSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKayitSayisi.Location = new System.Drawing.Point(676, 175);
            this.lblToplamKayitSayisi.Name = "lblToplamKayitSayisi";
            this.lblToplamKayitSayisi.Size = new System.Drawing.Size(193, 20);
            this.lblToplamKayitSayisi.TabIndex = 58;
            this.lblToplamKayitSayisi.Text = "Toplam Kayıt Sayısı      ";
            // 
            // btnMarkaModelGuncelle
            // 
            this.btnMarkaModelGuncelle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMarkaModelGuncelle.Location = new System.Drawing.Point(291, 22);
            this.btnMarkaModelGuncelle.Name = "btnMarkaModelGuncelle";
            this.btnMarkaModelGuncelle.Size = new System.Drawing.Size(121, 43);
            this.btnMarkaModelGuncelle.TabIndex = 57;
            this.btnMarkaModelGuncelle.Text = "Marka-Model Güncelle";
            this.btnMarkaModelGuncelle.UseVisualStyleBackColor = false;
            this.btnMarkaModelGuncelle.Click += new System.EventHandler(this.btnMarkaModelGuncelle_Click);
            // 
            // lblYeniModel
            // 
            this.lblYeniModel.AutoSize = true;
            this.lblYeniModel.Location = new System.Drawing.Point(217, 44);
            this.lblYeniModel.Name = "lblYeniModel";
            this.lblYeniModel.Size = new System.Drawing.Size(60, 13);
            this.lblYeniModel.TabIndex = 56;
            this.lblYeniModel.Text = "Yeni Model";
            // 
            // lblYeniMarka
            // 
            this.lblYeniMarka.AutoSize = true;
            this.lblYeniMarka.Location = new System.Drawing.Point(217, 23);
            this.lblYeniMarka.Name = "lblYeniMarka";
            this.lblYeniMarka.Size = new System.Drawing.Size(61, 13);
            this.lblYeniMarka.TabIndex = 55;
            this.lblYeniMarka.Text = "Yeni Marka";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGuncelle.Location = new System.Drawing.Point(571, 84);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 35);
            this.btnGuncelle.TabIndex = 54;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSeriNoImei
            // 
            this.txtSeriNoImei.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtSeriNoImei.Location = new System.Drawing.Point(791, 19);
            this.txtSeriNoImei.Name = "txtSeriNoImei";
            this.txtSeriNoImei.Size = new System.Drawing.Size(127, 20);
            this.txtSeriNoImei.TabIndex = 53;
            this.txtSeriNoImei.Text = "SeriNo veya ImeioNo Ara";
            this.txtSeriNoImei.Click += new System.EventHandler(this.txtSeriNoImei_Click);
            this.txtSeriNoImei.TextChanged += new System.EventHandler(this.txtBilgisayarAra_TextChanged);
            // 
            // lblBilgisayarAra
            // 
            this.lblBilgisayarAra.AutoSize = true;
            this.lblBilgisayarAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgisayarAra.Location = new System.Drawing.Point(701, 22);
            this.lblBilgisayarAra.Name = "lblBilgisayarAra";
            this.lblBilgisayarAra.Size = new System.Drawing.Size(84, 13);
            this.lblBilgisayarAra.TabIndex = 52;
            this.lblBilgisayarAra.Text = "Bilgisayar Ara";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkRed;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSil.Location = new System.Drawing.Point(571, 125);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 37);
            this.btnSil.TabIndex = 51;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIptal.Location = new System.Drawing.Point(571, 166);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 34);
            this.btnIptal.TabIndex = 50;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRenk.Location = new System.Drawing.Point(214, 206);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(33, 13);
            this.lblRenk.TabIndex = 49;
            this.lblRenk.Text = "Renk";
            // 
            // lblCozunurluk
            // 
            this.lblCozunurluk.AutoSize = true;
            this.lblCozunurluk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCozunurluk.Location = new System.Drawing.Point(214, 180);
            this.lblCozunurluk.Name = "lblCozunurluk";
            this.lblCozunurluk.Size = new System.Drawing.Size(60, 13);
            this.lblCozunurluk.TabIndex = 48;
            this.lblCozunurluk.Text = "Çözünürlük";
            // 
            // lblHafiza
            // 
            this.lblHafiza.AutoSize = true;
            this.lblHafiza.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHafiza.Location = new System.Drawing.Point(214, 154);
            this.lblHafiza.Name = "lblHafiza";
            this.lblHafiza.Size = new System.Drawing.Size(37, 13);
            this.lblHafiza.TabIndex = 47;
            this.lblHafiza.Text = "Hafıza";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(291, 206);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(121, 20);
            this.txtRenk.TabIndex = 46;
            // 
            // txtCozunurluk
            // 
            this.txtCozunurluk.Location = new System.Drawing.Point(291, 180);
            this.txtCozunurluk.Name = "txtCozunurluk";
            this.txtCozunurluk.Size = new System.Drawing.Size(121, 20);
            this.txtCozunurluk.TabIndex = 45;
            // 
            // txtHafiza
            // 
            this.txtHafiza.Location = new System.Drawing.Point(291, 154);
            this.txtHafiza.Name = "txtHafiza";
            this.txtHafiza.Size = new System.Drawing.Size(121, 20);
            this.txtHafiza.TabIndex = 44;
            // 
            // lblMiktari
            // 
            this.lblMiktari.AutoSize = true;
            this.lblMiktari.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMiktari.Location = new System.Drawing.Point(2, 262);
            this.lblMiktari.Name = "lblMiktari";
            this.lblMiktari.Size = new System.Drawing.Size(38, 13);
            this.lblMiktari.TabIndex = 43;
            this.lblMiktari.Text = "Miktarı";
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(79, 259);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(121, 20);
            this.txtMiktari.TabIndex = 42;
            // 
            // lblIsletimSistemi
            // 
            this.lblIsletimSistemi.AutoSize = true;
            this.lblIsletimSistemi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIsletimSistemi.Location = new System.Drawing.Point(214, 128);
            this.lblIsletimSistemi.Name = "lblIsletimSistemi";
            this.lblIsletimSistemi.Size = new System.Drawing.Size(72, 13);
            this.lblIsletimSistemi.TabIndex = 41;
            this.lblIsletimSistemi.Text = "İşletim Sistemi";
            // 
            // lblİslemci
            // 
            this.lblİslemci.AutoSize = true;
            this.lblİslemci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblİslemci.Location = new System.Drawing.Point(214, 102);
            this.lblİslemci.Name = "lblİslemci";
            this.lblİslemci.Size = new System.Drawing.Size(39, 13);
            this.lblİslemci.TabIndex = 40;
            this.lblİslemci.Text = "İslemci";
            // 
            // lblKDV
            // 
            this.lblKDV.AutoSize = true;
            this.lblKDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKDV.Location = new System.Drawing.Point(214, 76);
            this.lblKDV.Name = "lblKDV";
            this.lblKDV.Size = new System.Drawing.Size(29, 13);
            this.lblKDV.TabIndex = 39;
            this.lblKDV.Text = "KDV";
            // 
            // txtIsletimSistemi
            // 
            this.txtIsletimSistemi.Location = new System.Drawing.Point(291, 128);
            this.txtIsletimSistemi.Name = "txtIsletimSistemi";
            this.txtIsletimSistemi.Size = new System.Drawing.Size(121, 20);
            this.txtIsletimSistemi.TabIndex = 38;
            // 
            // txtIslemci
            // 
            this.txtIslemci.Location = new System.Drawing.Point(291, 102);
            this.txtIslemci.Name = "txtIslemci";
            this.txtIslemci.Size = new System.Drawing.Size(121, 20);
            this.txtIslemci.TabIndex = 37;
            // 
            // txtKDV
            // 
            this.txtKDV.Location = new System.Drawing.Point(291, 76);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(121, 20);
            this.txtKDV.TabIndex = 36;
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSatisFiyati.Location = new System.Drawing.Point(2, 233);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(57, 13);
            this.lblSatisFiyati.TabIndex = 34;
            this.lblSatisFiyati.Text = "Satış Fiyatı";
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.AutoSize = true;
            this.lblAlisFiyati.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAlisFiyati.Location = new System.Drawing.Point(2, 207);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(50, 13);
            this.lblAlisFiyati.TabIndex = 33;
            this.lblAlisFiyati.Text = "Alış Fiyati";
            // 
            // lblGelisTarihi
            // 
            this.lblGelisTarihi.AutoSize = true;
            this.lblGelisTarihi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGelisTarihi.Location = new System.Drawing.Point(2, 181);
            this.lblGelisTarihi.Name = "lblGelisTarihi";
            this.lblGelisTarihi.Size = new System.Drawing.Size(59, 13);
            this.lblGelisTarihi.TabIndex = 32;
            this.lblGelisTarihi.Text = "Geliş Tarihi";
            // 
            // lblUretimTarihi
            // 
            this.lblUretimTarihi.AutoSize = true;
            this.lblUretimTarihi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUretimTarihi.Location = new System.Drawing.Point(2, 159);
            this.lblUretimTarihi.Name = "lblUretimTarihi";
            this.lblUretimTarihi.Size = new System.Drawing.Size(66, 13);
            this.lblUretimTarihi.TabIndex = 31;
            this.lblUretimTarihi.Text = "Üretim Tarihi";
            // 
            // txtSatisFİyati
            // 
            this.txtSatisFİyati.Location = new System.Drawing.Point(79, 233);
            this.txtSatisFİyati.Name = "txtSatisFİyati";
            this.txtSatisFİyati.Size = new System.Drawing.Size(121, 20);
            this.txtSatisFİyati.TabIndex = 30;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(79, 207);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(121, 20);
            this.txtAlisFiyati.TabIndex = 29;
            // 
            // dateGelis
            // 
            this.dateGelis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGelis.Location = new System.Drawing.Point(79, 180);
            this.dateGelis.Name = "dateGelis";
            this.dateGelis.Size = new System.Drawing.Size(121, 20);
            this.dateGelis.TabIndex = 28;
            // 
            // dateUretim
            // 
            this.dateUretim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateUretim.Location = new System.Drawing.Point(79, 153);
            this.dateUretim.Name = "dateUretim";
            this.dateUretim.Size = new System.Drawing.Size(121, 20);
            this.dateUretim.TabIndex = 27;
            // 
            // lblImeiNo
            // 
            this.lblImeiNo.AutoSize = true;
            this.lblImeiNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblImeiNo.Location = new System.Drawing.Point(2, 128);
            this.lblImeiNo.Name = "lblImeiNo";
            this.lblImeiNo.Size = new System.Drawing.Size(43, 13);
            this.lblImeiNo.TabIndex = 26;
            this.lblImeiNo.Text = "Imei No";
            // 
            // lblSeriNo
            // 
            this.lblSeriNo.AutoSize = true;
            this.lblSeriNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSeriNo.Location = new System.Drawing.Point(2, 102);
            this.lblSeriNo.Name = "lblSeriNo";
            this.lblSeriNo.Size = new System.Drawing.Size(42, 13);
            this.lblSeriNo.TabIndex = 25;
            this.lblSeriNo.Text = "Seri No";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblModel.Location = new System.Drawing.Point(2, 76);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 24;
            this.lblModel.Text = "Model";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMarka.Location = new System.Drawing.Point(2, 50);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(37, 13);
            this.lblMarka.TabIndex = 23;
            this.lblMarka.Text = "Marka";
            // 
            // txtImeiNo
            // 
            this.txtImeiNo.Location = new System.Drawing.Point(79, 125);
            this.txtImeiNo.Name = "txtImeiNo";
            this.txtImeiNo.Size = new System.Drawing.Size(121, 20);
            this.txtImeiNo.TabIndex = 22;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(79, 98);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(121, 20);
            this.txtSeriNo.TabIndex = 21;
            // 
            // comboModel
            // 
            this.comboModel.DataSource = this.fKTBLModelTBLMarkaBindingSource;
            this.comboModel.DisplayMember = "Model";
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(79, 70);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(121, 21);
            this.comboModel.TabIndex = 20;
            // 
            // fKTBLModelTBLMarkaBindingSource
            // 
            this.fKTBLModelTBLMarkaBindingSource.DataMember = "FK_TBLModel_TBLMarka";
            this.fKTBLModelTBLMarkaBindingSource.DataSource = this.tBLMarkaBindingSource;
            // 
            // tBLMarkaBindingSource
            // 
            this.tBLMarkaBindingSource.DataMember = "TBLMarka";
            this.tBLMarkaBindingSource.DataSource = this.bilgisayarDataSetBindingSource;
            // 
            // comboMarka
            // 
            this.comboMarka.DataSource = this.tBLMarkaBindingSource;
            this.comboMarka.DisplayMember = "Marka";
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(79, 43);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(121, 21);
            this.comboMarka.TabIndex = 19;
            // 
            // tBLMarkaTableAdapter
            // 
            this.tBLMarkaTableAdapter.ClearBeforeFill = true;
            // 
            // tBLModelTableAdapter
            // 
            this.tBLModelTableAdapter.ClearBeforeFill = true;
            // 
            // lblToplamMaliyet
            // 
            this.lblToplamMaliyet.AutoSize = true;
            this.lblToplamMaliyet.Location = new System.Drawing.Point(677, 106);
            this.lblToplamMaliyet.Name = "lblToplamMaliyet";
            this.lblToplamMaliyet.Size = new System.Drawing.Size(35, 13);
            this.lblToplamMaliyet.TabIndex = 63;
            this.lblToplamMaliyet.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tBLMarkaBindingSource;
            this.comboBox1.DisplayMember = "Marka";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(791, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 64;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblBilgMarkaAra
            // 
            this.lblBilgMarkaAra.AutoSize = true;
            this.lblBilgMarkaAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgMarkaAra.Location = new System.Drawing.Point(662, 52);
            this.lblBilgMarkaAra.Name = "lblBilgMarkaAra";
            this.lblBilgMarkaAra.Size = new System.Drawing.Size(123, 13);
            this.lblBilgMarkaAra.TabIndex = 65;
            this.lblBilgMarkaAra.Text = "Bilgisayar Marka Ara";
            // 
            // frmBilgisayarListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmBilgisayarListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgisayar Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmBilgisayarListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayarDataSetBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLModelTBLMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bilgisayarDataSetBindingSource1;
        private BilgisayarDataSet bilgisayarDataSet;
        private System.Windows.Forms.BindingSource bilgisayarDataSetBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblImeiNo;
        private System.Windows.Forms.Label lblSeriNo;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtImeiNo;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.Label lblGelisTarihi;
        private System.Windows.Forms.Label lblUretimTarihi;
        private System.Windows.Forms.TextBox txtSatisFİyati;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.DateTimePicker dateGelis;
        private System.Windows.Forms.DateTimePicker dateUretim;
        private System.Windows.Forms.Label lblMiktari;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.Label lblIsletimSistemi;
        private System.Windows.Forms.Label lblİslemci;
        private System.Windows.Forms.Label lblKDV;
        private System.Windows.Forms.TextBox txtIsletimSistemi;
        private System.Windows.Forms.TextBox txtIslemci;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.Label lblToplamKayitSayisi;
        private System.Windows.Forms.Button btnMarkaModelGuncelle;
        private System.Windows.Forms.Label lblYeniModel;
        private System.Windows.Forms.Label lblYeniMarka;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtSeriNoImei;
        private System.Windows.Forms.Label lblBilgisayarAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblCozunurluk;
        private System.Windows.Forms.Label lblHafiza;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtCozunurluk;
        private System.Windows.Forms.TextBox txtHafiza;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.BindingSource tBLMarkaBindingSource;
        private BilgisayarDataSetTableAdapters.TBLMarkaTableAdapter tBLMarkaTableAdapter;
        private System.Windows.Forms.BindingSource fKTBLModelTBLMarkaBindingSource;
        private BilgisayarDataSetTableAdapters.TBLModelTableAdapter tBLModelTableAdapter;
        private System.Windows.Forms.Label lblToplamMaliyet;
        private System.Windows.Forms.Label lblBilgMarkaAra;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}