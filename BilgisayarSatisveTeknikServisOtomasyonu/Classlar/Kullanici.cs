using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BilgisayarSatisveTeknikServisOtomasyonu.Classlar
{
    class Kullanici
    {
        SqlConnection baglanti = new SqlConnection(VeriTabani.strbaglanti);

        private string adisoyadi;
        private string telefon;
        string ades;
        string email;
        string kullaniciadi;
        string şifre;
        string gorevi;
        string resim;

        public string AdiSoyadi1 
        { 
            get
            { return adisoyadi; }
            set 
            { adisoyadi = value; } 
        }

        public string Telefon1 { get => telefon; set => telefon = value; }
        public string Ades { get => ades; set => ades = value; }
        public string Email { get => email; set => email = value; }
        public string Kullaniciadi { get => kullaniciadi; set => kullaniciadi = value; }
        public string Şifre { get => şifre; set => şifre = value; }
        public string Gorevi { get => gorevi; set => gorevi = value; }
        public string Resim { get => resim; set => resim = value; }


        public void KullaniciGirisi(TextBox sifretxt , TextBox kullaniciaditxt)
        {
            if(kullaniciaditxt.Text=="" || sifretxt.Text=="")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçilemez !", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Kullanici where kullaniciadi= '" + kullaniciaditxt.Text + "' and sifre='" + sifretxt.Text+"'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                if(dr.Read())
                {
                    frmAnasayfa anasayfa = new frmAnasayfa();
                    frmKullanıcıGirişi.ActiveForm.Visible = false;
                    anasayfa.Show();
                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ve/veya şifrenizi kontrol ediniz!", "Uyarı-2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                baglanti.Close();
            }      
        }
        public void YeniKullanici(string _AdiSoyadi, string _TelNo, string _Adres, string _Email, string _KullaniciAdi, string _Sifre, string _SifreTekrar, string _Gorevi, string _Resim)
        {
            AdiSoyadi1 = _AdiSoyadi;
            Telefon1 = _TelNo;
            Ades = _Adres;
            Email = _Email;
            Kullaniciadi = _KullaniciAdi;
            Şifre = _Sifre;
            Gorevi = _Gorevi;
            Resim = _Resim;

            if(Şifre == _SifreTekrar)
            {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kullanici values('"+ AdiSoyadi1 + "','" + Telefon1 + "','" + Ades+ "','" + Email + "','" + Kullaniciadi + "','" + Şifre + "','" + Gorevi + "','" + Resim + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show(" Yeni Kullanıcı eklendi","Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" Şifreler Uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

    }
        



    }
}
