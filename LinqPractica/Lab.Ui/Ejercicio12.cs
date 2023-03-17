using Lab.Entities;
using Lab.Logic.Ejercicio12;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.Ui
{
    public partial class Ejercicio12 : Form
    {   private Ejercicio12Logica _ejercicio12Logica = new Ejercicio12Logica();
        public Ejercicio12()
        {
            InitializeComponent();
        }

        private void Ejercicio12_Load(object sender, EventArgs e)
        {
             Products p = _ejercicio12Logica.Obtener();
             label1.Text = p.ProductName +" " + p.UnitPrice;

          
        }
    }
}
