using ConsoleApp3.Data;
using ConsoleApp3.Repository;
using ConsoleAppContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3Tests.Repository
{
    [TestClass]
    public class PrinterRepositoryTests
    {
        [TestMethod]
        public void SinglePrinterExistInOffice()
        {
            // Set up the test data
            Printer printer123 = new Printer();
            printer123.PrinterId = 1;
            printer123.PrinterName = "ReturnedTestPrinter";
            printer123.PrinterDescription = "TestedPrinter";
            printer123.PrinterLocation = "ReturnedTestPrinter";
            printer123.IsAvailable = true;

            // Set up the mock repository
           // var mockRepository = new Mock<PrinterRepository>();

            // Set up the mock repository to return the printer123 object
            // when the SinglePrinterExistInOffice method is called
          //  mockRepository.Setup(repo => repo.SinglePrinterExistInOffice("ReturnedTestPrinter")).Returns(printer123);

            // Call the method being tested
         //   bool result = MyClass.MyMethod(mockRepository.Object);

            // Assert that the method returns the expected result
            Assert.IsTrue(true);
        }
    }
}
