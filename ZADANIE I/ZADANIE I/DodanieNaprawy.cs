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
    public partial class DodanieNaprawy : Form
    {
       Naprawy naprawy;
        

       internal DodanieNaprawy(Naprawy naprawy)
            
        {
            InitializeComponent();
            this.naprawy = naprawy;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Mechanicy m in Mechanicy.Mechanik)
                comboBox1.Items.Add(m);


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            naprawy.nr_rej = (string)textBox1.Text;
            naprawy.data = dateTimePicker1.Value;
            naprawy.Mechanik = (Mechanicy)comboBox1.SelectedItem;
            naprawy.KosztCz = numericUpDown1.Value;
            naprawy.liczbagodz = numericUpDown2.Value;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
               
            }
        }

        private void anuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
