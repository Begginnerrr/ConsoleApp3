using ConsoleApp3.AppConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Commands
{
    
    public class PrinterService
    {
        private string stringDataInput;
       
        public void pickingPrintFile()
        {
            Console.WriteLine("Enter File name");
            stringDataInput =Console.ReadLine();
            if(stringDataInput != null && File.Exists(Configuration.printerFilesLocation+stringDataInput+".g"))
            {
                printfile(stringDataInput);
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }

        private void printfile(String fileName)
        {
            Console.WriteLine("File detected: " + fileName);
            Console.WriteLine("Starting to print");
            Thread.Sleep(50);
            Console.WriteLine("Printing");
            Thread.Sleep(400);
            Console.WriteLine("Printing complete");
        }
    }
}
