using Excepciones.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Excepciones
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
           
            try
            {

                decimal numero1 = decimal.Parse(txtNumero1.Text);
                decimal numero2 = decimal.Parse(txtNumero2.Text);
                decimal resultado;
                resultado = Operaciones.Dividir(numero1, numero2);
                lblResultado.ForeColor = Color.White;
                lblResultado.Text = resultado.ToString();

            }
            catch (DivideByZeroException ex)
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = " Solo chuck divide \n  en 0 Pa " + ex.Message;
            }
            catch (Exception ex)
            {
                lblResultado.ForeColor = Color.Green;
                lblResultado.Text = "Seguro no ingresaste nada o \n le mandaste fruta con una letra";
            }
           
        }
    }
}
