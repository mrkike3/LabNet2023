using Lab.Logic.Ejercicio13;
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
    public partial class Ejercicio13 : Form
    {
        private Ejercicio13Logica _ejercicio13Logica = new Ejercicio13Logica();
        public Ejercicio13()
        {
            InitializeComponent();
        }

        private void Ejercicio13_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = _ejercicio13Logica.Obtener();

        }
    }
}
