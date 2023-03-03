using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTaxi.Clases.omnibus
{
    public class Omnibus : TransportePublico
    {
        public int omnibus { get; set; }

        public override string Avanzar()
        {
            return "Omnibus avanza";
        }

        public override string Detenerse()
        {
            return "Omnibuses detenidos";
        }
    }
}
