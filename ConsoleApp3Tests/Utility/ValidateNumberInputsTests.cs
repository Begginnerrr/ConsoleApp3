using ConsoleApp3.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3Tests.Utility
{
    [TestClass]
    public class ValidateNumberInputsTests
    {
        [TestMethod]
        public void TestValidInput()
        {
            int number = 5;
            int minRange = 0;
            int maxRange = 10;
            bool expected = true;

            bool result = ValidateNumberInput.validate(number, minRange, maxRange);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestInvalidInput()
        {
            int number = 11;
            int minRange = 0;
            int maxRange = 10;
            bool expected = false;

            bool result = ValidateNumberInput.validate(number, minRange, maxRange);

            Assert.AreEqual(expected, result);
        }

    }
}
