using Lab.Logic.Ejercicio11;
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
    public partial class Ejercicio11 : Form
    {   private Ejercicio11Logica _ejercicio11logica = new Ejercicio11Logica();
        public Ejercicio11()
        {
            InitializeComponent();
        }

        private void Ejercicio11_Load(object sender, EventArgs e)
        {

            dgvCategorias.DataSource = _ejercicio11logica.Obtener();

        }
    }
}
