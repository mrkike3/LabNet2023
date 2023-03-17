using Lab.Logic.Ejercicio8;
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
    public partial class Ejercicio8 : Form
    {
        private Ejercicio8Logica _ejercicio8Logica = new Ejercicio8Logica();
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void Ejercicio8_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = _ejercicio8Logica.Obtener();
        }
    }
}
