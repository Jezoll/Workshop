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
    public partial class Rozliczenie : Form
    {
        Naprawy naprawy;

    public Rozliczenie()
        {
            InitializeComponent();
            foreach (Mechanicy m in Mechanicy.Mechanik)
                comboBox1.Items.Add(m);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        void rozli(Mechanicy Mechanik)
        {
            {
                decimal suma = 0;
                foreach (Naprawy naprawy in Naprawy.naprawy)
                    if (naprawy.Mechanik == Mechanik)
                   {
                        
                        decimal napr = naprawy.KosztCz + (naprawy.liczbagodz * naprawy.Mechanik.Stawka);
                        suma = suma + napr;
                        
                    }
                label3.Text = "Suma napraw wynosi:" + suma.ToString(); 
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rozli((Mechanicy)comboBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
};
