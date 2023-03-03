using labTaxi.Clases.omnibus;
using labTaxi.Clases.Servicios;
using System;
using System.Windows.Forms;

namespace labTaxi
{
    public partial class altaOmnibus : Form
    {
        public altaOmnibus()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (nudPasajeros.Value > 30)
            {
                MessageBox.Show("La Cantidad maxima de Pasajeros Permitida es 30");
                return;
            }

            if (nudPasajeros.Value <= 0)
            {
                MessageBox.Show("La Cantidad Minima de Pasajeros Permitida es 1");
                return;
            }

            if (TransporteServicio.VerifcarCantidad(""))
            {
                MessageBox.Show("Carga Maxima de Colectivos Alcanzada (5)");
            }
            else
            {
                TransporteServicio.AgregarTransporte("", (int)nudPasajeros.Value);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
