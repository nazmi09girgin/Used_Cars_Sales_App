using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Used_Cars_Sales_App
{
    public partial class Form8 : Form
    {
        private Kullanici seciliKullanici;

        public Form8()
        {
            InitializeComponent();

        }


        private void Form8_Load(object sender, EventArgs e)
        {
            KullaniciBilgileriniYukle();

        }

        private void KullaniciBilgileriniYukle()
        {
            //kullanici listesindeki ilk kullanıcı
            seciliKullanici = Listeler.Instance.KullaniciListesi.FirstOrDefault();

            if (seciliKullanici != null)
            {
                textBox1.Text = seciliKullanici.KullaniciAdi;
                textBox2.Text = seciliKullanici.Sifre;
                textBox3.Text = seciliKullanici.Ad;
                textBox4.Text = seciliKullanici.Soyad;
                textBox5.Text = seciliKullanici.Yas;
                textBox6.Text = seciliKullanici.TelefonNo;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yeniKullaniciAd = textBox1.Text;
            string yeniSifre = textBox2.Text;
            string yeniAd = textBox3.Text;
            string yeniSoyad = textBox4.Text;
            string yeniYas = textBox5.Text;
            string yeniTelefonNo = textBox6.Text;

            if (seciliKullanici.KullaniciAdi != yeniKullaniciAd || seciliKullanici.Sifre != yeniSifre || seciliKullanici.Ad != yeniAd || seciliKullanici.Soyad != yeniSoyad || seciliKullanici.Yas != yeniYas || seciliKullanici.TelefonNo != yeniTelefonNo)
            {
                seciliKullanici.KullaniciAdi = yeniKullaniciAd;
                seciliKullanici.Sifre = yeniSifre;
                seciliKullanici.Ad = yeniAd;
                seciliKullanici.Soyad = yeniSoyad;
                seciliKullanici.Yas = yeniYas;
                seciliKullanici.TelefonNo = yeniTelefonNo;

                MessageBox.Show("Kullanıcı bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                // Değişiklik yoksa, bilgilerde değişiklik yapmadığına dair bir mesaj kutusu
                MessageBox.Show("Herhangi bir değişiklik yapılmadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
