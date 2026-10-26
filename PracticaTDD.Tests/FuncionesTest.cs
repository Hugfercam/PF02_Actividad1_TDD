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

        [TestMethod]
        public void EsContrasenyaValida_Nula_DevuelveFalse()
        {
            Funciones funciones = new Funciones();

            bool resultado = funciones.EsContrasenyaValida(null!);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_Vacia_DevuelveFalse()
        {
            Funciones funciones = new Funciones();

            bool resultado = funciones.EsContrasenyaValida("");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_SieteCaracteresConAlmohadilla_DevuelveFalse()
        {
            Funciones funciones = new Funciones();

            bool resultado = funciones.EsContrasenyaValida("abcdef#");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_OchoCaracteresSinAlmohadilla_DevuelveFalse()
        {
            Funciones funciones = new Funciones();

            bool resultado = funciones.EsContrasenyaValida("abcdefgh");

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_OchoCaracteresConAlmohadilla_DevuelveTrue()
        {
            Funciones funciones = new Funciones();

            bool resultado = funciones.EsContrasenyaValida("abcdefg#");

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void EsContrasenyaValida_MasDeOchoCaracteresConAlmohadilla_DevuelveTrue()
        {
            Funciones funciones = new Funciones();

            bool resultado = funciones.EsContrasenyaValida("abcd#efghij");

            Assert.IsTrue(resultado);
        }
    }
}