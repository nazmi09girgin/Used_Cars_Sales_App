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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Manuel");
            comboBox1.Items.Add("Yarı otomatik");
            comboBox1.Items.Add("Otomatik");

            comboBox2.Items.Add("Benzin");

            comboBox3.Items.Add("Tek Silindir");
            comboBox3.Items.Add("Çift Silindir");
            comboBox3.Items.Add("3 Silindir");
            comboBox3.Items.Add("4 Silindir");
            comboBox3.Items.Add("6 Silindir");

            dataGridView1.ColumnCount = 13;
            dataGridView1.Columns[0].Name = "Araç ID";
            dataGridView1.Columns[1].Name = "Marka";
            dataGridView1.Columns[2].Name = "Model";
            dataGridView1.Columns[3].Name = "Yıl";
            dataGridView1.Columns[4].Name = "Kilometre";
            dataGridView1.Columns[5].Name = "Vites";
            dataGridView1.Columns[6].Name = "Yakıt";
            dataGridView1.Columns[7].Name = "Motor Gücü";
            dataGridView1.Columns[8].Name = "Motor Hacmi";
            dataGridView1.Columns[9].Name = "Silindir";
            dataGridView1.Columns[10].Name = "Renk";
            dataGridView1.Columns[11].Name = "İlan Tarihi";
            dataGridView1.Columns[12].Name = "Fiyat";
        }
        //public List<Motosiklet> MotosikletListesi = new List<Motosiklet>();
        private void button1_Click(object sender, EventArgs e)
        {
            Motosiklet motosiklet = new Motosiklet();
            motosiklet.Marka = textBox1.Text;
            motosiklet.Model = textBox2.Text;
            motosiklet.Yil = textBox3.Text;
            motosiklet.Kilometre = int.Parse(textBox4.Text);
            motosiklet.Vites = comboBox1.SelectedItem.ToString();
            motosiklet.YakitTuru = comboBox2.SelectedItem.ToString();
            motosiklet.MotorGucu = int.Parse(textBox5.Text);
            motosiklet.MotorHacmi = int.Parse(textBox6.Text);
            motosiklet.SilindirSayisi = comboBox3.SelectedItem.ToString();
            motosiklet.Renk = textBox5.Text;
            motosiklet.IlanTarihi = textBox8.Text;
            motosiklet.Fiyat = float.Parse(textBox9.Text);
            //MotosikletListesi.Add(motosiklet);
            Listeler.Instance.MotosikletListesi.Add(motosiklet);
            motosiklet.AracIdArttir();
            MessageBox.Show(motosiklet.AracBilgisi(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
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
            dataGridView1.Rows.Add(row);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 1)
            {
                // Son satırı kaldır
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                if (Listeler.Instance.MotosikletListesi.Count > 0)
                {
                    Listeler.Instance.MotosikletListesi.RemoveAt(Listeler.Instance.MotosikletListesi.Count - 1);

                    // Önce liste boş mu diye kontrol et
                    if (Listeler.Instance.MotosikletListesi.Count > 0)
                    {
                        Listeler.Instance.MotosikletListesi[Listeler.Instance.MotosikletListesi.Count - 1].AracIdAzalt();
                    }
                    else
                    {
                        Motosiklet.AracIdSayac = 1;
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
