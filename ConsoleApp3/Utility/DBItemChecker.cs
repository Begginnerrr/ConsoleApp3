using ConsoleApp3.Data;
using ConsoleApp3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Utility
{
    public static class DBItemChecker
    {
        public static void getPrinterIdList()
        {
            List<Printer> listofPrintersIds = PrinterRepository.GetPrinters();
            foreach (Printer prnt in listofPrintersIds)
            {
                Console.WriteLine("Printer ID: " + prnt.PrinterId + " || " + "Printer Name: " + prnt.PrinterName);
                Console.WriteLine("");
            }
        }
    }
}
