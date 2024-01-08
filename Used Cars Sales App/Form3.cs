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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sedan");
            comboBox1.Items.Add("Hatchback");
            comboBox1.Items.Add("SUV");
            comboBox1.Items.Add("Pick-up");
            comboBox1.Items.Add("Cabrio");

            comboBox2.Items.Add("Manuel");
            comboBox2.Items.Add("Yarı otomatik");
            comboBox2.Items.Add("Otomatik");

            comboBox3.Items.Add("Benzin");
            comboBox3.Items.Add("LPG");
            comboBox3.Items.Add("Dizel");
            comboBox3.Items.Add("Hybrid");

            dataGridView1.ColumnCount = 13;
            dataGridView1.Columns[0].Name = "Araç ID";
            dataGridView1.Columns[1].Name = "Marka";
            dataGridView1.Columns[2].Name = "Model";
            dataGridView1.Columns[3].Name = "Kasa Tipi";
            dataGridView1.Columns[4].Name = "Yıl";
            dataGridView1.Columns[5].Name = "Kilometre";
            dataGridView1.Columns[6].Name = "Vites";
            dataGridView1.Columns[7].Name = "Yakıt Türü";
            dataGridView1.Columns[8].Name = "Renk";
            dataGridView1.Columns[9].Name = "Motor Gücü";
            dataGridView1.Columns[10].Name = "Motor Hacmi";
            dataGridView1.Columns[11].Name = "İlan Tarihi";
            dataGridView1.Columns[12].Name = "Fiyat";
        }
        //public List<Otomobil> OtomobilListesi = new List<Otomobil>();
        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil otomobil = new Otomobil();
            otomobil.Marka = textBox1.Text;
            otomobil.Model = textBox2.Text;
            otomobil.KasaTipi = comboBox1.SelectedItem.ToString();
            otomobil.Yil = textBox3.Text;
            otomobil.Kilometre = int.Parse(textBox4.Text);
            otomobil.Vites = comboBox2.SelectedItem.ToString();
            otomobil.YakitTuru = comboBox3.SelectedItem.ToString();
            otomobil.Renk = textBox5.Text;
            otomobil.MotorGucu = int.Parse(textBox6.Text);
            otomobil.MotorHacmi = int.Parse(textBox7.Text);
            otomobil.IlanTarihi = textBox8.Text;
            otomobil.Fiyat = float.Parse(textBox9.Text);
            Listeler.Instance.OtomobilListesi.Add(otomobil);
            otomobil.AracIdArttir();
            MessageBox.Show(otomobil.AracBilgisi(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
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
            dataGridView1.Rows.Add(row);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                // Son satırı siliyoruz
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                if (Listeler.Instance.OtomobilListesi.Count > 0)
                {
                    Listeler.Instance.OtomobilListesi.RemoveAt(Listeler.Instance.OtomobilListesi.Count - 1);

                    if (Listeler.Instance.OtomobilListesi.Count > 0)
                    {
                        Listeler.Instance.OtomobilListesi[Listeler.Instance.OtomobilListesi.Count - 1].AracIdAzalt();
                    }
                    else
                    {
                        Otomobil.AracIdSayac = 1;
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
