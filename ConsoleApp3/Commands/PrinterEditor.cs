using ConsoleApp3.Data;
using ConsoleApp3.ErrorHandling;
using ConsoleApp3.Repository;
using ConsoleApp3.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp3.Commands
{
    public class PrinterEditor { 


    Printer updatedPrinter = new Printer();
    private bool checkingValue = false;
    private int dataInput;
    private bool createSuccess;
    public void editPrinter()
        {
            DBItemChecker.getPrinterIdList();
            Console.WriteLine("Input the printers ID: ");
            while (!checkingValue)
            {
                checkingValue = int.TryParse(Console.ReadLine(), out dataInput);
                if (!checkingValue) Console.WriteLine("Invalid value entered");
                checkingValue = ValidateNumberInput.validate(dataInput);
                if (!checkingValue) Console.WriteLine("Invalid value entered");
            }
            updatedPrinter = PrinterRepository.GetPrinterById(dataInput);
            if (updatedPrinter != null)
            {

                Console.WriteLine("Printer ID: " + updatedPrinter.PrinterId);
                Console.WriteLine("Edit printer name: ");
                SendKeys.SendWait(updatedPrinter.PrinterName);
                updatedPrinter.PrinterName = Console.ReadLine();
                

                Console.WriteLine("Edit printer Description: ");
                SendKeys.SendWait(updatedPrinter.PrinterDescription);
                updatedPrinter.PrinterDescription = Console.ReadLine();

                Console.WriteLine("Edit printer Location: ");
                SendKeys.SendWait(updatedPrinter.PrinterLocation);
                updatedPrinter.PrinterLocation = Console.ReadLine();

                createSuccess = PrinterRepository.UpdatePrinter(updatedPrinter);
                
                if (createSuccess == true)
                {
                    SuccesfullErrorMessage.succesfullyExecutedOperation();
                }
                else
                {
                    ErrorMessage.unsuccessfulOperationMessage();
                }
            }
            else
            {
                Console.WriteLine("Printer doesn't exist");
            }
        }
    }
   
}
