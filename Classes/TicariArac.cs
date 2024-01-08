using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class TicariArac:Arac
    {
        public string Tur {  get; set; } //combobox ile kamyonet, minibüs(otobüs)
        public string TasimaKapasitesi {  get; set; } // 5000kg gibi
        public string KoltukSayisi { get; set; }
        public override string AracBilgisi()
        {
            return "Ticari Araç ilanı oluşturuldu.";
        }

    }
}
