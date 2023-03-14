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
            try
            {
                var nuevoEmpleado = new EmpleadoDto
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                };

                _empleadoServicio.Insertar(nuevoEmpleado);

                MessageBox.Show("Empleado Guardado con Exito");
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor llene todo los campos");

            }       
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
