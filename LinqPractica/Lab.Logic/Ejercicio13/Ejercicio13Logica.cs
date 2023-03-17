using Lab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic.Ejercicio13
{
    public class Ejercicio13Logica : InterfazLogica<Ejercicio13Dto>
    {
        public IEnumerable<Ejercicio13Dto> Obtener()
        {

            using (var context = new NorthWindContext())
            {


                var customerOrderCounts = context.Customers
                   .Join(context.Orders, c => c.CustomerID, o => o.CustomerID, (c, o) 
                    => new { Customer = c, Order = o })
                   .GroupBy(co => co.Customer.CompanyName)
                   .Select(g => new Ejercicio13Dto
                   {
                           ClienteNombre = g.Key,
                           Pedidos = g.Count()

                   }).ToList();

                 return customerOrderCounts;

            }
        }
    }
}
