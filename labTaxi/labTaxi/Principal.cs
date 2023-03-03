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


     
        private void btnCargarOmnibus_Click(object sender, EventArgs e)
        {
            var fAltaOmnibus = new altaOmnibus();
            fAltaOmnibus.ShowDialog();





        }



        private void Principal_Load(object sender, EventArgs e)
        {
            var omnibus = OmnibusServicio.ObtenerListaOmnibus();
            dgvOmnibus.DataSource = omnibus;

            var taxi = TaxiServicio.ObtenerListaTaxi();
            dgvTaxi.DataSource = taxi;
        }

        private void btnDetenerOmnibuses_Click(object sender, EventArgs e)
        {
            btnCargarOmnibus.BackColor = Color.Black;

            var omnibus = new Omnibus();

            MessageBox.Show(omnibus.Detenerse());

            btnCargarOmnibus.Enabled = false;
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            btnCargarOmnibus.Enabled = true;
            btnCargarOmnibus.BackColor = Color.Gold;
        }

        private void btnHabilitarTaxis_Click(object sender, EventArgs e)
        {
            btnCargarTaxi.Enabled = true;
            btnCargarTaxi.BackColor = Color.Gold;
        }

        private void btnCargarTaxi_Click(object sender, EventArgs e)
        {
            var fAltaTaxi = new altaTaxi();

            fAltaTaxi.ShowDialog();

        }

        private void btnDetenerTaxis_Click(object sender, EventArgs e)
        {
            var omnibus = new Taxis();

            MessageBox.Show(omnibus.Detenerse());

            btnCargarTaxi.Enabled = false;
            btnCargarTaxi.BackColor = Color.Black;
        }
    }
}
