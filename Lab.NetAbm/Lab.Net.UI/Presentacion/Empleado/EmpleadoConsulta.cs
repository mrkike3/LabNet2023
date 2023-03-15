using Lab.Net.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.Net.UI.Presentacion
{
    
    public partial class EmpleadoConsulta : Form
    {
        private int EntidadId = 0;
        private string EntidadNombre;
     
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
            dgvEmpleados.CurrentCell = null;
        }

        private void EmpleadoConsulta_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = _empleadoServicio.GetAll();       
        }

    
     

        public void ActualizarDatos( string cadenaBuscar)
        {
            dgvEmpleados.DataSource = _empleadoServicio.GetAll(cadenaBuscar);
        }

     

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if(EntidadId == 0)
            {
                MessageBox.Show("Por favor seleccione un registro para borrar");
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show($"¿Está seguro que desea Eliminar a {EntidadNombre}" +
                    " de Forma Permanente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _empleadoServicio.Eliminar(EntidadId);
                    ActualizarDatos(txtEmpleadoBuscar.Text);
                    EntidadId = 0;
                    dgvEmpleados.CurrentCell = null;
                }
                else
                {
                    return;
                }
            }

            catch(DbUpdateException)
            {
                MessageBox.Show("No tiene permisos para eliminar ese registro");
            }
            catch (Exception)
            {

                MessageBox.Show("Ya elimino ese registro, seleccione otro");
            }

                           
            
        }
        
        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

            var idSeleccionado = int.Parse(dgvEmpleados.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            var nombreSeleccionado = dgvEmpleados.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            var apellidoSeleccionado = dgvEmpleados.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            var fModificarEmpleado = new ModificarEmpleado(idSeleccionado,nombreSeleccionado,apellidoSeleccionado);

            fModificarEmpleado.ShowDialog();
            ActualizarDatos(txtEmpleadoBuscar.Text);
            dgvEmpleados.CurrentCell = null;
            EntidadId = 0;


        }

        private void txtEmpleadoBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarDatos(txtEmpleadoBuscar.Text);
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int idSeleccionado = Convert.ToInt32(dgvEmpleados.Rows[e.RowIndex].Cells["ID"].Value);
                var nombreSeleccionado = dgvEmpleados.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                this.EntidadId = idSeleccionado;
                this.EntidadNombre = nombreSeleccionado;

            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione una celda que contenga un registro");
            }
            

        }

        private void EmpleadoConsulta_Shown(object sender, EventArgs e)
        {
            dgvEmpleados.CurrentCell = null;
        }
    }
}
