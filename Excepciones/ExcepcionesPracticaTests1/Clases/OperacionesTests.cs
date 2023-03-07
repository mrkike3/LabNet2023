using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Tests
{
    [TestClass()]
    public class OperacionesTests
    {
        [TestMethod()]
        public void DividirTest()
        {
            decimal nro1 = 10;
            decimal nro2 = 2;
            decimal resultadoEsperado = 5;

            decimal resultado = decimal.Parse(Operaciones.Dividir(nro1, nro2));

            Assert.AreEqual(resultadoEsperado, resultado);

        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirEnZeroTest()
        {
            decimal nro1 = 7;

            Operaciones.DividirEnZero(nro1);
        }
    }
}