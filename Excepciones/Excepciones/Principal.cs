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
    }
}
