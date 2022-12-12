using ConsoleApp3.ErrorHandling;
using ConsoleApp3.Repository;
using ConsoleApp3.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Commands
{
    public class PrinterRemover
    {
        private bool checkingValue = false;
        private int dataInput;
        private bool createSuccess;

        public void deletePrinter()
        {
            DBItemChecker.getPrinterIdList();
            Console.WriteLine("Input the printers ID: ");
            while (!checkingValue)
            {
                checkingValue = int.TryParse(Console.ReadLine(), out dataInput);
                if (!checkingValue) Console.WriteLine("Invalid value entered");
                checkingValue = validate(dataInput);
            }

            createSuccess = PrinterRepository.DeletePost(dataInput);
            if (createSuccess == true)
            {
                SuccesfullErrorMessage.succesfullyExecutedOperation();
            }
            else
            {
                ErrorMessage.unsuccessfulOperationMessage();
            }
        }
        private static bool validate(int number, int minRange = 0, int MaxRange = int.MaxValue)
        {
            if (number > minRange && number < MaxRange) { return true; }
            else { return false; }
        }
    }
}
