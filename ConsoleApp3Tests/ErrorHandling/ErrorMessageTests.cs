using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestPlatform.CoreUtilities;
using ConsoleApp3.ErrorHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.ErrorHandling.Tests
{
    [TestClass]
    public class ErrorMessageTests
    {
        [TestMethod]
        public void unsuccessfulOperationMessageTest()
        {
            ErrorMessage.unsuccessfulOperationMessage();
            Assert.IsTrue(true);
        }
    }
}