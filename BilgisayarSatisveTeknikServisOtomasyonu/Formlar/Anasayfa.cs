using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayarSatisveTeknikServisOtomasyonu
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        private void FormGetir(Form frm)
        {
            panelSayfalar.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Left;
            panelSayfalar.Controls.Add(frm);
            frm.Show();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnBilgisayarEkle_Click(object sender, EventArgs e)
        {
            frmBilgisayarEkle bilgekle = new frmBilgisayarEkle();
            FormGetir(bilgekle);
        }

        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {
            frmYeniKullanici yeni = new frmYeniKullanici();
            FormGetir(yeni);
            
        }

        private void btnBilgisayarListele_Click(object sender, EventArgs e)
        {
            Formlar.frmBilgisayarListele bilgliste = new Formlar.frmBilgisayarListele();
            FormGetir(bilgliste);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkmak istiyor musunuz?","Çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes) Application.Exit();
        }

        private void btnKullanıcıListele_Click(object sender, EventArgs e)
        {
            Formlar.frmKullaniciListele liste = new Formlar.frmKullaniciListele();

            FormGetir(liste);

        }

        private void btnMüşteriEkle_Click(object sender, EventArgs e)
        {
            Formlar.frmMusteriEkle ekle = new Formlar.frmMusteriEkle();
            FormGetir(ekle);
        }

        private void btnMüşteriListele_Click(object sender, EventArgs e)
        {
            Formlar.frmMusteriListele listele = new Formlar.frmMusteriListele();
            FormGetir(listele);
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            Formlar.frmSatisYap satis = new Formlar.frmSatisYap();
            FormGetir(satis);
        }

        private void btnYapılanSatışlar_Click(object sender, EventArgs e)
        {
            Formlar.frmSatisListele listele = new Formlar.frmSatisListele();
            FormGetir(listele);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
