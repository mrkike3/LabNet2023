using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.Net.Logic.Categoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Lab.Net.Data;
using Lab.Net.Entities;

namespace Lab.Net.Logic.Categoria.Tests
{
    [TestClass()]
    public class CategoriaServicioTests
    {
        [TestMethod()]
        public void ModificarTest()
        {

            var categoriaModificar = new CategoriaDto()
            {
                Id = 6,
                Nombre = "comidita",
                Descripcion = "fea"
            };

            var mock = new Mock<IlogicABM<CategoriaDto>>();

            mock.Setup(m => m.Modificar(It.IsAny<CategoriaDto>()))
                .Callback((CategoriaDto categories) =>
                categories.Nombre = "Bebidas");

            mock.Object.Modificar(categoriaModificar);

            Assert.AreEqual("Bebidas", categoriaModificar.Nombre);
        }
    }
}