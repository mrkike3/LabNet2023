using Lab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic.Ejercicio10
{
    public class Ejercicio10Logica : InterfazLogica<Ejercicio10Dto>
    {
        public IEnumerable<Ejercicio10Dto> Obtener()
        {
            using(var context = new NorthWindContext())
            {
                return context.Products
                       .OrderByDescending(p => p.UnitsInStock)
                       .Select(p => new Ejercicio10Dto
                       {
                           Nombre = p.ProductName,
                           UnidadesEnStock = (int)p.UnitsInStock
                       }).ToList();
            }
        }
    }
}
