using Lab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic.Ejercicio9
{
    public class Ejercicio9Logica : InterfazLogica<Ejercicio9Dto>
    {
        public IEnumerable<Ejercicio9Dto> Obtener()
        {
          using(var context = new NorthWindContext())
          {
                var query = (from p in context.Products
                             orderby p.ProductName
                             select new Ejercicio9Dto
                             {
                                 Nombre = p.ProductName,
                             }).ToList();

                return query;
          }
        }
    }
}
