using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void Take()
        {
            int[] numeros = { 5, 4, 1, 3, 9, 8, 7, 2, 0 };
            var resultado = from num in numeros.Take(5) select num;

            int[] teste = { 5, 4, 1, 3, 9 };

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }
    }
}
