using Lab.Logic.Ejercicio10;
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
    public partial class Ejercicio10 : Form
    {   private Ejercicio10Logica _ejercicio10Logica = new Ejercicio10Logica();
        public Ejercicio10()
        {
            InitializeComponent();
        }

        private void Ejercicio10_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = _ejercicio10Logica.Obtener();
        }
    }
}
