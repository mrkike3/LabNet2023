using System.ComponentModel;
using System.Windows.Forms;

namespace labTaxi.Clases.omnibus
{
    public class OmnibusServicio
    {

        private static BindingList<Omnibus> _listaOmnibus;
        private static int NumeroOmnibus = 1;
        private const int CantidadMaximaOmnibus = 5;


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




        public static bool Agregar(int pasajeros)
        {
            bool CargaFinalizada = false;

            if (NumeroOmnibus > CantidadMaximaOmnibus)
            {

                CargaFinalizada = true;
                return CargaFinalizada;

            }


            Omnibus nuevoOmnibus = new Omnibus
            {
                omnibus = NumeroOmnibus,
                pasajeros = pasajeros,

            };

            _listaOmnibus.Add(nuevoOmnibus);
            NumeroOmnibus++;

            return false;

        }
    }
}
