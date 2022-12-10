using ConsoleApp3.Data;
using ConsoleApp3.ErrorHandling;
using ConsoleApp3.Repository;
using ConsoleApp3.Validations;
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
        Printer printer = new Printer();
        private bool checkingValue = false;
        private int dataInput;
        private string stringDataInput;
        private bool createSuccess;


        public void addPrinter()
        {
            Console.WriteLine("Fill out the printer data");
            while (!checkingValue)
            {
                Console.WriteLine("Input the printers ID: ");
                checkingValue = int.TryParse(Console.ReadLine(), out dataInput);
                if (!checkingValue) Console.WriteLine("Invalid value entered");
                checkingValue = validate(dataInput);
            }
            printer.PrinterId = dataInput;
            Console.WriteLine("Input printer Name: ");
           
            stringDataInput = Console.ReadLine();
            printer.PrinterName = stringDataInput;
            
            Console.WriteLine("Input printer Description: ");
            printer.PrinterDescription = Console.ReadLine();
           
            Console.WriteLine("Input printer Location: ");
            printer.PrinterLocation = Console.ReadLine();
            createSuccess = PrinterRepository.CreatePrinter(printer);
            if (createSuccess == true)
            {
                SuccesfullErrorMessage.printSuccesfullOperationMessage();
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
