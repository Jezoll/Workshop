using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZADANIE_I
{
    public partial class SpisNapraw : Form
    {
        Naprawy naprawy;

        
            
       


        public SpisNapraw()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Nr Rej";
            dataGridView1.Columns[1].Name = "Data";
            dataGridView1.Columns[2].Name = "Mechanik";
            dataGridView1.Columns[3].Name = "Koszt części";
            dataGridView1.Columns[4].Name = "Liczba godzin";
            dataGridView1.Columns[5].Name = "Robocizna";
            dataGridView1.Columns[2].Width = (200);
            dataGridView1.Columns[0].Width = (100);
            dataGridView1.Columns[1].Width = (200);

            InitializeComponent();
            Mechanicy m1 = new Mechanicy();
            m1.Imie = "Andrzej";
            m1.Nazwisko = "Wachacz";
           m1.Stawka = 50.0m;
            m1.Rok = 2020;
            Mechanicy.Mechanik.Add(m1);

            Mechanicy m2 = new Mechanicy();
            m2.Imie = "Janusz";
            m2.Nazwisko = "Resor";
            m2.Stawka = 50.0m;
            m2.Rok = 2019;
            Mechanicy.Mechanik.Add(m2);

          Mechanicy m3 = new Mechanicy();
            m3.Imie = "Zbysiu";
            m3.Nazwisko = "Pokrętło";
            m3.Stawka = 65.0m;
            m3.Rok = 2016;
           Mechanicy.Mechanik.Add(m3);

            Mechanicy m4 = new Mechanicy();
            m4.Imie = "Sławomir";
            m4.Nazwisko = "Grzechotka";
            m4.Stawka = 80.0m;
            m4.Rok = 2020;
           Mechanicy.Mechanik.Add(m4);
        }
        //public static Lista()
        //{ }
        void wyswietl()
        {
            
            dataGridView1.Rows.Clear();
            foreach (Naprawy naprawy in Naprawy.naprawy)
                dataGridView1.Rows.Add(naprawy.nr_rej, naprawy.data, naprawy.Mechanik, naprawy.KosztCz,
                    naprawy.liczbagodz, naprawy.Robocizna());
            
        }

        private void DodajNaprawe_Click(object sender, EventArgs e)
        {
            Naprawy nowa_naprawa = new Naprawy();
            DodanieNaprawy form = new DodanieNaprawy(nowa_naprawa);
            form.ShowDialog();
            Naprawy.naprawy.Add(nowa_naprawa);
            wyswietl();
        }

        private void RozliczeniePracPrzy_Click(object sender, EventArgs e)
        {
            Rozliczenie form = new Rozliczenie();
            form.ShowDialog();
        }
    }
}
