using Lab.Logic.Ejercicio4;
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
    public partial class Ejercicio4 : Form
    {   private Ejercicio4Logica _ejercicio4 = new Ejercicio4Logica();
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = _ejercicio4.Obtener();
        }
    }
}
