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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        Classlar.Bilgisayar bilg = new Classlar.Bilgisayar();
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into musteri values('"+txtAdiSoyadi.Text+ "','" +maskedTelefon.Text + "','" + txtAdres.Text + "','" + txtEmail.Text + "')";
            SqlCommand komut2 = new SqlCommand();

            bilg.EKG(komut2,sorgu2);
        }
    }
}
