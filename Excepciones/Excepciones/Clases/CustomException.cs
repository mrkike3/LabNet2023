using System;

namespace Excepciones.Clases
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base("Mensaje Base "+ message) { }


        //se sobrescribe la propieda message de la clase base si se comentara esta linea
        //se mostraria la el mensaje del constructor de arriba
        public override string Message => "Mi mensaje de excepcion " ;

    }
}
