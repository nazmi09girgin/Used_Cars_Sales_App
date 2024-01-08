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

namespace Used_Cars_Sales_App
{
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Otomobil");
            comboBox1.Items.Add("Motosiklet");
            comboBox1.Items.Add("Ticari Araç");
            comboBox1.Items.Add("Elektrikli Araç");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            void AracAra()
            {
                // Seçilen araç tipine göre ilgili araç listesini al
                List<Arac> aracListesi = new List<Arac>();

                switch (comboBox1.SelectedIndex)
                {
                    case 0: // Otomobil
                        aracListesi = Listeler.Instance.OtomobilListesi.Cast<Arac>().ToList();
                        SetDataGridViewHeaders(new string[] { "Arac ID", "Marka", "Model", "Kasa Tipi", "Yıl", "Kilometre",
                            "Vites", "Yakıt Türü", "Renk", "Motor Gücü", "Motor Hacmi", "İlan Tarihi", "Fiyat" });
                        break;

                    case 1: // Motosiklet
                        aracListesi = Listeler.Instance.MotosikletListesi.Cast<Arac>().ToList();
                        SetDataGridViewHeaders(new string[] { "Arac ID", "Marka", "Model", "Yıl", "Kilometre", "Vites",
                            "Yakıt Türü", "Motor Gücü", "Motor Hacmi", "Silindir Sayısı", "Renk", "İlan Tarihi", "Fiyat" });
                        break;

                    case 2: // Ticari Araç
                        aracListesi = Listeler.Instance.TicariAracListesi.Cast<Arac>().ToList();
                        SetDataGridViewHeaders(new string[] { "Arac ID", "Tür", "Marka", "Model", "Yıl", "Kilometre", "Vites",
                            "Yakıt Türü", "Renk", "Motor Gücü", "Motor Hacmi", "Koltuk Sayısı", "Taşıma Kapasitesi", "İlan Tarihi", "Fiyat" });
                        break;

                    case 3: // Elektrikli Araç
                        aracListesi = Listeler.Instance.ElektrikliAracListesi.Cast<Arac>().ToList();
                        SetDataGridViewHeaders(new string[] { "Arac ID", "Marka", "Model", "Yıl", "Kilometre", "Vites",
                            "Yakıt Türü", "Menzil", "Batarya Kapasitesi", "Şarj Hızı", "Renk", "İlan Tarihi", "Fiyat" });
                        break;

                    default:
                        break;
                }

                // Marka ve model bilgilerine göre arama yap
                string marka = textBox1.Text;
                string model = textBox2.Text;

                List<Arac> sonucListesi = aracListesi.Where(a => a.Marka.Contains(marka) && a.Model.Contains(model)).ToList();

                dataGridView1.Rows.Clear();

                foreach (var arac in sonucListesi)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);

                    // Özel özelliklere göre hücreleri doldur
                    if (arac is Otomobil otomobil)
                    {
                        row.Cells[0].Value = otomobil.AracId;
                        row.Cells[1].Value = otomobil.Marka;
                        row.Cells[2].Value = otomobil.Model;
                        row.Cells[3].Value = otomobil.KasaTipi;
                        row.Cells[4].Value = otomobil.Yil;
                        row.Cells[5].Value = otomobil.Kilometre;
                        row.Cells[6].Value = otomobil.Vites;
                        row.Cells[7].Value = otomobil.YakitTuru;
                        row.Cells[8].Value = otomobil.Renk;
                        row.Cells[9].Value = otomobil.MotorGucu;
                        row.Cells[10].Value = otomobil.MotorHacmi;
                        row.Cells[11].Value = otomobil.IlanTarihi;
                        row.Cells[12].Value = otomobil.Fiyat;

                    }
                    else if (arac is Motosiklet motosiklet)
                    {
                        row.Cells[0].Value = motosiklet.AracId;
                        row.Cells[1].Value = motosiklet.Marka;
                        row.Cells[2].Value = motosiklet.Model;
                        row.Cells[3].Value = motosiklet.Yil;
                        row.Cells[4].Value = motosiklet.Kilometre;
                        row.Cells[5].Value = motosiklet.Vites;
                        row.Cells[6].Value = motosiklet.YakitTuru;
                        row.Cells[7].Value = motosiklet.MotorGucu;
                        row.Cells[8].Value = motosiklet.MotorHacmi;
                        row.Cells[9].Value = motosiklet.SilindirSayisi;
                        row.Cells[10].Value = motosiklet.Renk;
                        row.Cells[11].Value = motosiklet.IlanTarihi;
                        row.Cells[12].Value = motosiklet.Fiyat;
                    }
                    else if (arac is TicariArac ticari)
                    {
                        row.Cells[0].Value = ticari.AracId;
                        row.Cells[1].Value = ticari.Tur;
                        row.Cells[2].Value = ticari.Marka;
                        row.Cells[3].Value = ticari.Model;
                        row.Cells[4].Value = ticari.Yil;
                        row.Cells[5].Value = ticari.Kilometre;
                        row.Cells[6].Value = ticari.Vites;
                        row.Cells[7].Value = ticari.YakitTuru;
                        row.Cells[8].Value = ticari.Renk;
                        row.Cells[9].Value = ticari.MotorGucu;
                        row.Cells[10].Value = ticari.MotorHacmi;
                        row.Cells[11].Value = ticari.KoltukSayisi;
                        row.Cells[12].Value = ticari.TasimaKapasitesi;
                        row.Cells[13].Value = ticari.IlanTarihi;
                        row.Cells[14].Value = ticari.Fiyat;
                    }
                    else if (arac is ElektrikliArac elektrikli)
                    {
                        row.Cells[0].Value = elektrikli.AracId;
                        row.Cells[1].Value = elektrikli.Marka;
                        row.Cells[2].Value = elektrikli.Model;
                        row.Cells[3].Value = elektrikli.Yil;
                        row.Cells[4].Value = elektrikli.Kilometre;
                        row.Cells[5].Value = elektrikli.Vites;
                        row.Cells[6].Value = elektrikli.YakitTuru;
                        row.Cells[7].Value = elektrikli.Menzil;
                        row.Cells[8].Value = elektrikli.BataryaKapasitesi;
                        row.Cells[9].Value = elektrikli.SarjHizi;
                        row.Cells[10].Value = elektrikli.Renk;
                        row.Cells[11].Value = elektrikli.IlanTarihi;
                        row.Cells[12].Value = elektrikli.Fiyat;
                    }

                    dataGridView1.Rows.Add(row);
                }

                if (sonucListesi.Count == 0)
                {
                    MessageBox.Show("Arama sonucunda eşleşen bir araç bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            AracAra(); // AracAra fonksiyonunu çağırdık

        }
        private void SetDataGridViewHeaders(string[] headers)
        {
            // DataGridView başlıklarını elle ayarla
            dataGridView1.Columns.Clear();
            foreach (var header in headers)
            {
                dataGridView1.Columns.Add(header, header);
            }
        }
    }
}
