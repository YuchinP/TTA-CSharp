using System;
using Drill;
using Microsoft.VisualStudio.TestTools.UnitTesting;


//Value Type vs Reference Type
namespace Drill.Tests
{
    [TestClass]
    public class ValuevsReference
    {
        [TestMethod]
        public void referencetype()
        {
            Overs x1 = new Overs();
            Overs x2 = x1;

            x1 = new Overs();

            Assert.AreEqual(x1, x2);
        }
        [TestMethod]
        public void valuetype()
        {
            int y1 = 100;
            int y2 = y1;

            y1 = 200;
            Assert.AreNotEqual(y1, y2);
        }
    }
}
