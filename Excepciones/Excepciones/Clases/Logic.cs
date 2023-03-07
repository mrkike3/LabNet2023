using System;

namespace Excepciones.Clases
{
    public static class Logic
    {
        public static void LanzarExcepcion()
        {
            try
            {
                throw new ArgumentOutOfRangeException();
            }
            catch (Exception)
            {

                throw;
            }
           
        }


        public static void ThrowCustomException()
        {
            try
            {
                throw new CustomException(" Mensaje Sobrecargado");
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }

    
}
