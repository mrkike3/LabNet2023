using Lab.Logic.Ejercicio9;
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
    public partial class Ejercicio9 : Form
    {   private Ejercicio9Logica _ejercicio9Logica = new Ejercicio9Logica();
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void Ejercicio9_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = _ejercicio9Logica.Obtener();
        }
    }
}
