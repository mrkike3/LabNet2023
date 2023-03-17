using Lab.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic.Ejercicio6
{
    public class Ejercicio6Logica : InterfazLogica<Ejercicio6Dto>
    {
        public IEnumerable<Ejercicio6Dto> Obtener()
        {
            using(var context = new NorthWindContext())
            {
                return context.Customers
                       .Select(c => new Ejercicio6Dto
                       {
                           NombreMayuscula = c.CompanyName.ToUpper(),
                           NombreMinuscula = c.CompanyName.ToLower()

                       }).ToList();
            }
        }
    }
}
