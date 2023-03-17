using Lab.Data;
using Lab.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Logic.Ejercicio12
{
    public class Ejercicio12Logica 
    {
        public Products Obtener()
        {
            using (var context = new NorthWindContext())
            {
                var query = context.Products.First();

                return query;



            }
        }
    }
}
