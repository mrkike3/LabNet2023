using Lab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic.Ejercicio3
{
    public class Ejercicio3Logica : InterfazLogica<Ejercicio3Dto>
    {
        public IEnumerable<Ejercicio3Dto> Obtener()
        {
         using(var context = new NorthWindContext())
            {
                var query = from p in context.Products
                            where p.UnitsInStock > 0 && p.UnitPrice > 3
                            
                            select new Ejercicio3Dto
                            {
                               
                                Nombre = p.ProductName,
                                Precio = (decimal)p.UnitPrice,
                                UnidadesEnStock = (int)p.UnitsInStock
                            };

                return query.ToList();
            }
            
        }
    }
}
