using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
            number = 0;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A Gradebook", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A Gradebook";
        }


        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Scott";
            //String is a reference type
            string name2 = "scott";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
            //struct type
        }
        [TestMethod]
        public void IntVariablesHoldValue()
        {
//this is a value because it's a stored value instead of a pointer
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);

        }
        [TestMethod]
        public void VariablesHoldAReference()
        {
//this is a reference as it points to something versus being assigned something
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Yuchin's Gradebook";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
