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
    public partial class frmSatisYap : Form
    {
        public frmSatisYap()
        {
            InitializeComponent();
        }

        private void panelUrun_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMusteriIDAra.Text = "";
            txtSeriNoAra.Text = "";
        }

        Classlar.Sepet_Satis satis = new Classlar.Sepet_Satis();

        private void txtMusteriIDAra_TextChanged(object sender, EventArgs e)
        {
            if(txtMusteriIDAra.Text=="")
            {
                foreach (Control item in this.panelMusteri.Controls) if (item is TextBox) item.Text = "";
            }

            SqlCommand komut2 = new SqlCommand();

            satis.MusteriIDAra(komut2,txtMusteriIDAra,txtAdiSoyadi,txtTelefon,txtEmail);
        }

        private void txtSeriNoAra_TextChanged(object sender, EventArgs e)
        {
            if (txtSeriNoAra.Text == "")
            {
                foreach (Control item in this.panelUrun.Controls) if (item is TextBox) item.Text = "";
                txtMiktari.Text = "1";
            }

            SqlCommand komut2 = new SqlCommand();

            satis.SeriNoAra(komut2,txtSeriNoAra,txtUrunID,txtMarka,txtModel,txtImeiNo,txtBirimFiyati,txtMiktari,txtToplamFiyati,txtKDV,txtIslemci,txtIsletimSistemi,txtCozunurluk);
        }

        private void txtMiktari_TextChanged(object sender, EventArgs e)
        {

            try
            {

                double toplamfiyat = double.Parse(txtMiktari.Text) * double.Parse(txtBirimFiyati.Text);
                txtToplamFiyati.Text = toplamfiyat.ToString("0.00");
            }
            catch
            {

            }


        }
        private void Yenile()
        {
            satis.SepetListele(dataGridView1, "select *from sepet");
            lblKayitSayisi.Text = "Toplam" + (dataGridView1.Rows.Count - 1) + "kayıt listelendi";

            double tutar = 0 ,kdv=0;
            for (int i = 0; i <dataGridView1.Rows.Count-1; i ++)
            {
                tutar +=double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString());
                kdv = tutar * 18 / 100;

            }

            lblToplamTutar.Text = tutar.ToString();
            lblKDV.Text = kdv.ToString("C2");

        }


        private void frmSatisYap_Load(object sender, EventArgs e)
        {
            //satis.SepetListele(dataGridView1,"select *from sepet");
            Yenile();
        }



        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into sepet values('" +txtMusteriIDAra.Text + "','" +txtAdiSoyadi.Text + "','" + txtTelefon.Text + "','" + txtMarka.Text + "', '" + txtModel.Text + "','" + txtSeriNoAra.Text + "','" + txtImeiNo.Text + "',@birimfiyati , '"+int.Parse(txtMiktari.Text)+"' , @toplamfiyati , '" +int.Parse(txtKDV.Text)+ "','"+ txtIslemci.Text+"','"+txtIsletimSistemi.Text+"')";

            SqlCommand komut2 = new SqlCommand();
            
            komut2.Parameters.AddWithValue("@birimfiyati", double.Parse(txtBirimFiyati.Text));
            komut2.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyati.Text));

            satis.SepeteEkle(komut2, sorgu2);

            satis.SepetListele(dataGridView1, "select *from sepet");
        }

        private void txtOdenen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double tutar = 0, odenen = 0;
                tutar = double.Parse(lblToplamTutar.Text);
                odenen = double.Parse(txtOdenen.Text);
                double paraustu = odenen - tutar;
                txtParaUstu.Text = paraustu.ToString("C2");
            }
            catch
            {

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.ColumnIndex==0)
            {
                string sorgu2 = " delete from sepet where Id='"+dataGridView1.CurrentRow.Cells["ID"].Value.ToString()+"' ";
                SqlCommand komut2 = new SqlCommand();
                satis.EKG(komut2,sorgu2);
                Yenile();
            }
            //azaltma
            if (e.ColumnIndex == 1)
            {
                string sorgu2 = "update sepet set miktari=miktari+1 where Id='"+dataGridView1.CurrentRow.Cells["Id"].Value.ToString()+"'";
                SqlCommand komut2 = new SqlCommand();
                satis.EKG(komut2, sorgu2);
                //toplam fiyata etki etmesi için
                string sorgu3 = "update sepet set toplamfiyati=birimfiyati*miktari where Id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'";
                SqlCommand komut3 = new SqlCommand();
                satis.EKG(komut3, sorgu3);


                Yenile();
            }

            //arttırma
            if (e.ColumnIndex == 2)
            {
                string sorgu2 = "update sepet set miktari=miktari-1 where Id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'";
                SqlCommand komut2 = new SqlCommand();
                satis.EKG(komut2, sorgu2);
                //toplam fiyata etki etmesi için
                string sorgu3 = "update sepet set toplamfiyati=birimfiyati*miktari where Id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'";
                SqlCommand komut3 = new SqlCommand();
                satis.EKG(komut3, sorgu3);

                Yenile();
            }




        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {
            string sorgu2 = "truncate table sepet "; //delete from table
            SqlCommand komut2 = new SqlCommand();

            satis.EKG(komut2,sorgu2);
            Yenile();

        }

        private void frmSatisYap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F1)
            {
                comboBoxOdemeTuru.SelectedIndex = 0;
                txtOdenen.Focus();
            }
            if (e.KeyCode == Keys.F2)
            {
                comboBoxOdemeTuru.SelectedIndex = 1;
                txtOdenen.Text = lblToplamTutar.Text;
                txtParaUstu.Text = "0.00";
                
            }



        }

        private void btnSatisOnay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Satış Yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblToplamTutar_Click(object sender, EventArgs e)
        {

        }

        private void txtParaUstu_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKDV_Click(object sender, EventArgs e)
        {

        }
    }
}
