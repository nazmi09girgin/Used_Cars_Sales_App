using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public interface IArac
    {
        int AracId { get; set; }
        string Marka { get; set; }
        string Model { get; set; }
        string Yil { get; set; }
        int Kilometre { get; set; }
        string Vites { get; set; }
        string YakitTuru { get; set; }
        float Fiyat { get; set; }
        string Renk { get; set; }
        int MotorGucu { get; set; }
        int MotorHacmi { get; set; }
        string IlanTarihi { get; set; }

        void AracIdArttir();
        void AracIdAzalt();
        string AracBilgisi();
    }

}
