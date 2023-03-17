using Lab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic.Ejercicio11
{
    public class Ejercicio11Logica : InterfazLogica<Ejercicio11Dto>
    {
        public IEnumerable<Ejercicio11Dto> Obtener()
        {
           using(var context = new NorthWindContext())
            {
             var query = (from c in context.Categories
                 join p in context.Products on c.CategoryID equals p.CategoryID
                 select new Ejercicio11Dto
                 {
                   
                     Nombre = c.CategoryName
                 }).Distinct().ToList();

                return query;

            }
        }
    }
}
