using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Utility
{
    public class PrinterProgress
    {
       
      // private DateTime startingAdjustedTime; // when printer starts printing item
       private DateTime endingtime = DateTime.Now;
        //private DateTime printertimetofinish;
        private bool PrinterConnection =true;

        public string askPrinterEndingTime()
        {
            try
            {
                PrinterEndingDate();
                // DateTime.TryParse(PrinterConnection.PrinterEndingDate(), out endingtime);
                return endingtime.ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        
        private void PrinterEndingDate()
        {
            if (PrinterConnection == true)
            {
                endingtime = DateTime.Now.AddSeconds(15);
                // return printertimetofinish.ToString();
            }
            else
            {
                Console.WriteLine("Printer connection is not established");
            }
            }
    }


}
