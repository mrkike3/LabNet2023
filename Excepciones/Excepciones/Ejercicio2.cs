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
                string resultado;
                resultado = Operaciones.Dividir(numero1, numero2);

                lblResultado.Text = resultado;

            }
            catch (DivideByZeroException ex)
            {

                lblResultado.Text = " Solo chuck divide en 0 Pa " + ex.Message;
            }
            catch (Exception ex)
            {
                lblResultado.Text = "No ingreso nada o ingreso un numero invalido";
            }
           
        }
    }
}
