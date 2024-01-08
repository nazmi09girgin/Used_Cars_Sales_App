using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // Listeler sınıfını, listeleri tek bir yerde yönetmek için kullandık.
    public class Listeler
    {
        public List<Kullanici> KullaniciListesi { get; set; }  = new List<Kullanici>();
        public List<Otomobil> OtomobilListesi { get; set; } = new List<Otomobil>();       
        public List<Motosiklet> MotosikletListesi { get; set; } = new List<Motosiklet>();
        public List<TicariArac> TicariAracListesi { get; set; } = new List<TicariArac>();
        public List<ElektrikliArac> ElektrikliAracListesi { get; set; } = new List<ElektrikliArac>();
        
        private static Listeler instance;
       
        private Listeler() { }
       
        public static Listeler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Listeler();
                }
                return instance;
            }
        }
    }

}
