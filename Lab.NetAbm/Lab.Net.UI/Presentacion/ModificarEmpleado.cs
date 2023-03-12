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
    public partial class ModificarEmpleado : Form
    {
        private EmpleadoServicio _empleadoServicio = new EmpleadoServicio();
        public ModificarEmpleado()
        {
            InitializeComponent();
        }

        public ModificarEmpleado(int id /*string tipoOperacion*/)
        {

            InitializeComponent();
            nudEmpleadoModificar.Value = id;
            nudEmpleadoModificar.Enabled = false;
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var empleadoModificar = new EmpleadoDto()
            {
                Id = (long)nudEmpleadoModificar.Value,
                Nombre = txtNombreModificar.Text,
                Apellido = txtApellidoModificar.Text

            };

            _empleadoServicio.Modificar(empleadoModificar);
            MessageBox.Show("La modificacion pecho");

        }
    }
}
