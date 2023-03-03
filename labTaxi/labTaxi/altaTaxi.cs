using labTaxi.Clases;
using labTaxi.Clases.omnibus;
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

        const int maxPasajeros = 4;

        public altaTaxi()
        { 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nudPasajeros.Value > maxPasajeros)
            {
                MessageBox.Show("La Cantidad maxima de Pasajeros Permitida es 4");
                return;
            }

            bool CargaFinalizada = TaxiServicio.Agregar((int)nudPasajeros.Value);

            if (CargaFinalizada == true)
            {
                MessageBox.Show("Cantidad Maxima de Taxis Alcanzada (5)");
                return;
            }
          

            
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
