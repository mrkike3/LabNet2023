using Excepciones.Clases;
using System;
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
                Logic.LanzarExcepcion();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Se generó una excepción de tipo " + ex.GetType().ToString(), ex.Message);
            }
        }
    }
}
