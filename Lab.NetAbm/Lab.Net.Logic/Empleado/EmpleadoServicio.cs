using Lab.Net.Data;
using Lab.Net.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.Logic
{ 
    public class EmpleadoServicio : IlogicABM<EmpleadoDto> { 
    
        private NorthWindContext _northWindContext = new NorthWindContext();

        public EmpleadoServicio()
        {
            _northWindContext = new NorthWindContext();
        }

        public IEnumerable<EmpleadoDto> GetAll(string cadenaBuscar = "")
        {
            using (var context = new NorthWindContext())
            {
                return context.Employees

                     .Where(x => x.LastName.Contains(cadenaBuscar) || 
                     
                                 x.FirstName.Contains(cadenaBuscar))
                     
                     .Select(x => new EmpleadoDto
                     {
                         Id = x.EmployeeID,
                         Nombre = x.FirstName,
                         Apellido = x.LastName

                     }).ToList();
            }
        }

       

        public long Insertar(EmpleadoDto dto)
        {
            using (var context = new NorthWindContext())
            {
                var empleadoNuevo = new Employees()
                {
                    FirstName = dto.Nombre,
                    LastName = dto.Apellido


                };

                context.Employees.Add(empleadoNuevo);

                context.SaveChanges();
                return empleadoNuevo.EmployeeID;
            }
        }

        public void Modificar(EmpleadoDto dto)
        {
            using (var context = new NorthWindContext())
            {
                var empleadoModificar = context.Employees
                    .FirstOrDefault(x => x.EmployeeID == dto.Id);

                if (empleadoModificar == null)
                    throw new Exception("El empleado no existe");

                empleadoModificar.FirstName = dto.Nombre;
                empleadoModificar.LastName = dto.Apellido;

                context.SaveChanges();
            }
        }


        public void Eliminar(decimal Id)
        {
            using (var context = new NorthWindContext())
            {
                var empleadoEliminado = context.Employees
                    .FirstOrDefault(x => x.EmployeeID == Id);

                context.Employees.Remove(empleadoEliminado);



                context.SaveChanges();

            }


        }


    }
     
    
}
