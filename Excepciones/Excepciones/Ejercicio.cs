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
                Clases.Operaciones.DividirEnZero(nudNumero1.Value);
            }
            catch (DivideByZeroException ex)
            {
                lblError.Text = ex.Message + " No Puede Dividir en 0";
            }

        }
     
    }
}
