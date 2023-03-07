using Excepciones.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnLanzarExcepcion_Click(object sender, EventArgs e)
        {
            try
            {
                Operaciones.LanzarExcepcion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Se generó una excepción de tipo " + ex.GetType().ToString(), ex.Message);
            }
        }
    }
}
