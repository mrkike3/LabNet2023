using Excepciones.Clases;
using System;
using System.Windows.Forms;

namespace Excepciones
{
    public partial class Ejercicio : Form
    {
        public Ejercicio()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                Operaciones.DividirEnZero(nudNumero1.Value);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message + " \nNo Puede Dividir en 0";
       
            }
            finally
            {
                MessageBox.Show("Operacion Finalizada");
            }

        }
     
    }
}
