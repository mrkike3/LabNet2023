using Lab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic.Ejercicio2
{
    public class Ejercicio2Logica : InterfazLogica<Ejercicio2Dto>
    {
         public IEnumerable<Ejercicio2Dto> Obtener()
        {
            using(var context = new NorthWindContext())
            {
                return context.Products
                    .Where(p => p.UnitsInStock == 0)
                    .Select(p => new Ejercicio2Dto()
                    {
                        
                        Nombre=p.ProductName,
                        UnidadesEnStock = (int)p.UnitsInStock

                    }).ToList();
                    
                                    
            }
         }

    }
}
