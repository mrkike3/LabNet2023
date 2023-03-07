using Excepciones.Clases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Practica2.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LanzarExcepcionTest()
        {
            Logic.LanzarExcepcion();
        }

        [TestMethod()]
        [ExpectedException(typeof(CustomException))]
        public void ThrowCustomExceptionTest()
        {
            Logic.ThrowCustomException();
        }
    }
}