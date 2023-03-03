using labTaxi.Clases.omnibus;
using System.ComponentModel;
using System.Windows.Forms;

namespace labTaxi.Clases
{
    public class TaxiServicio
    {
        
        private static BindingList<Taxis> _listaTaxis;

        private static int NumeroTaxis = 1;

        private const int CantidadMaximaTaxis = 5;

        private static BindingList<Omnibus> _listaOmnibus;

        private static int NumeroOmnibus = 1;

        private const int CantidadMaximaOmnibus = 5;






        public static void InicializadorDeListaTaxis()
        {
            if (_listaTaxis == null)
            {
                _listaTaxis = new BindingList<Taxis>();
            }
        }

        public static BindingList<Taxis> ObtenerListaTaxi()
        {
            return _listaTaxis;
        }



        public static bool Agregar(int pasajeros)
        {

            bool CargaFinalizada = false;

            if (NumeroTaxis > CantidadMaximaTaxis)
            {

                CargaFinalizada = true;
                return CargaFinalizada;
   
            }

            //var taxis = new Taxis();


            //MessageBox.Show(taxis.Avanzar() + $" con {pasajeros} pasajeros");

            Taxis nuevoTaxi = new Taxis
            {
                taxi = NumeroTaxis,
                pasajeros = pasajeros,

            };

            _listaTaxis.Add(nuevoTaxi);
            NumeroTaxis++;

            return false;

        }


  


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
}
