using System.ComponentModel;
using System.Windows.Forms;

namespace labTaxi.Clases
{
    public class TaxiServicio
    {
        
        private static BindingList<Taxis> _listaTaxis;

        public static int nroTaxis = 1;
       



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



        public static void Agregar(int pasajeros)
        {
            if (nroTaxis > 5)
            {
               
                MessageBox.Show("Cantidad Maxima de Taxis");


                return;
            }




            var taxis = new Taxis();


            MessageBox.Show(taxis.Avanzar() + $" con {pasajeros}");

            Taxis nuevoTaxi = new Taxis
            {
                taxi = nroTaxis,
                pasajeros = pasajeros,

            };

            _listaTaxis.Add(nuevoTaxi);
            nroTaxis++;

        }

    }
}
