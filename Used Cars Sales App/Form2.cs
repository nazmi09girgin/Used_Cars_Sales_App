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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) //Otomobil
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) //Motosiklet
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e) //Ticari Araç
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e) //Elektrikli Araç
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e) //İlan Arama
        {
            Form7 form7 = new Form7();
            form7.Show();

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e) //Hesabım
        {
            Form8 form8 = new Form8();
            form8.Show();

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e) //Çıkış Yap
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {               
                Application.Exit();
            }
        }
    }
}
