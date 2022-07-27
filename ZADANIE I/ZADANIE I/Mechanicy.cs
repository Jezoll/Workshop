using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADANIE_I
{
    class Mechanicy
    {
        public string Imie, Nazwisko;
        public decimal Stawka;
        public double Rok;

        static public List<Mechanicy> Mechanik = new List<Mechanicy>();
     
       

        public override string ToString()
        {
            return Imie + " " + Nazwisko + " (" + Stawka.ToString("0.00") + " zł/godz)";
        }
    }
}
