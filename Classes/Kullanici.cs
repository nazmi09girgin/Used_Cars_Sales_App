using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Kullanici
    {
        public int KullaniciId { get; private set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Yas {  get; set; }
        public string TelefonNo { get; set; }

        private static int sonKullaniciId = 1;

        public Kullanici()
        {           
            KullaniciId = sonKullaniciId++;
        }

    }
}
