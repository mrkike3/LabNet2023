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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

      

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            TaxiServicio.cargarLista();
            OmnibusServicio.cargarLista();

            var taxis = TaxiServicio.ObtenerListaTaxi();
            dgvTaxi.DataSource = taxis;

            var omnibus = OmnibusServicio.ObtenerListaOmnibus();
            dgvOmnibus.DataSource = omnibus;

            btnCargarTaxi.Enabled = true;
            btnCargarOmnibus.Enabled = true;

            btnMostrar.Enabled = false;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fAltaTaxi = new altaTaxi();

            fAltaTaxi.ShowDialog();

           


        }

        private void btnCargarOmnibus_Click(object sender, EventArgs e)
        {
            var fAltaOmnibus = new altaOmnibus();
            fAltaOmnibus.ShowDialog();
        }
    }
}
