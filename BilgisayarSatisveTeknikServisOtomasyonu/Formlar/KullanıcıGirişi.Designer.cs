namespace BilgisayarSatisveTeknikServisOtomasyonu
{
    partial class frmKullanıcıGirişi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanıcıGirişi));
            this.lblKullanıcıAdı = new System.Windows.Forms.Label();
            this.lblŞifre = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnGiriş = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.lblYeniKullanıcı = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullanıcıAdı
            // 
            this.lblKullanıcıAdı.AutoSize = true;
            this.lblKullanıcıAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanıcıAdı.Location = new System.Drawing.Point(129, 89);
            this.lblKullanıcıAdı.Name = "lblKullanıcıAdı";
            this.lblKullanıcıAdı.Size = new System.Drawing.Size(77, 13);
            this.lblKullanıcıAdı.TabIndex = 0;
            this.lblKullanıcıAdı.Text = "Kullanıcı Adı";
            // 
            // lblŞifre
            // 
            this.lblŞifre.AutoSize = true;
            this.lblŞifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblŞifre.Location = new System.Drawing.Point(145, 122);
            this.lblŞifre.Name = "lblŞifre";
            this.lblŞifre.Size = new System.Drawing.Size(33, 13);
            this.lblŞifre.TabIndex = 1;
            this.lblŞifre.Text = "Şifre";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(335, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnGiriş
            // 
            this.btnGiriş.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiriş.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiriş.ImageKey = "grs-removebg-preview.png";
            this.btnGiriş.ImageList = this.ımageList1;
            this.btnGiriş.Location = new System.Drawing.Point(205, 160);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(69, 42);
            this.btnGiriş.TabIndex = 3;
            this.btnGiriş.Text = "Giriş";
            this.btnGiriş.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiriş.UseVisualStyleBackColor = true;
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnİptal.ImageKey = "cancel-removebg-preview.png";
            this.btnİptal.ImageList = this.ımageList1;
            this.btnİptal.Location = new System.Drawing.Point(285, 160);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(67, 42);
            this.btnİptal.TabIndex = 4;
            this.btnİptal.Text = "İptal";
            this.btnİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(205, 89);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(124, 20);
            this.txtKullanıcıAdı.TabIndex = 6;
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(205, 122);
            this.txtŞifre.Multiline = true;
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.PasswordChar = '*';
            this.txtŞifre.Size = new System.Drawing.Size(124, 20);
            this.txtŞifre.TabIndex = 7;
            // 
            // lblYeniKullanıcı
            // 
            this.lblYeniKullanıcı.AutoSize = true;
            this.lblYeniKullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniKullanıcı.ForeColor = System.Drawing.Color.Maroon;
            this.lblYeniKullanıcı.Location = new System.Drawing.Point(233, 226);
            this.lblYeniKullanıcı.Name = "lblYeniKullanıcı";
            this.lblYeniKullanıcı.Size = new System.Drawing.Size(84, 13);
            this.lblYeniKullanıcı.TabIndex = 8;
            this.lblYeniKullanıcı.Text = "Yeni Kullanıcı";
            this.lblYeniKullanıcı.Click += new System.EventHandler(this.lblYeniKullanıcı_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "grs-removebg-preview.png");
            this.ımageList1.Images.SetKeyName(1, "cancel-removebg-preview.png");
            // 
            // frmKullanıcıGirişi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(404, 298);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblYeniKullanıcı);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnGiriş);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblŞifre);
            this.Controls.Add(this.lblKullanıcıAdı);
            this.Name = "frmKullanıcıGirişi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanıcıAdı;
        private System.Windows.Forms.Label lblŞifre;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnGiriş;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.Label lblYeniKullanıcı;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}