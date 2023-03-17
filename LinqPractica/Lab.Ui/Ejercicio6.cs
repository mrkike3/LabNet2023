using Lab.Logic.Ejercicio6;
using System;
using System.Windows.Forms;

namespace Lab.Ui
{
    public partial class Ejercicio6 : Form
    {   private Ejercicio6Logica _ejercicio6Logica = new Ejercicio6Logica();    
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void Ejercicio6_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = _ejercicio6Logica.Obtener();
        }
    }
}
