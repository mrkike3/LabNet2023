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
    
    public partial class EmpleadoConsulta : Form
    {
        private int entidadId;
        private EmpleadoServicio _empleadoServicio = new EmpleadoServicio();
        public EmpleadoConsulta()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var fAltaEmpleado = new AltaEmpleado();
            fAltaEmpleado.ShowDialog();
            ActualizarDatos(txtEmpleadoBuscar.Text);
        }

        private void EmpleadoConsulta_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = _empleadoServicio.GetAll();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
           //ActualizarDatos(dgvEmpleados, String.Empty);
        }

     

        public void ActualizarDatos( string cadenaBuscar)
        {
            dgvEmpleados.DataSource = _empleadoServicio.GetAll(cadenaBuscar);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var fModificarEmpleado = new ModificarEmpleado();
            fModificarEmpleado.ShowDialog();
            ActualizarDatos(txtEmpleadoBuscar.Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
    
           
            var fEliminarEmpleado = new EliminarEmpleado();
            fEliminarEmpleado.ShowDialog();
            ActualizarDatos(txtEmpleadoBuscar.Text);
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            var idSeleccionado = int.Parse(dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString());
            var nombreSeleccionado = dgvEmpleados.Rows[e.RowIndex].Cells[1].Value.ToString();
            var apellidoSeleccionado = dgvEmpleados.Rows[e.RowIndex].Cells[2].Value.ToString();
            var fModificarEmpleado = new ModificarEmpleado(idSeleccionado,nombreSeleccionado,apellidoSeleccionado);

            fModificarEmpleado.ShowDialog();
            ActualizarDatos(txtEmpleadoBuscar.Text);

        }

        private void txtEmpleadoBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarDatos(txtEmpleadoBuscar.Text);
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
          

        }
    }
}
