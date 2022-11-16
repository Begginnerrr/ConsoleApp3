using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Utility
{
    public class PrinterProgress
    {
       private DateTime endingtime = DateTime.Now;
        private bool PrinterConnection =true;

        public string askPrinterEndingTime()
        {
            try
            {
                PrinterEndingDate();
                return endingtime.ToString();
            }
            catch (Exception ex) 
            {
                return null; 
            } 

            }


        
        private void PrinterEndingDate()
        {
            if (PrinterConnection == true) endingtime = DateTime.Now.AddSeconds(15);
            else Console.WriteLine("Printer connection is not established");
        }
    }


}
