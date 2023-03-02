using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace labTaxi.Clases
{
    public class TaxiServicio
    {
        
        private static BindingList<Taxis> _listaTaxis;
        public static int idInc = 1;
        public static void cargarLista()
        {
            



            // agrega objetos a la lista
            _listaTaxis.Add(new Taxis { taxi = idInc++, pasajeros = 3 });
            _listaTaxis.Add(new Taxis { taxi = idInc++, pasajeros = 4 });
            _listaTaxis.Add(new Taxis { taxi = idInc++, pasajeros = 2 });
            _listaTaxis.Add(new Taxis { taxi = idInc++, pasajeros = 2 });
            _listaTaxis.Add(new Taxis { taxi =  idInc++, pasajeros = 1});

        }



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
            Taxis nuevoTaxi = new Taxis
            {
                taxi = idInc,
                pasajeros = pasajeros,

            };

            _listaTaxis.Add(nuevoTaxi);
            idInc++;

        }

    }
}
