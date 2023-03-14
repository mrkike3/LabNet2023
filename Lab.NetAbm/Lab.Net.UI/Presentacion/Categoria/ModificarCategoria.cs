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
    public partial class ModificarCategoria : Form
    {   private CategoriaServicio _categoriaServicio = new CategoriaServicio();

        public ModificarCategoria(long id, string nombre, string descripcion)
        {
            InitializeComponent();

            nudCategoriaModificar.Value = id;
            nudCategoriaModificar.Enabled = false;

            txtNombreModificar.Text = nombre;

            txtDescripcionModificar.Text = descripcion;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                var categoriaModificar = new CategoriaDto()
                {
                    Id = (long)nudCategoriaModificar.Value,
                    Nombre = txtNombreModificar.Text,
                    Descripcion = txtDescripcionModificar.Text
                };

                _categoriaServicio.Modificar(categoriaModificar);
                MessageBox.Show("La modificacion se realizo con exito");
                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Por Favor llene todos los campos");
            }


        }

        private void txtNombreModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtDescripcionModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
