using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayarSatisveTeknikServisOtomasyonu.Formlar
{
    public partial class frmKullaniciListele : Form
    {
        public frmKullaniciListele()
        {
            InitializeComponent();
        }

        private void frmKullaniciListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tumTablolarDataset.Kullanici' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullaniciTableAdapter.Fill(this.tumTablolarDataset.Kullanici);

        }
    }
}
