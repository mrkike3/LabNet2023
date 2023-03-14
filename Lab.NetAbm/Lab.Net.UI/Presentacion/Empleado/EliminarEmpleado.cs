using Lab.Net.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.Net.UI.Presentacion
{
    public partial class EliminarEmpleado : Form
    {
        private EmpleadoServicio _empleadoServicio = new EmpleadoServicio();
        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _empleadoServicio.Eliminar(nudEmpleadoEliminado.Value);

            MessageBox.Show("Pecho la eliminacion");
            
        }
    }
}
