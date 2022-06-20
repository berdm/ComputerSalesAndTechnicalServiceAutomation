namespace BilgisayarSatisveTeknikServisOtomasyonu.Formlar
{
    partial class frmKullaniciListele
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
            this.tumTablolarDataset = new BilgisayarSatisveTeknikServisOtomasyonu.TumTablolarDataset();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciTableAdapter = new BilgisayarSatisveTeknikServisOtomasyonu.TumTablolarDatasetTableAdapters.KullaniciTableAdapter();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goreviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGorevi = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblGorevi = new System.Windows.Forms.Label();
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.lblAdıSoyadı = new System.Windows.Forms.Label();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumTablolarDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.adiSoyadiDataGridViewTextBoxColumn,
            this.telNoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.goreviDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullaniciBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // tumTablolarDataset
            // 
            this.tumTablolarDataset.DataSetName = "TumTablolarDataset";
            this.tumTablolarDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this.tumTablolarDataset;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adiSoyadiDataGridViewTextBoxColumn
            // 
            this.adiSoyadiDataGridViewTextBoxColumn.DataPropertyName = "AdiSoyadi";
            this.adiSoyadiDataGridViewTextBoxColumn.HeaderText = "AdiSoyadi";
            this.adiSoyadiDataGridViewTextBoxColumn.Name = "adiSoyadiDataGridViewTextBoxColumn";
            // 
            // telNoDataGridViewTextBoxColumn
            // 
            this.telNoDataGridViewTextBoxColumn.DataPropertyName = "TelNo";
            this.telNoDataGridViewTextBoxColumn.HeaderText = "TelNo";
            this.telNoDataGridViewTextBoxColumn.Name = "telNoDataGridViewTextBoxColumn";
            this.telNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.Visible = false;
            // 
            // goreviDataGridViewTextBoxColumn
            // 
            this.goreviDataGridViewTextBoxColumn.DataPropertyName = "Gorevi";
            this.goreviDataGridViewTextBoxColumn.HeaderText = "Gorevi";
            this.goreviDataGridViewTextBoxColumn.Name = "goreviDataGridViewTextBoxColumn";
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "Resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "Resim";
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            // 
            // txtGorevi
            // 
            this.txtGorevi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "Gorevi", true));
            this.txtGorevi.Location = new System.Drawing.Point(323, 369);
            this.txtGorevi.Name = "txtGorevi";
            this.txtGorevi.Size = new System.Drawing.Size(100, 20);
            this.txtGorevi.TabIndex = 35;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "KullaniciAdi", true));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(323, 343);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKullaniciAdi.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(323, 317);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 31;
            // 
            // txtAdres
            // 
            this.txtAdres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "Adres", true));
            this.txtAdres.Location = new System.Drawing.Point(126, 372);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 30;
            // 
            // lblGorevi
            // 
            this.lblGorevi.AutoSize = true;
            this.lblGorevi.Location = new System.Drawing.Point(242, 372);
            this.lblGorevi.Name = "lblGorevi";
            this.lblGorevi.Size = new System.Drawing.Size(38, 13);
            this.lblGorevi.TabIndex = 29;
            this.lblGorevi.Text = "Görevi";
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(242, 346);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(64, 13);
            this.lblKullanıcıAdı.TabIndex = 26;
            this.lblKullanıcıAdı.Text = "Kullanıcı Adı";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(242, 324);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(45, 375);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 24;
            this.lblAdres.Text = "Adres";
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "TelNo", true));
            this.txtTelefonNo.Location = new System.Drawing.Point(126, 346);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonNo.TabIndex = 23;
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Location = new System.Drawing.Point(45, 346);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(60, 13);
            this.lblTelefonNo.TabIndex = 22;
            this.lblTelefonNo.Text = "Telefon No";
            // 
            // lblAdıSoyadı
            // 
            this.lblAdıSoyadı.AutoSize = true;
            this.lblAdıSoyadı.Location = new System.Drawing.Point(45, 320);
            this.lblAdıSoyadı.Name = "lblAdıSoyadı";
            this.lblAdıSoyadı.Size = new System.Drawing.Size(57, 13);
            this.lblAdıSoyadı.TabIndex = 21;
            this.lblAdıSoyadı.Text = "Adı Soyadı";
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource, "AdiSoyadi", true));
            this.txtAdiSoyadi.Location = new System.Drawing.Point(126, 320);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtAdiSoyadi.TabIndex = 20;
            // 
            // frmKullaniciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.txtGorevi);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblGorevi);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.lblTelefonNo);
            this.Controls.Add(this.lblAdıSoyadı);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKullaniciListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmKullaniciListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumTablolarDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TumTablolarDataset tumTablolarDataset;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private TumTablolarDatasetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goreviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtGorevi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblGorevi;
        private System.Windows.Forms.Label lblKullanıcıAdı;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.Label lblTelefonNo;
        private System.Windows.Forms.Label lblAdıSoyadı;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
    }
}