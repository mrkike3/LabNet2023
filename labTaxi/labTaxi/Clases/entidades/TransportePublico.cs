using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTaxi.Clases
{
    

    public abstract class TransportePublico
    {
        public int Id { get; set; }
        public int Pasajeros { get; set; }
        public abstract string Avanzar();
        public abstract string Detenerse();
    }

}
 
    
