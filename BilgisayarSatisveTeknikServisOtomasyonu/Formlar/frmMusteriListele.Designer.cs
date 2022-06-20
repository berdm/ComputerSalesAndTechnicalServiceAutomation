namespace BilgisayarSatisveTeknikServisOtomasyonu.Formlar
{
    partial class frmMusteriListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.lblMusteriAra = new System.Windows.Forms.Label();
            this.txtMusteriAra = new System.Windows.Forms.TextBox();
            this.lblToplamKayitSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Adı Soyadı";
            // 
            // maskedTelefon
            // 
            this.maskedTelefon.Location = new System.Drawing.Point(68, 299);
            this.maskedTelefon.Mask = "000-000-00-00";
            this.maskedTelefon.Name = "maskedTelefon";
            this.maskedTelefon.Size = new System.Drawing.Size(120, 20);
            this.maskedTelefon.TabIndex = 13;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(68, 325);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(158, 50);
            this.txtAdres.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(68, 381);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(68, 273);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(120, 20);
            this.txtAdiSoyadi.TabIndex = 10;
            // 
            // lblMusteriAra
            // 
            this.lblMusteriAra.AutoSize = true;
            this.lblMusteriAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAra.Location = new System.Drawing.Point(428, 278);
            this.lblMusteriAra.Name = "lblMusteriAra";
            this.lblMusteriAra.Size = new System.Drawing.Size(86, 16);
            this.lblMusteriAra.TabIndex = 20;
            this.lblMusteriAra.Text = "Müşteri Ara";
            // 
            // txtMusteriAra
            // 
            this.txtMusteriAra.Location = new System.Drawing.Point(520, 277);
            this.txtMusteriAra.Name = "txtMusteriAra";
            this.txtMusteriAra.Size = new System.Drawing.Size(122, 20);
            this.txtMusteriAra.TabIndex = 21;
            this.txtMusteriAra.TextChanged += new System.EventHandler(this.txtMusteriAra_TextChanged);
            // 
            // lblToplamKayitSayisi
            // 
            this.lblToplamKayitSayisi.AutoSize = true;
            this.lblToplamKayitSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKayitSayisi.Location = new System.Drawing.Point(428, 324);
            this.lblToplamKayitSayisi.Name = "lblToplamKayitSayisi";
            this.lblToplamKayitSayisi.Size = new System.Drawing.Size(130, 18);
            this.lblToplamKayitSayisi.TabIndex = 22;
            this.lblToplamKayitSayisi.Text = "Kayıt Sayısı       ";
            // 
            // frmMusteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(719, 432);
            this.Controls.Add(this.lblToplamKayitSayisi);
            this.Controls.Add(this.txtMusteriAra);
            this.Controls.Add(this.lblMusteriAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdiSoyadi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMusteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmMusteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.Label lblMusteriAra;
        private System.Windows.Forms.TextBox txtMusteriAra;
        private System.Windows.Forms.Label lblToplamKayitSayisi;
    }
}