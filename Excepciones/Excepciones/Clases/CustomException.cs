using System;

namespace Excepciones.Clases
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base("Mensaje Base "+ message) { }

    }
}
