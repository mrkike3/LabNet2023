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

        public CategoriaConsulta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var fAltaCategoria = new AltaCategoria();
            fAltaCategoria.ShowDialog();
            ActualizarDatos(txtCategoriaBuscar.Text);
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
        }

        public void ActualizarDatos(string cadenaBuscar)
        {
            dgvCategorias.DataSource = _categoriaServicio.GetAll(cadenaBuscar);
        }

        private void txtCategoriaBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarDatos(txtCategoriaBuscar.Text);
        }
    }
}
