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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Manuel");
            comboBox1.Items.Add("Otomatik");

            comboBox2.Items.Add("Elektrik");

            comboBox3.Items.Add("25 - 50");
            comboBox3.Items.Add("50 - 75");
            comboBox3.Items.Add("75 - 100");

            comboBox4.Items.Add("25 - 50");
            comboBox4.Items.Add("50 - 100");
            comboBox4.Items.Add("200 - 300");

            dataGridView1.ColumnCount = 13;
            dataGridView1.Columns[0].Name = "Araç ID";
            dataGridView1.Columns[1].Name = "Marka";
            dataGridView1.Columns[2].Name = "Model";
            dataGridView1.Columns[3].Name = "Yıl";
            dataGridView1.Columns[4].Name = "Kilometre";
            dataGridView1.Columns[5].Name = "Vites";
            dataGridView1.Columns[6].Name = "Yakıt";
            dataGridView1.Columns[7].Name = "Menzil";
            dataGridView1.Columns[8].Name = "Batarya Kapasitesi ";
            dataGridView1.Columns[9].Name = "Şarj Hızı";
            dataGridView1.Columns[10].Name = "Renk";
            dataGridView1.Columns[11].Name = "İlan Tarihi";
            dataGridView1.Columns[12].Name = "Fiyat";

        }
        //public List<ElektrikliArac> ElektrikliAracLİstesi = new List<ElektrikliArac>();
        private void button1_Click(object sender, EventArgs e)
        {
            ElektrikliArac elektrikli = new ElektrikliArac();
            elektrikli.Marka = textBox1.Text;
            elektrikli.Model = textBox2.Text;
            elektrikli.Yil = textBox3.Text;
            elektrikli.Kilometre = int.Parse(textBox4.Text);
            elektrikli.Vites = comboBox1.SelectedItem.ToString();
            elektrikli.YakitTuru = comboBox2.SelectedItem.ToString();
            elektrikli.Menzil = int.Parse(textBox5.Text);
            elektrikli.BataryaKapasitesi = comboBox3.SelectedItem.ToString();
            elektrikli.SarjHizi = comboBox4.SelectedItem.ToString();
            elektrikli.Renk = textBox6.Text;
            elektrikli.IlanTarihi = textBox7.Text;
            elektrikli.Fiyat = float.Parse(textBox8.Text);
            //ElektrikliAracLİstesi.Add(elektrikli);
            Listeler.Instance.ElektrikliAracListesi.Add(elektrikli);
            elektrikli.AracIdArttir();
            MessageBox.Show(elektrikli.AracBilgisi(), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
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
            dataGridView1.Rows.Add(row);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                // Son satırı kaldır
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                if (Listeler.Instance.ElektrikliAracListesi.Count > 0)
                {
                    Listeler.Instance.ElektrikliAracListesi.RemoveAt(Listeler.Instance.ElektrikliAracListesi.Count - 1);

                    // Önce liste boş mu diye kontrol et
                    if (Listeler.Instance.ElektrikliAracListesi.Count > 0)
                    {
                        Listeler.Instance.ElektrikliAracListesi[Listeler.Instance.ElektrikliAracListesi.Count - 1].AracIdAzalt();
                    }
                    else
                    {
                        ElektrikliArac.AracIdSayac = 1;
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
