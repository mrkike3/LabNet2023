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
                var query = from p in context.Customers
                            where p.Region == "WA"
                            select new Ejercicio4Dto()
                            {
                                Nombre = p.CompanyName,
                                Region = p.Region
                            };
                return query.ToList();
            }
        }
    }
}
