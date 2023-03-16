using Lab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic.Ejercicio5
{
    public class Ejercicio5Logica 
    {
        public string Obtener()
        {
            using (var context = new NorthWindContext())
            {
                var query = context.Products.FirstOrDefault(p => p.ProductID == 8000);

                if (query != null)
                {
                    return query.ProductName.ToString();
                }
                else
                {
                    return "No se encontro el producto";
                }


            }
        }
    }

}
