using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lenguaje_tarea_2
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private async void Calcularbutton_Click(object sender, EventArgs e)
        {
            decimal parcial1 = Convert.ToDecimal(Parcial1textBox.Text);
            decimal parcial2 = Convert.ToDecimal(Parcial2textBox.Text);
            decimal parcial3 = Convert.ToDecimal(Parcial3textBox.Text);
            decimal parcial4 = Convert.ToDecimal(Parcial4textBox.Text);


            decimal total = await PromedioAsync(parcial1, parcial2, parcial3, parcial4);

            Notalabel.Text = total.ToString();
            MessageBox.Show("El promedio es de: " + total);
            

        }

        private async Task <decimal> PromedioAsync (decimal parcial1, decimal parcial2, decimal parcial3, decimal parcial4)
        {

            decimal promedio = await Task.Run(() =>
            {
                decimal suma = parcial1 + parcial2 + parcial3 + parcial4;
                return suma / 4;
            });
            return promedio;
        }

        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            Parcial1textBox.Text = "";
            Parcial2textBox.Text = "";
            Parcial3textBox.Text = "";
            Parcial4textBox.Text = "";
            Notalabel.Text = "";
        }
    }
    
}
