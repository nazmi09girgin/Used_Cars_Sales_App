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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Minibüs - Otobüs");
            comboBox1.Items.Add("Kamyon - Kamyonet");

            comboBox2.Items.Add("Manuel");
            comboBox2.Items.Add("Otomatik");

            comboBox3.Items.Add("Benzin");
            comboBox3.Items.Add("Dizel");

            comboBox4.Items.Add("10+1 - 15+1");
            comboBox4.Items.Add("16+1 - 20+1");
            comboBox4.Items.Add("21+1 - 25+1");
            comboBox4.Items.Add("26+1 - 30+1");
            comboBox4.Items.Add("-");

            comboBox5.Items.Add("5000 - 10000");
            comboBox5.Items.Add("10000 - 20000");
            comboBox5.Items.Add("20000 - 30000");
            comboBox5.Items.Add("30000 - 40000");
            comboBox5.Items.Add("-");

            dataGridView1.ColumnCount = 15;
            dataGridView1.Columns[0].Name = "Araç ID";
            dataGridView1.Columns[1].Name = "Tür";
            dataGridView1.Columns[2].Name = "Marka";
            dataGridView1.Columns[3].Name = "Model";
            dataGridView1.Columns[4].Name = "Yıl";
            dataGridView1.Columns[5].Name = "Kilometre";
            dataGridView1.Columns[6].Name = "Vites";
            dataGridView1.Columns[7].Name = "Yakıt";
            dataGridView1.Columns[8].Name = "Renk";
            dataGridView1.Columns[9].Name = "Motor Gücü";
            dataGridView1.Columns[10].Name = "Motor Hacmi";
            dataGridView1.Columns[11].Name = "Koltuk Sayısı";
            dataGridView1.Columns[12].Name = "Yük Kapasitesi";
            dataGridView1.Columns[13].Name = "İlan Tarihi";
            dataGridView1.Columns[14].Name = "Fiyat";

        }
        //public List<TicariArac> TicariAracListesi = new List<TicariArac>();

        private void button1_Click(object sender, EventArgs e)
        {
            TicariArac ticari = new TicariArac();
            ticari.Tur = comboBox1.SelectedItem.ToString();
            ticari.Marka = textBox1.Text;
            ticari.Model = textBox2.Text;
            ticari.Yil = textBox3.Text;
            ticari.Kilometre = int.Parse(textBox4.Text);
            ticari.Vites = comboBox2.SelectedItem.ToString();
            ticari.YakitTuru = comboBox3.SelectedItem.ToString();
            ticari.Renk = textBox5.Text;
            ticari.MotorGucu = int.Parse(textBox6.Text);
            ticari.MotorHacmi = int.Parse(textBox7.Text);
            ticari.KoltukSayisi = comboBox4.SelectedItem.ToString();
            ticari.TasimaKapasitesi = comboBox5.SelectedItem.ToString();
            ticari.IlanTarihi = textBox8.Text;
            ticari.Fiyat = float.Parse(textBox9.Text);
            //TicariAracListesi.Add(ticari);
            Listeler.Instance.TicariAracListesi.Add(ticari);
            ticari.AracIdArttir();
            MessageBox.Show(ticari.AracBilgisi(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
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
            dataGridView1.Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                // Son satırı kaldır
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                if (Listeler.Instance.TicariAracListesi.Count > 0)
                {
                    Listeler.Instance.TicariAracListesi.RemoveAt(Listeler.Instance.TicariAracListesi.Count - 1);

                    // Önce liste boş mu diye kontrol et
                    if (Listeler.Instance.TicariAracListesi.Count > 0)
                    {
                        Listeler.Instance.TicariAracListesi[Listeler.Instance.TicariAracListesi.Count - 1].AracIdAzalt();
                    }
                    else
                    {
                        TicariArac.AracIdSayac = 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Silinecek bir satır bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
