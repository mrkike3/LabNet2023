using labTaxi.Clases;
using labTaxi.Clases.omnibus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTaxi
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TaxiServicio.InicializadorDeListaTaxis();
            OmnibusServicio.InicializadorDeListaOmnibus();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}
