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

namespace BilgisayarSatisveTeknikServisOtomasyonu
{
    public partial class frmBilgisayarEkle : Form
    {
        public frmBilgisayarEkle()
        {
            InitializeComponent();
        }

        private void frmBilgisayarEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'bilgisayarDataSet.TBLModel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLModelTableAdapter.Fill(this.bilgisayarDataSet.TBLModel);
            // TODO: Bu kod satırı 'bilgisayarDataSet.TBLMarka' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLMarkaTableAdapter.Fill(this.bilgisayarDataSet.TBLMarka);

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            pictureBox1.ImageLocation = file.FileName;
        }

        Classlar.Bilgisayar bilg = new Classlar.Bilgisayar();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into urun values('"+comboMarka.Text+ "','" + comboModel.Text + "','" + txtSeriNo.Text + "','" + txtImeiNo.Text + "',@uretimtarihi,@alistarihi,@alisfiyati,@satisfiyati, '" +int.Parse(txtKDV.Text)+"','" +txtIslemci.Text+"','" +txtIsletimSistemi.Text +"','"+txtHafiza.Text+"', '" +txtCozunurluk.Text+"','"+txtRenk.Text+"','"+pictureBox1.ImageLocation+"' ,'"+int.Parse(txtMiktari.Text)+"')";

            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@uretimtarihi",dateUretim.Value);
            komut2.Parameters.AddWithValue("@alistarihi",dateGelis.Value);
            komut2.Parameters.AddWithValue("@alisfiyati",double.Parse(txtAlisFiyati.Text));
            komut2.Parameters.AddWithValue("@satisfiyati",double.Parse(txtSatisFİyati.Text));

            bilg.ESG(komut2,sorgu2,comboMarka,comboModel,txtSeriNo,txtImeiNo,dateUretim,dateGelis,txtAlisFiyati,txtSatisFİyati,txtKDV,txtIslemci,txtIsletimSistemi,txtHafiza,txtCozunurluk,txtRenk,pictureBox1,txtMiktari);

        }
    }
}
