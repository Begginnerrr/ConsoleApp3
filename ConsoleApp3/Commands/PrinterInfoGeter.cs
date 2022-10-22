using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Commands
{
    public class PrinterInfoGeter
    {
        private string status = "active";
        private int currentFilament = 30;

      public void printerStatus()
        {
            Console.WriteLine("Printer status: "+ status);
            Console.WriteLine("Printer filament: "+currentFilament +"%");
        }
    }
}
