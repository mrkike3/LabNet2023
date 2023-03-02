using labTaxi.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTaxi
{
    public partial class altaTaxi : Form
    {

       
        public altaTaxi()
        { 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TaxiServicio.Agregar((int)nudPasajeros.Value);
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
