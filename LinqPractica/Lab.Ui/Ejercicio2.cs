using Lab.Logic.Ejercicio2;
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
    public partial class Ejercicio2 : Form
    {
        private Ejercicio2Logica _ejercicio2Logica = new Ejercicio2Logica();

        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = _ejercicio2Logica.Obtener();
        }
    }
}
