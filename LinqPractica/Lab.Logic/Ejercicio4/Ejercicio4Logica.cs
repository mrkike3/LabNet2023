using Lab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic.Ejercicio4
{
    public class Ejercicio4Logica : InterfazLogica<Ejercicio4Dto>
    {
        public IEnumerable<Ejercicio4Dto> Obtener()
        {
            using (var context = new NorthWindContext())
            {
                var query = from c in context.Customers
                            where c.Region == "WA"
                            select new Ejercicio4Dto()
                            {
                                Nombre = c.CompanyName,
                                Region = c.Region
                            };
                return query.ToList();
            }
        }
    }
}
