namespace BilgisayarSatisveTeknikServisOtomasyonu
{
    partial class frmAnasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCikis = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSatışYap = new System.Windows.Forms.Button();
            this.btnMüşteriListele = new System.Windows.Forms.Button();
            this.btnMüşteriEkle = new System.Windows.Forms.Button();
            this.btnKullanıcıListele = new System.Windows.Forms.Button();
            this.btnKullanıcıEkle = new System.Windows.Forms.Button();
            this.btnBilgisayarListele = new System.Windows.Forms.Button();
            this.btnBilgisayarEkle = new System.Windows.Forms.Button();
            this.panelSayfalar = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnSatışYap);
            this.panel1.Controls.Add(this.btnMüşteriListele);
            this.panel1.Controls.Add(this.btnMüşteriEkle);
            this.panel1.Controls.Add(this.btnKullanıcıListele);
            this.panel1.Controls.Add(this.btnKullanıcıEkle);
            this.panel1.Controls.Add(this.btnBilgisayarListele);
            this.panel1.Controls.Add(this.btnBilgisayarEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 101);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "cancel-removebg-preview.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(673, 21);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(68, 73);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "bilgs-ekle-removebg-preview.png");
            this.ımageList1.Images.SetKeyName(1, "bilgs-listele-removebg-preview.png");
            this.ımageList1.Images.SetKeyName(2, "cancel-removebg-preview.png");
            this.ımageList1.Images.SetKeyName(3, "kullanıcı-ekle-2-removebg-preview.png");
            this.ımageList1.Images.SetKeyName(4, "kullanıcı-listele-removebg-preview.png");
            this.ımageList1.Images.SetKeyName(5, "musteri-ekle-removebg-preview.png");
            this.ımageList1.Images.SetKeyName(6, "musteri-listele-removebg-preview.png");
            this.ımageList1.Images.SetKeyName(7, "satis-yap-removebg-preview.png");
            this.ımageList1.Images.SetKeyName(8, "yapilan-satislar-removebg-preview.png");
            // 
            // btnSatışYap
            // 
            this.btnSatışYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatışYap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSatışYap.ImageKey = "satis-yap-removebg-preview.png";
            this.btnSatışYap.ImageList = this.ımageList1;
            this.btnSatışYap.Location = new System.Drawing.Point(590, 21);
            this.btnSatışYap.Name = "btnSatışYap";
            this.btnSatışYap.Size = new System.Drawing.Size(68, 73);
            this.btnSatışYap.TabIndex = 6;
            this.btnSatışYap.Text = "Satış Yap";
            this.btnSatışYap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatışYap.UseVisualStyleBackColor = true;
            this.btnSatışYap.Click += new System.EventHandler(this.btnSatışYap_Click);
            // 
            // btnMüşteriListele
            // 
            this.btnMüşteriListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMüşteriListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMüşteriListele.ImageKey = "musteri-listele-removebg-preview.png";
            this.btnMüşteriListele.ImageList = this.ımageList1;
            this.btnMüşteriListele.Location = new System.Drawing.Point(499, 21);
            this.btnMüşteriListele.Name = "btnMüşteriListele";
            this.btnMüşteriListele.Size = new System.Drawing.Size(68, 73);
            this.btnMüşteriListele.TabIndex = 5;
            this.btnMüşteriListele.Text = "Müşteri Listele";
            this.btnMüşteriListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMüşteriListele.UseVisualStyleBackColor = true;
            this.btnMüşteriListele.Click += new System.EventHandler(this.btnMüşteriListele_Click);
            // 
            // btnMüşteriEkle
            // 
            this.btnMüşteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMüşteriEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMüşteriEkle.ImageKey = "musteri-ekle-removebg-preview.png";
            this.btnMüşteriEkle.ImageList = this.ımageList1;
            this.btnMüşteriEkle.Location = new System.Drawing.Point(403, 21);
            this.btnMüşteriEkle.Name = "btnMüşteriEkle";
            this.btnMüşteriEkle.Size = new System.Drawing.Size(68, 73);
            this.btnMüşteriEkle.TabIndex = 4;
            this.btnMüşteriEkle.Text = "Müşteri Ekle";
            this.btnMüşteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMüşteriEkle.UseVisualStyleBackColor = true;
            this.btnMüşteriEkle.Click += new System.EventHandler(this.btnMüşteriEkle_Click);
            // 
            // btnKullanıcıListele
            // 
            this.btnKullanıcıListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanıcıListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKullanıcıListele.ImageKey = "kullanıcı-listele-removebg-preview.png";
            this.btnKullanıcıListele.ImageList = this.ımageList1;
            this.btnKullanıcıListele.Location = new System.Drawing.Point(311, 21);
            this.btnKullanıcıListele.Name = "btnKullanıcıListele";
            this.btnKullanıcıListele.Size = new System.Drawing.Size(68, 73);
            this.btnKullanıcıListele.TabIndex = 3;
            this.btnKullanıcıListele.Text = "Kullanıcı Listele";
            this.btnKullanıcıListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullanıcıListele.UseVisualStyleBackColor = true;
            this.btnKullanıcıListele.Click += new System.EventHandler(this.btnKullanıcıListele_Click);
            // 
            // btnKullanıcıEkle
            // 
            this.btnKullanıcıEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullanıcıEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKullanıcıEkle.ImageKey = "kullanıcı-ekle-2-removebg-preview.png";
            this.btnKullanıcıEkle.ImageList = this.ımageList1;
            this.btnKullanıcıEkle.Location = new System.Drawing.Point(220, 21);
            this.btnKullanıcıEkle.Name = "btnKullanıcıEkle";
            this.btnKullanıcıEkle.Size = new System.Drawing.Size(68, 73);
            this.btnKullanıcıEkle.TabIndex = 2;
            this.btnKullanıcıEkle.Text = "Kullanıcı Ekle";
            this.btnKullanıcıEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullanıcıEkle.UseVisualStyleBackColor = true;
            this.btnKullanıcıEkle.Click += new System.EventHandler(this.btnKullanıcıEkle_Click);
            // 
            // btnBilgisayarListele
            // 
            this.btnBilgisayarListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgisayarListele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBilgisayarListele.ImageKey = "bilgs-listele-removebg-preview.png";
            this.btnBilgisayarListele.ImageList = this.ımageList1;
            this.btnBilgisayarListele.Location = new System.Drawing.Point(130, 21);
            this.btnBilgisayarListele.Name = "btnBilgisayarListele";
            this.btnBilgisayarListele.Size = new System.Drawing.Size(68, 73);
            this.btnBilgisayarListele.TabIndex = 1;
            this.btnBilgisayarListele.Text = "Bilgisayar Listele";
            this.btnBilgisayarListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBilgisayarListele.UseVisualStyleBackColor = true;
            this.btnBilgisayarListele.Click += new System.EventHandler(this.btnBilgisayarListele_Click);
            // 
            // btnBilgisayarEkle
            // 
            this.btnBilgisayarEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgisayarEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBilgisayarEkle.ImageKey = "bilgs-ekle-removebg-preview.png";
            this.btnBilgisayarEkle.ImageList = this.ımageList1;
            this.btnBilgisayarEkle.Location = new System.Drawing.Point(39, 21);
            this.btnBilgisayarEkle.Name = "btnBilgisayarEkle";
            this.btnBilgisayarEkle.Size = new System.Drawing.Size(73, 73);
            this.btnBilgisayarEkle.TabIndex = 0;
            this.btnBilgisayarEkle.Text = "Bilgisayar Ekle";
            this.btnBilgisayarEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBilgisayarEkle.UseVisualStyleBackColor = true;
            this.btnBilgisayarEkle.Click += new System.EventHandler(this.btnBilgisayarEkle_Click);
            // 
            // panelSayfalar
            // 
            this.panelSayfalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSayfalar.Location = new System.Drawing.Point(0, 101);
            this.panelSayfalar.Name = "panelSayfalar";
            this.panelSayfalar.Size = new System.Drawing.Size(800, 349);
            this.panelSayfalar.TabIndex = 2;
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSayfalar);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgisayar Satış Otomasyonu";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSatışYap;
        private System.Windows.Forms.Button btnMüşteriListele;
        private System.Windows.Forms.Button btnMüşteriEkle;
        private System.Windows.Forms.Button btnKullanıcıListele;
        private System.Windows.Forms.Button btnKullanıcıEkle;
        private System.Windows.Forms.Button btnBilgisayarListele;
        private System.Windows.Forms.Button btnBilgisayarEkle;
        private System.Windows.Forms.Panel panelSayfalar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

