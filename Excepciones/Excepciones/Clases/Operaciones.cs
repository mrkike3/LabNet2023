using System;

namespace Excepciones.Clases
{
	public class Operaciones
	{
		public static void DividirEnZero(decimal nro1)
		{
			const int divisor = 0;

			decimal division;


			

			if(divisor == 0)
			{
				try
				{
                    division = nro1 / divisor;
                }
				catch (Exception)
				{

					throw new DivideByZeroException();
				}
			}

		} 


		public static string Dividir(decimal num1, decimal num2)
		{
			decimal resultado;
			
				 resultado = num1 / num2;

				return resultado.ToString();
		
		}

		


    }
}
