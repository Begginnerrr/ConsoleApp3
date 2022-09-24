using ConsoleApp3.Data;
using ConsoleApp3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Menu
    {
    }

    public class DrawMenu    {

        private bool exit = false;
        private bool checkingValue;
        private int commandInput;
        private int dataInput;
        private string stringDataInput;

        public void drawingMenu()
        {
            Console.WriteLine("1 - List out the printers");
            Console.WriteLine("2 - List printer by ID");
            Console.WriteLine("3 - Add printers");
            Console.WriteLine("4 - Edit printer Details");
            Console.WriteLine("5 - Start Printing");
            Console.WriteLine("6 - Exit the program");
            Console.WriteLine("Type in the command number into a console: ");
        }

        public void startProgram()
        {
           

            while (exit == false)
            {
                Console.WriteLine("Input the command: ");
                checkingValue = int.TryParse(Console.ReadLine(), out commandInput);
                if (!checkingValue) Console.WriteLine("Invalid value entered");
                switch (commandInput)
                {
                    case 1:
                        Console.WriteLine("Listing all Printers");
                        List<Printer> listofPrinters = PrinterRepository.GetPrinters();
                        foreach (Printer prnt in listofPrinters)
                        {
                            Console.WriteLine("Printer ID: "+prnt.PrinterId);
                            Console.WriteLine("Printer Name: "+prnt.PrinterName);
                            Console.WriteLine("Printer Description: "+prnt.PrinterDescription);
                            Console.WriteLine("Printer Location :"+prnt.PrinterLocation);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Input the printers ID: ");
                        checkingValue = int.TryParse(Console.ReadLine(), out dataInput);
                        if (!checkingValue) Console.WriteLine("Invalid value entered");
                        Printer print = PrinterRepository.GetPrinterById(dataInput);
                        Console.WriteLine("Selected printer Stats");
                        Console.WriteLine("Printer ID: " + print.PrinterId);
                        Console.WriteLine("Printer Name: " + print.PrinterName);
                        Console.WriteLine("Printer Description: " + print.PrinterDescription);
                        Console.WriteLine("Printer Location :" + print.PrinterLocation);
                        break;
                    case 3:
                        Printer printer1 = new Printer();
                        Console.WriteLine("Fill out the printer data");
                        Console.WriteLine("Input printer ID: ");
                        checkingValue = int.TryParse(Console.ReadLine(), out dataInput);
                        if (!checkingValue) Console.WriteLine("Invalid value entered");
                        printer1.PrinterId = dataInput;
                        Console.WriteLine("Input printer Name: ");
                        stringDataInput = Console.ReadLine();
                        printer1.PrinterName = stringDataInput;
                        Console.WriteLine("Input printer Description: ");
                        printer1.PrinterDescription = Console.ReadLine();
                        Console.WriteLine("Input printer Location: ");
                        printer1.PrinterLocation = Console.ReadLine();
                        bool createSuccess =  PrinterRepository.CreatePrinter(printer1);
                        if (createSuccess == true)
                        {
                            Console.WriteLine("This was succesfull");
                        }
                        else
                        {
                            Console.WriteLine("Something went wrong");
                        }
                        break;
                    default:
                        Console.WriteLine("Selected command doesn't exist");
                        break;
                }
            }
        }
    }
}
