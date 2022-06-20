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
    class Bilgisayar
    {
        SqlConnection baglanti = new SqlConnection(VeriTabani.strbaglanti);


        public void BilgisayarMarkaAra(DataGridView grid, ComboBox cmbmarka)
        {
            DataTable tbl = new DataTable();
            tbl.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where marka='" + cmbmarka.Text+ "'", baglanti);
            adtr.Fill(tbl);
            grid.DataSource = tbl;
        }


        public void BilgisayarAra( DataGridView grid, TextBox txtara)
        {
            DataTable tbl = new DataTable();
            tbl.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where serino like'%" +txtara.Text+"%' or imeino like '%"+txtara.Text+"%'",baglanti);
            adtr.Fill(tbl);
            grid.DataSource = tbl;
        }


        




        //geriye deger donduren metot

        //ekleme silme ve guncelleme icin
        public int ESG(SqlCommand komut, string sorgu, ComboBox marka, ComboBox model, TextBox serino, TextBox imeino, DateTimePicker dateuretim, DateTimePicker dategelis, TextBox alisfiyati, TextBox satisfiyati,TextBox kdv, TextBox islemci, TextBox isletimsistemi, TextBox hafiza, TextBox cozunurluk, TextBox renk, PictureBox resim, TextBox miktar)
        {
            int sonuc = 0;
            komut.CommandText = sorgu;
            komut.Connection=baglanti;

            if(baglanti.State==System.Data.ConnectionState.Closed)
            {
                baglanti.Open();

                try
                {
                    sonuc = komut.ExecuteNonQuery();
                    MessageBox.Show("İşlem başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    string hata = ex.Message;
                }
                finally
                {
                    baglanti.Close();
                }


            }


            return sonuc;
        }

       public int EKG(SqlCommand komut,string sorgu)
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
                }
                finally
                {
                    baglanti.Close();
                }


            }


            return sonuc;

        }

         public DataTable tbl = new DataTable();
        public DataTable Listele( DataGridView dgrid, string sorgu)
        {
          
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu,baglanti);
            adtr.Fill(tbl);
            dgrid.DataSource = tbl;

            return tbl;


        }

        
        }



    }

