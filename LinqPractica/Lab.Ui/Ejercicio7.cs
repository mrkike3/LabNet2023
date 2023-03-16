using Lab.Logic.Ejercicio7;
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
    public partial class Ejercicio7 : Form
    {
        private Ejercicio7Logica _ejercicio7logica = new Ejercicio7Logica();
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void Ejercicio7_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = _ejercicio7logica.Obtener();
        }
    }
}
