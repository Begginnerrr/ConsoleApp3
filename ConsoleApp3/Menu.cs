using ConsoleApp3.Commands;
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
        private bool createSuccess;

        public void drawingMenu()
        {
            Console.WriteLine("1 - List out the printers");
            Console.WriteLine("2 - List printer by ID");
            Console.WriteLine("3 - Add printers");
            Console.WriteLine("4 - Edit printer Details");
            Console.WriteLine("5 - Delete printer");
            Console.WriteLine("6 - Start Printing");
            Console.WriteLine("7 - Exit the program");
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
                        ListAllPrinters listAllPrinters = new ListAllPrinters();
                        listAllPrinters.getallprinters();
                        break;
                    case 2:
                        ListAllPrinters listAllPrinters1 = new ListAllPrinters();
                        listAllPrinters1.getPrinterById();
                        break;
                    case 3:
                        PrinterAdder printerAdder = new PrinterAdder();
                        printerAdder.addPrinter();
                        
                        break;
                    case 4:
                        PrinterEditor printerEditor = new PrinterEditor();
                        printerEditor.editPrinter();
                        break;
                    case 5:
                        PrinterRemover printerRemover = new PrinterRemover();
                        printerRemover.deletePrinter();
                        break;
                    case 6:
                        PrinterService printerService = new PrinterService();
                        printerService.pickingPrintFile();
                        break;

                    case 7:

                        Console.WriteLine("Have a good day!");
                        Console.WriteLine("Program  will stop shortly");

                        exit = true;
                        Thread.Sleep(200);

                        break;
                    default:
                        Console.WriteLine("Selected command doesn't exist");
                        break;
                }
            }
        }
    }
}
