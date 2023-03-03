using System;

namespace labTaxi.Clases
{
    public class Taxis : TransportePublico
    {
        public override string Avanzar()
        {
            return "Taxi Avanza";
        }

        public override string Detenerse()
        {
            return "Taxis Detenidos";
        }
    }
}
