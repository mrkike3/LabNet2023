using System;

namespace Excepciones.Clases
{
	public  class Operaciones
    {
        public static void DividirEnZero(decimal nro1)
        {
			const int divisor = 0;

			decimal division;

			try
			{
				division = nro1/divisor;

		    }
			catch (DivideByZeroException ex)
			{

				throw;


			}

}


		public static string Dividir(decimal num1, decimal num2)
		{
			decimal resultado;
			try
			{
				 resultado = num1 / num2;

				return resultado.ToString();

			}
			catch (DivideByZeroException)
			{

				throw;
			}
			catch(Exception ex)
			{
				throw;
			}
		}

		public static void LanzarExcepcion()
		{
			throw new ArgumentOutOfRangeException();
		}



    }
}
