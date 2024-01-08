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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Kullancı ID";
            dataGridView1.Columns[1].Name = "Kullanıcı Adı";
            dataGridView1.Columns[2].Name = "Şifre";
            dataGridView1.Columns[3].Name = "Ad";
            dataGridView1.Columns[4].Name = "Soyad";
            dataGridView1.Columns[5].Name = "Yaş";
            dataGridView1.Columns[6].Name = "Telefon Numarası";

            foreach (Kullanici kullanici in Listeler.Instance.KullaniciListesi)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = kullanici.KullaniciId;
                row.Cells[1].Value = kullanici.KullaniciAdi;
                row.Cells[2].Value = kullanici.Sifre;
                row.Cells[3].Value = kullanici.Ad;
                row.Cells[4].Value = kullanici.Soyad;
                row.Cells[5].Value = kullanici.Yas;
                row.Cells[6].Value = kullanici.TelefonNo;
                dataGridView1.Rows.Add(row);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TextBox'tan ID'yi al
            if (int.TryParse(textBox1.Text, out int silinecekId))
            {
                // ID'ye göre kullanıcıyı bul ve sil
                Kullanici silinecekKullanici = Listeler.Instance.KullaniciListesi.FirstOrDefault(k => k.KullaniciId == silinecekId);

                if (silinecekKullanici != null)
                {
                    DialogResult sonuc = MessageBox.Show("Kullanıcıyı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (sonuc == DialogResult.Yes)
                    {
                        // Admin 'Evet' dediyse siliyoruz
                        Listeler.Instance.KullaniciListesi.Remove(silinecekKullanici);
                        MessageBox.Show("Kullanıcı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        YenileDataGridView();
                    }

                }
                else
                {
                    MessageBox.Show("Belirtilen ID'ye sahip bir kullanıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Geçersiz ID formatı. Lütfen bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void YenileDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (Kullanici kullanici in Listeler.Instance.KullaniciListesi)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = kullanici.KullaniciId;
                row.Cells[1].Value = kullanici.KullaniciAdi;
                row.Cells[2].Value = kullanici.Sifre;
                row.Cells[3].Value = kullanici.Ad;
                row.Cells[4].Value = kullanici.Soyad;
                row.Cells[5].Value = kullanici.Yas;
                row.Cells[6].Value = kullanici.TelefonNo;
                dataGridView1.Rows.Add(row);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
