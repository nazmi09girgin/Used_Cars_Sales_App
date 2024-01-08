using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Motosiklet:Arac
    {
        public string SilindirSayisi {  get; set; } //combobox ile yapılacak tek, çift, 3, 4, 6 silindir
        public override string AracBilgisi()
        {
            return "Motosiklet ilanı oluşturuldu.";
        }

    }
}
