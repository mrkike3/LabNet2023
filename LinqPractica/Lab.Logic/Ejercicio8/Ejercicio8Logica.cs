using Lab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic.Ejercicio8
{
    public class Ejercicio8Logica : InterfazLogica<Ejercicio8Dto>
    {
        public IEnumerable<Ejercicio8Dto> Obtener()
        {
            using(var context = new NorthWindContext())
            {
                var query = (from c in context.Customers
                             where c.Region == "WA"
                             select new Ejercicio8Dto
                             {
                                 Nombre = c.CompanyName,
                                 Region = c.Region
                             }).Take(3).ToList();

                return query;
                           
            }
        }
    }
}
