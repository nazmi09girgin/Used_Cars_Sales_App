using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ElektrikliArac:Arac
    {
        public int Menzil { get; set; } //600 km gibi
        public string BataryaKapasitesi { get; set; } //75kWh gibi
        public string SarjHizi { get; set; } //250kW gibi
        public override string AracBilgisi()
        {
            return "Elektrikli Araç ilanı oluşturuldu";
        }

    }
}
