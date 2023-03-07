using System;
using System.Windows.Forms;

namespace Excepciones
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fEjercicio1 = new Ejercicio();
            fEjercicio1.ShowDialog();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            var fEjercicio2 = new Ejercicio2();
            fEjercicio2.ShowDialog();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            var fEjercicio3 = new Ejercicio3();
            fEjercicio3.ShowDialog();
        }

        private void btnEjercicio4_Click(object sender, EventArgs e)
        {
            var fEjercicio4 = new Ejercicio4();
            fEjercicio4.ShowDialog();
        }
    }
}
