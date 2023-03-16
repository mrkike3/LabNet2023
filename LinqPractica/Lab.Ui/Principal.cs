using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.Ui
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fEjercicio1 = new Ejercicio1();
            fEjercicio1.ShowDialog();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fEjercicio2 = new Ejercicio2();
            fEjercicio2.ShowDialog();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fEjercicio3 = new Ejercicio3();
            fEjercicio3.ShowDialog();
            
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fEjercicio4 = new Ejercicio4();
            fEjercicio4.ShowDialog();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fEjercicio5 = new Ejercicio5();
            fEjercicio5.ShowDialog();
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fEjercicio7 = new Ejercicio7();
            fEjercicio7.ShowDialog();
        }
    }
}
