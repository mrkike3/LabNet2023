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
            catch (Exception ex)
            {

                throw ex;
            }
           
        }


        public static void ThrowCustomException()
        {
            try
            {
                throw new CustomException(" Mensaje Sobrecargado");
            }
            catch (Exception ex )
            {

                throw ex;
            }
            
        }
    }

    
}
