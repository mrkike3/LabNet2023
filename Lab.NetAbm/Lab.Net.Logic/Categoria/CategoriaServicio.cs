using Lab.Net.Data;
using Lab.Net.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Net.Logic.Categoria
{
    public class CategoriaServicio : IlogicABM<CategoriaDto>
    {
        

        public void Eliminar(decimal Id)
        {
            using (var context = new NorthWindContext())
            {
                var categoriaEliminada = context.Categories
                    .FirstOrDefault(x => x.CategoryID == Id);

                context.Categories.Remove(categoriaEliminada);

                context.SaveChanges();

            }
        }

        public IEnumerable<CategoriaDto> GetAll(string cadenaBuscar="")
        {
            using (var context = new NorthWindContext())
            {
                return context.Categories

                     .Where(x => x.CategoryName.Contains(cadenaBuscar))

                     .Select(x => new CategoriaDto
                     {
                         Id = x.CategoryID,
                         Nombre = x.CategoryName,
                         Descripcion = x.Description

                     }).ToList();
            }
        }

        public long Insertar(CategoriaDto dto)
        {
            using (var context = new NorthWindContext())
            {
                var categoriaNueva = new Categories()
                {
                    CategoryName  = dto.Nombre,
                    Description = dto.Descripcion


                };

                context.Categories.Add(categoriaNueva);

                context.SaveChanges();
                return categoriaNueva.CategoryID;
            }
        }

        public void Modificar(CategoriaDto dto)
        {
            using (var context = new NorthWindContext())
            {
                var categoriaModificar = context.Categories
                    .FirstOrDefault(x => x.CategoryID == dto.Id);

                if (categoriaModificar == null)
                    throw new Exception("La categoria no existe");

                categoriaModificar.CategoryName = dto.Nombre;
                categoriaModificar.Description = dto.Descripcion;

                context.SaveChanges();
            }
        }
    }
}
