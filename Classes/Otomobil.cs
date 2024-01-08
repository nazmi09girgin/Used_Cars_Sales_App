using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Otomobil:Arac
    {
        public string KasaTipi {  get; set; } // Sedan, Hatchback, Station Wagon, SUV, Pick-up, Cabrio
        public override string AracBilgisi()
        {
            return "Otomobil ilanı oluşturuldu.";
        }

    }
}
