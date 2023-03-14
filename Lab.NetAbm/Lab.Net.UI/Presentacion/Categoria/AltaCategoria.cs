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
    public partial class AltaCategoria : Form
    {
        private CategoriaServicio _categoriaServicio = new CategoriaServicio();

        public AltaCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

            var nuevaCategoria = new CategoriaDto
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text
            };

            _categoriaServicio.Insertar(nuevaCategoria);

            MessageBox.Show("Categoria Guardada con exito");
                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Por favor llene todos los campos obligatorios");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
