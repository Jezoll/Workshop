using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADANIE_I
{



    class Naprawy
    {
        public string nr_rej;
        public decimal liczbagodz;
        public Mechanicy Mechanik;
        public decimal KosztCz;
        public DateTime data;
        public static List<Naprawy> naprawy = new List<Naprawy>();




        public decimal Robocizna()
        {
            return KosztCz + liczbagodz * Mechanik.Stawka;
            }
    } }
