using ConsoleApp3.Data;
using ConsoleApp3.ErrorHandling;
using ConsoleApp3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Commands
{
    public class PrinterAdder
    {
        public void addPrinter()
        {
            bool checkingValue = false;
            int dataInput = 0;

            Console.WriteLine("Fill out the printer data");

            while (!checkingValue)
            {
                Console.WriteLine("Input the printers ID: ");

                checkingValue = int.TryParse(Console.ReadLine(), out dataInput);
                if (!checkingValue) 
                    Console.WriteLine("Invalid value entered");
                checkingValue = validate(dataInput);
            }

            Printer printer = new Printer();

            printer.PrinterId = dataInput;
            Console.WriteLine("Input printer Name: ");

            string stringDataInput = Console.ReadLine();
            printer.PrinterName = stringDataInput;
            
            Console.WriteLine("Input printer Description: ");
            printer.PrinterDescription = Console.ReadLine();
           
            Console.WriteLine("Input printer Location: ");
            printer.PrinterLocation = Console.ReadLine();

            bool createSuccess = PrinterRepository.CreatePrinter(printer);

            if (createSuccess == true)
                SuccesfullErrorMessage.printSuccesfullOperationMessage();
            else
                ErrorMessage.unsuccessfulOperationMessage();
        }
        private static bool validate(int number, int minRange = 0, int MaxRange = int.MaxValue)
        {
            if (number > minRange && number < MaxRange) { return true; }
            else { return false; }
        }
    }
}
