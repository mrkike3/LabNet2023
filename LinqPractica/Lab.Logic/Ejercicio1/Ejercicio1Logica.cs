using Lab.Data;
using Lab.Logic.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic
{
    public class Ejercicio1Logica : InterfazLogica<Ejercicio1Dto>
    {
        public IEnumerable<Ejercicio1Dto> Obtener()
        {
            using(var context = new NorthWindContext())
            {
                return context.Customers

                    .AsNoTracking()
                    .Select(c => new Ejercicio1Dto
                    {
                      
                        Nombre = c.CompanyName

                    }).Take(1).ToList();
            }
        }
    }
}
