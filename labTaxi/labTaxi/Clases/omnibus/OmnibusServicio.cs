using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTaxi.Clases.omnibus
{
    internal class OmnibusServicio
    {

        private static BindingList<Omnibus> _listaOmnibus;
        public static int idInc = 1;
        public static void cargarLista()
        {




            // agrega objetos a la lista
            _listaOmnibus.Add(new Omnibus { omnibus = idInc++, pasajeros = 30 });
            _listaOmnibus.Add(new Omnibus { omnibus = idInc++, pasajeros = 27});
            _listaOmnibus.Add(new Omnibus { omnibus = idInc++, pasajeros = 35});
            _listaOmnibus.Add(new Omnibus { omnibus = idInc++, pasajeros = 20});
            _listaOmnibus.Add(new Omnibus { omnibus = idInc++, pasajeros = 16});

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



        public static void Agregar(int pasajeros)
        {
            Omnibus nuevoOmnibus = new Omnibus
            {
                omnibus = idInc,
                pasajeros = pasajeros,

            };

            _listaOmnibus.Add(nuevoOmnibus);
            idInc++;

        }
    }
}
