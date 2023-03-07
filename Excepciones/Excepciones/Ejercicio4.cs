using Excepciones.Clases;
using System;
using System.Windows.Forms;

namespace Excepciones
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btnThrowCustomException_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.ThrowCustomException();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\nTipo de excepcion: " + ex.GetType().ToString());
            }
        }
    }
}
