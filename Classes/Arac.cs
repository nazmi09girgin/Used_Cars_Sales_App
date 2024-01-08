using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class Arac:IArac
    {
        public static int AracIdSayac = 1;
        public int AracId { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Yil { get; set; }
        public int Kilometre { get; set; }
        public string Vites { get; set; } 
        public string YakitTuru { get; set; } 
        public float Fiyat { get; set; }
        public string Renk {  get; set; }
        public int MotorGucu { get; set; } 
        public int MotorHacmi { get; set; } 
        public string IlanTarihi { get; set; }
      
        public void AracIdArttir()
        {
            AracId = AracIdSayac++;
        }
        public void AracIdAzalt()
        {
            AracId = AracIdSayac--;
        }
        public abstract string AracBilgisi();
    }
}
