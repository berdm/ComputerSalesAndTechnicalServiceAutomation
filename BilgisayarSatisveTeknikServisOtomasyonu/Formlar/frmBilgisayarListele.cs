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
    public partial class frmBilgisayarListele : Form
    {
        public frmBilgisayarListele()
        {
            InitializeComponent();
        }
        BilgisayarDataSetTableAdapters.UrunTableAdapter ds = new BilgisayarDataSetTableAdapters.UrunTableAdapter();


        void Hesapla()
        {
            double geneltutar = 0;
            for(int i=0; i<dataGridView1.Rows.Count-1; i++)
            {
                double miktari = double.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString());
                double alisfiyati = double.Parse(dataGridView1.Rows[i].Cells["alisfiyati"].Value.ToString());

                double tutar = miktari * alisfiyati;

                geneltutar += tutar;

            }

            lblToplamMaliyet.Text = "Toplam Maliyet=" + geneltutar.ToString("C2");

            lblToplamKayitSayisi.Text = (dataGridView1.Rows.Count - 1) + "Kayıt Listelendi";
        }





        private void frmBilgisayarListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'bilgisayarDataSet.TBLModel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLModelTableAdapter.Fill(this.bilgisayarDataSet.TBLModel);
            // TODO: Bu kod satırı 'bilgisayarDataSet.TBLMarka' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLMarkaTableAdapter.Fill(this.bilgisayarDataSet.TBLMarka);
            dataGridView1.DataSource = ds.Listele2();

            Hesapla();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblYeniMarka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblYeniModel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSeriNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtImeiNo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAlisFiyati.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
           txtSatisFİyati.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
           txtKDV.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtIslemci.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
           txtIsletimSistemi.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtHafiza.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtCozunurluk.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtRenk.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
           pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            txtMiktari.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = file.FileName;
            }
        }

        private void btnMarkaModelGuncelle_Click(object sender, EventArgs e)
        {
            lblYeniMarka.Text = comboMarka.Text;
            lblYeniModel.Text = comboModel.Text;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        Classlar.Bilgisayar bilg = new Classlar.Bilgisayar();
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update urun set marka='"+lblYeniMarka.Text+"',model='"+lblYeniModel.Text+"',alisfiyati='"+double.Parse(txtAlisFiyati.Text)+"',satisfiyati='"+double.Parse(txtSatisFİyati.Text)+"',miktar='"+int.Parse(txtMiktari.Text)+"' where ID='"+txtID.Text+ "'";
            SqlCommand komut2 = new SqlCommand();
            bilg.ESG(komut2, sorgu2, comboMarka, comboModel, txtSeriNo, txtImeiNo, dateUretim, dateGelis, txtAlisFiyati, txtSatisFİyati, txtKDV, txtIslemci, txtIsletimSistemi, txtHafiza, txtCozunurluk, txtRenk, pictureBox1, txtMiktari);

            dataGridView1.DataSource = ds.Listele2();

            Hesapla();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu2 = "delete from urun where ID='" + dataGridView1.CurrentRow.Cells[0].Value + "'";

            SqlCommand komut2 = new SqlCommand();
            bilg.ESG(komut2, sorgu2, comboMarka, comboModel, txtSeriNo, txtImeiNo, dateUretim, dateGelis, txtAlisFiyati, txtSatisFİyati, txtKDV, txtIslemci, txtIsletimSistemi, txtHafiza, txtCozunurluk, txtRenk, pictureBox1, txtMiktari);

            dataGridView1.DataSource = ds.Listele2();

            Hesapla();



        }

        private void txtBilgisayarAra_TextChanged(object sender, EventArgs e)
        {
            bilg.BilgisayarAra(dataGridView1, txtSeriNoImei);
        }

        private void txtSeriNoImei_Click(object sender, EventArgs e)
        {
            txtSeriNoImei.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bilg.BilgisayarMarkaAra(dataGridView1, comboBox1);
        }
    }
}
