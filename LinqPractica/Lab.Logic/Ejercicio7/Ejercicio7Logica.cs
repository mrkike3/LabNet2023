using Lab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic.Ejercicio7
{
    public class Ejercicio7Logica : InterfazLogica<Ejercicio7Dto>
    {
        public IEnumerable<Ejercicio7Dto> Obtener()
        {
            DateTime fechaOrden = new DateTime(1997, 1, 1);

            using (var context = new NorthWindContext())
            {
                var query = context.Customers.Where(c => c.Region == "WA")
                              .Join(context.Orders,
                                    c => c.CustomerID,
                                    o => o.CustomerID,
                                    (c, o) => new { Customer = c, Order = o })
                              .Where(co => co.Order.OrderDate > fechaOrden)
                              .Select(co => new Ejercicio7Dto
                              {
                                  Nombre = co.Customer.ContactName,
                                  Region = co.Customer.Region,
                                  Fecha = (DateTime)co.Order.OrderDate
                              })
                              .ToList();
                return query;
            }
        }
    }
}
