using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayarSatisveTeknikServisOtomasyonu.Classlar
{
    class Sepet_Satis
    {
        SqlConnection baglanti = new SqlConnection(VeriTabani.strbaglanti);

        public SqlDataReader MusteriIDAra(SqlCommand komut,TextBox musteriid, TextBox adisoyadi, TextBox telefon, TextBox email)
        {
            string sorgu = "select *from musteri where ID= '"+musteriid.Text+"' ";

            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {

                adisoyadi.Text = dr["adisoyadi"].ToString();
                telefon.Text = dr["telefon"].ToString();
               // email.Text = dr["email"].ToString();
            }

            baglanti.Close();

            return dr;
        }

        public SqlDataReader SeriNoAra (SqlCommand komut, TextBox serino, TextBox urunid , TextBox marka, TextBox model , TextBox imeino, TextBox birimfiyati, TextBox miktari, TextBox toplamfiyati, TextBox kdv, TextBox islemci, TextBox isletimsistemi, TextBox cozunurluk)
        {
            string sorgu = "select *from urun where serino= '" +serino.Text + "' ";

            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            if (baglanti.State == System.Data.ConnectionState.Closed) baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {

                urunid.Text = dr["Id"].ToString();
                marka.Text = dr["marka"].ToString();
                model.Text = dr["model"].ToString();
                imeino.Text = dr["imeino"].ToString();
                birimfiyati.Text = dr["satisfiyati"].ToString();
                kdv.Text = dr["kdv"].ToString();
                islemci.Text = dr["islemci"].ToString();
                isletimsistemi.Text = dr["isletimsistemi"].ToString();
                cozunurluk.Text = dr["cozunurluk"].ToString();


                double miktar = double.Parse(miktari.Text);
                double birimfiyat = double.Parse(birimfiyati.Text);

                double toplamfiyat = miktar * birimfiyat;
                toplamfiyati.Text = toplamfiyat.ToString("0.00");
            }



            baglanti.Close();

            return dr;
        }
 
        public DataTable SepetListele (DataGridView dgrid, string sorgu)
        {
            DataTable tbl = new DataTable();

            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tbl);
            dgrid.DataSource = tbl;

            return tbl;


        }

        public int SepeteEkle (SqlCommand komut, string sorgu)
        {
            int sonuc = 0;
            komut.CommandText = sorgu;
            komut.Connection = baglanti;

            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();

                try
                {
                    sonuc = komut.ExecuteNonQuery();
                    
                    MessageBox.Show("İşlem başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                    MessageBox.Show("Hata");
                }
                finally
                {
                    baglanti.Close();

                }


            }


            return sonuc;

        }


        public int EKG(SqlCommand komut, string sorgu)
        {
            int sonuc = 0;
            komut.CommandText = sorgu;
            komut.Connection = baglanti;

            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();

                try
                {
                    sonuc = komut.ExecuteNonQuery();
                   // MessageBox.Show("İşlem başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                }
                finally
                {
                    baglanti.Close();
                   // MessageBox.Show("Hata");
                }


            }


            return sonuc;

        }



    }
}
