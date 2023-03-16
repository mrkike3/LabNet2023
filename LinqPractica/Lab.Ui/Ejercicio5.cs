using Lab.Logic.Ejercicio5;
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
    public partial class Ejercicio5 : Form
    {
        private Ejercicio5Logica _ejercicio5Logica = new Ejercicio5Logica();
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void Ejercicio5_Load(object sender, EventArgs e)
        {
            label1.Text = _ejercicio5Logica.Obtener();
        }
    }
}
