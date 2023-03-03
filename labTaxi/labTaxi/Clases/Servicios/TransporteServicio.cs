using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using labTaxi.Clases.omnibus;

namespace labTaxi.Clases.Servicios
{
    public class TransporteServicio
    {
        private static int cantidadTaxis = 1;
        private static int cantidadOmnibus = 1;
        private const int cantidadVehiculosMax = 5;
       

        private static BindingList<TransportePublico> _transporteList;

        public static BindingList<TransportePublico> TransportePublicos 
        { 
            get => _transporteList; set => _transporteList = value;
        }
        public static void InicializadorDeLista()
        {
            if (_transporteList == null)
            {
                _transporteList = new BindingList<TransportePublico>();
            }
        }

        public static bool VerifcarCantidad(string tipoTransporte)
        {
            return tipoTransporte == "Taxi"
                ? cantidadTaxis > cantidadVehiculosMax
                : cantidadOmnibus > cantidadVehiculosMax;
        }
        

        public static void AgregarTransporte(string tipoTransporte, int cantidadPasajeros)
        {
            if (tipoTransporte == "Taxi")
            {
                var taxi = new Taxis()
                {
                    Id = cantidadTaxis,
                    Pasajeros = cantidadPasajeros
                };

                _transporteList.Add(taxi);
                cantidadTaxis++;
            }
            else
            {
                var omnibus = new Omnibus()
                {
                    Id = cantidadOmnibus,
                    Pasajeros = cantidadPasajeros
                };

                _transporteList.Add(omnibus);
                cantidadOmnibus++;
            }
        }

        public static BindingList<TransportePublico> ObtenerTransportes(string tipoTransporte)
        {
            if (tipoTransporte == "Taxi")
            {
                var list = TransportePublicos.Where(x=>x.GetType() == typeof(Taxis)).ToList();
                return new BindingList<TransportePublico>(list);
            }
            else
            {
                var list = TransportePublicos.Where(x => x.GetType() == typeof(Omnibus)).ToList();
                return new BindingList<TransportePublico>(list);
            }
        }
    }
}
