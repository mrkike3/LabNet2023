using Lab.Logic;
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
    public partial class Ejercicio1 : Form
    {
        private Ejercicio1Logica _Ejercicio1Logica = new Ejercicio1Logica();
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
          dgvClientes.DataSource =  _Ejercicio1Logica.Obtener();

        }
    }
}
