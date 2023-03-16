using Lab.Logic.Ejercicio3;
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
    public partial class Ejercicio3 : Form
    { 
        private Ejercicio3Logica _ejercicio3Logica = new Ejercicio3Logica();

        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = _ejercicio3Logica.Obtener();
        }
    }
}
