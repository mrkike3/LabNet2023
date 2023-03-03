using System.ComponentModel;
using System.Windows.Forms;

namespace labTaxi.Clases.omnibus
{
    public class OmnibusServicio
    {

        private static BindingList<Omnibus> _listaOmnibus;
        public static int nroOmnibus = 1;




        public static void InicializadorDeListaOmnibus()
        {
            if (_listaOmnibus == null)
            {
                _listaOmnibus = new BindingList<Omnibus>();
            }
        }

        public static BindingList<Omnibus> ObtenerListaOmnibus()
        {
            return _listaOmnibus;
        }




        public static void Agregar(int pasajeros)
        {
            if (nroOmnibus > 5)
            {
                
                MessageBox.Show("cantidad maxima de Omnibus");

                
                return;
            }

            var omnibus = new Omnibus();


            MessageBox.Show(omnibus.Avanzar() + $" con {pasajeros}");


            Omnibus nuevoOmnibus = new Omnibus
            {
                omnibus = nroOmnibus,
                pasajeros = pasajeros,

            };

            _listaOmnibus.Add(nuevoOmnibus);
            nroOmnibus++;

        }
    }
}
