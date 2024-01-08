using Classes;

namespace Used_Cars_Sales_App
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //public List<Kullanici> KullaniciListesi = new List<Kullanici>();
        private void button1_Click(object sender, EventArgs e)
        {
            string yeniKullaniciAdi = textBox1.Text;

            // Ayn� kullan�c� ad�na sahip bir kay�t var m� bak�yoruz
            bool ayniKullaniciAdiVarMi = Listeler.Instance.KullaniciListesi.Any(k => k.KullaniciAdi == yeniKullaniciAdi);

            if (ayniKullaniciAdiVarMi)
            {
                MessageBox.Show("Bu kullan�c� ad� zaten al�nm��. L�tfen farkl� bir kullan�c� ad� se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Kullanici kullanici = new Kullanici();
            kullanici.KullaniciAdi = yeniKullaniciAdi;
            kullanici.Sifre = textBox2.Text;
            kullanici.Ad = textBox3.Text;
            kullanici.Soyad = textBox4.Text;
            kullanici.Yas = textBox5.Text;
            kullanici.TelefonNo = textBox8.Text;

            if (kullanici.KullaniciAdi.ToLower() == "admin")
            {
                MessageBox.Show("Admin kullan�c� ad�n� alamazs�n�z!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Listeler.Instance.KullaniciListesi.Add(kullanici);
            MessageBox.Show("Kay�t i�lemi ba�ar�l�.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string girilenKullaniciAdi = textBox6.Text;
            string girilenSifre = textBox7.Text;
            // Admin giri�i
            if (girilenKullaniciAdi.ToLower() == "admin" && girilenSifre == "12345")
            {
                MessageBox.Show("Admin kullan�c� giri�i ba�ar�l�. Ho� geldin Admin!");
                Form9 form9 = new Form9();
                form9.Show();
                return;
            }
            //Kullan�c� giri�i          
            Kullanici girisYapanKullanici = Listeler.Instance.KullaniciListesi.FirstOrDefault(k => k.KullaniciAdi == girilenKullaniciAdi && k.Sifre == girilenSifre);

            if (girisYapanKullanici != null)
            {
                MessageBox.Show($"Giri� ba�ar�l�. Ho� geldin {girisYapanKullanici.Ad.ToUpper()} {girisYapanKullanici.Soyad.ToUpper()}");
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}