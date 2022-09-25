using ConsoleApp3.Repository;
using ConsoleApp3.Validations;
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
            Console.WriteLine("Input the printers ID: ");
            while (!checkingValue)
            {
                checkingValue = int.TryParse(Console.ReadLine(), out dataInput);
                if (!checkingValue) Console.WriteLine("Invalid value entered");
                checkingValue = RangeValidation.validate(dataInput);
            }

            createSuccess = PrinterRepository.DeletePost(dataInput);
            if (createSuccess == true)
            {
                Console.WriteLine("This was succesfull");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
