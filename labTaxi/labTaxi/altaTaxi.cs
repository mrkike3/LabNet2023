using labTaxi.Clases;
using labTaxi.Clases.omnibus;
using labTaxi.Clases.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTaxi
{
    public partial class altaTaxi : Form
    {

        const int MaxPasajeros = 4;

        public altaTaxi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nudPasajeros.Value > MaxPasajeros)
            {
                MessageBox.Show("La Cantidad maxima de Pasajeros Permitida es 4");
                return;
            }
            if (nudPasajeros.Value <= 0)
            {
                MessageBox.Show("La Cantidad Minima de Pasajeros Permitida es 1");
                return;
            }

            if (!TransporteServicio.VerifcarCantidad("Taxi"))
            {
                TransporteServicio.AgregarTransporte("Taxi", (int)nudPasajeros.Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cantidad Maxima de Taxis Alcanzada (5)");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
