using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaTelefonicaMaicol;
using System;
using Xunit.Sdk;

namespace TestPruebaTelefonica
{
    [TestClass]
    public class PruebaUnitariaTelefonica
    {
        [TestMethod]
        public void ListarFibonacciTest()
        {
            Pruebas pruebas = new Pruebas();
            try
            {
                pruebas.ListarFibonacci(10);
            }
            catch (ArgumentOutOfRangeException e)
            {

                StringAssert.Contains(e.Message, "Prueba Fallida");
                return;
            }
        }

        [TestMethod]
        public void CalcularFormulaCuadraticaTest()
        {
            Pruebas pruebas = new Pruebas();
            try
            {
                pruebas.CalcularFormulaCuadratica();
            }
            catch (ArgumentOutOfRangeException e)
            {

                StringAssert.Contains(e.Message, "Prueba Fallida");
                return;
            }
        }
    }


}
