using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayarSatisveTeknikServisOtomasyonu.Formlar
{
    public partial class frmMusteriListele : Form
    {
        public frmMusteriListele()
        {
            InitializeComponent();
        }


        Classlar.Bilgisayar bilg = new Classlar.Bilgisayar();
        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            bilg.Listele(dataGridView1,"select *from musteri");

            txtAdiSoyadi.DataBindings.Add("text",bilg.tbl,"adisoyadi");
            txtAdres.DataBindings.Add("text", bilg.tbl, "adres");
            //txtEmail.DataBindings.Add("text", bilg.tbl, "email");
            maskedTelefon.DataBindings.Add("text",bilg.tbl,"telefon");

            KayitSayisi();
          

        }

   

        private void txtMusteriAra_TextChanged(object sender, EventArgs e)
        {
            

             bilg.Listele(dataGridView1, "select *from musteri where adisoyadi like '%"+ txtMusteriAra.Text+"%'");

            KayitSayisi();

        }

        void KayitSayisi()
        {
            lblToplamKayitSayisi.Text = "Toplam" + (dataGridView1.Rows.Count - 1) + " kayıt listelendi";
        }
    }
}
