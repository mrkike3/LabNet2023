using labTaxi.Clases.omnibus;
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
            bool CargaFinalizada = OmnibusServicio.Agregar((int)nudPasajeros.Value);

            if(CargaFinalizada == true)
            {
                MessageBox.Show("Carga Maxima de Colectivos Alcanzada (5)");
                
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
