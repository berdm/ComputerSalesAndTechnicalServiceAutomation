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
    public partial class frmKullanıcıGirişi : Form
    {
        public frmKullanıcıGirişi()
        {
            InitializeComponent();
        }

        private void lblYeniKullanıcı_Click(object sender, EventArgs e)
        {
            frmYeniKullanici yk = new frmYeniKullanici();
            yk.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)
            {
                txtŞifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txtŞifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }


        }
        Classlar.Kullanici k = new Classlar.Kullanici();
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            k.KullaniciGirisi(txtŞifre, txtKullanıcıAdı);
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
