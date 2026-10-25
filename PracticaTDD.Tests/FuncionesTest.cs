using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticaTDD;

namespace PracticaTDD.Tests
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        public void CalcularFactorial_NumeroNegativo_DevuelveMenosUno()
        {
            Funciones funciones = new Funciones();

            long resultado = funciones.CalcularFactorial(-1);

            Assert.AreEqual(-1L, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Cero_DevuelveUno()
        {
            Funciones funciones = new Funciones();

            long resultado = funciones.CalcularFactorial(0);

            Assert.AreEqual(1L, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Uno_DevuelveUno()
        {
            Funciones funciones = new Funciones();

            long resultado = funciones.CalcularFactorial(1);

            Assert.AreEqual(1L, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Cinco_DevuelveCientoVeinte()
        {
            Funciones funciones = new Funciones();

            long resultado = funciones.CalcularFactorial(5);

            Assert.AreEqual(120L, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Trece_DevuelveFactorialLong()
        {
            Funciones funciones = new Funciones();

            long resultado = funciones.CalcularFactorial(13);

            Assert.AreEqual(6227020800L, resultado);
        }
    }
}