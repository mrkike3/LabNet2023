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
    public partial class AltaEmpleado : Form
    {
        private EmpleadoServicio _empleadoServicio = new EmpleadoServicio();

        public AltaEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

           
            var nuevoEmpleado = new EmpleadoDto
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
            };

            _empleadoServicio.Insertar(nuevoEmpleado);

            MessageBox.Show("Pecho");

            
           

            
        }
    }
}
