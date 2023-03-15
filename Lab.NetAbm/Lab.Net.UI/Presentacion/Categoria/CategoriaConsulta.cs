using Lab.Net.Logic;
using Lab.Net.Logic.Categoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.Net.UI.Presentacion.Categoria
{
    public partial class CategoriaConsulta : Form

    {
        private CategoriaServicio _categoriaServicio = new CategoriaServicio();
        private int EntidadId = 0;
        private string EntidadNombre;

        public CategoriaConsulta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var fAltaCategoria = new AltaCategoria();
            fAltaCategoria.ShowDialog();
            ActualizarDatos(txtCategoriaBuscar.Text);
            dgvCategorias.CurrentCell = null;
        }

        private void CategoriaConsulta_Load(object sender, EventArgs e)
        {
            dgvCategorias.DataSource = _categoriaServicio.GetAll();
        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idSeleccionado = int.Parse(dgvCategorias.Rows[e.RowIndex].Cells[0].Value.ToString());
            var nombreSeleccionado = dgvCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();
            var descripcionSeleccionada = dgvCategorias.Rows[e.RowIndex].Cells[2].Value.ToString();
            var fModificarEmpleado = new ModificarCategoria(idSeleccionado, nombreSeleccionado, descripcionSeleccionada);

            fModificarEmpleado.ShowDialog();
            ActualizarDatos(txtCategoriaBuscar.Text);
            EntidadId = 0;
            dgvCategorias.CurrentCell = null;
        }

        public void ActualizarDatos(string cadenaBuscar)
        {
            dgvCategorias.DataSource = _categoriaServicio.GetAll(cadenaBuscar);
        }

        private void txtCategoriaBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarDatos(txtCategoriaBuscar.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (EntidadId == 0)
            {
                MessageBox.Show("Por favor seleccione un registro para borrar");
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show($"¿Está seguro que desea Eliminar la Categoria {EntidadNombre}" +
                    " de Forma Permanente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _categoriaServicio.Eliminar(EntidadId);
                    ActualizarDatos(txtCategoriaBuscar.Text);
                    EntidadId = 0;
                    dgvCategorias.CurrentCell = null;
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ya elimino ese registro, seleccione otro");
            }
        }

      

        private void CategoriaConsulta_Shown(object sender, EventArgs e)
        {
            dgvCategorias.CurrentCell = null;
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idSeleccionado = Convert.ToInt32(dgvCategorias.Rows[e.RowIndex].Cells["ID"].Value);
                var nombreSeleccionado = dgvCategorias.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                this.EntidadId = idSeleccionado;
                this.EntidadNombre = nombreSeleccionado;

            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione una celda que contenga un registro");
            }
        }
    }
}
