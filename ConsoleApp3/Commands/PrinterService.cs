﻿using ConsoleApp3.AppConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp3.Utility;

namespace ConsoleApp3.Commands
{
    
    public class PrinterService
    {
        private string stringDataInput;
        private bool falsePath = false;
        private DateTime startingtime = DateTime.Now;
        private float timeRemainingSeconds;
        private DateTime endingtime;
        private bool timeup = false;

       
        public void pickingPrintFile()
        {
            listingAvailableFilesInDirectory();
            if (falsePath == false)
            {
                Console.WriteLine("Enter File name: ");
                stringDataInput = Console.ReadLine();
                if (stringDataInput != null && File.Exists(Configuration.printerFilesLocation + stringDataInput + ".g"))
                {
                    printfile(stringDataInput);
                }
                else
                {
                    Console.WriteLine("File doesn't exist");
                }
            }
           
        }
        private void listingAvailableFilesInDirectory()
        {

            try
            {
                if (Directory.Exists(Configuration.printerFilesLocation))
                {


                    Console.WriteLine("Listing available files in directory: ");
                    string[] fileArray = Directory.GetFiles(@Configuration.printerFilesLocation, "*.g");
                    foreach (string file in fileArray)
                    {
                        ColorManager.blueMessage(Path.GetFileName(file));

                    }
                }
                else
                {
                    Console.WriteLine("File path doesn't exist, please alter configuration file");
                    falsePath = true;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Unexpected error occured");
            }
        }

        private void printfile(String fileName)
        {
            try
            {
                PrinterProgress printerProgress = new PrinterProgress();
                DateTime.TryParse(printerProgress.askPrinterEndingTime(), out endingtime); 
            }
            catch (NullReferenceException ex) {
                Console.WriteLine("An error has been thrown" + ex);
            }

            Console.WriteLine("File detected: " + fileName);
            Console.WriteLine("Starting to print");
            Thread.Sleep(50);
            Console.WriteLine("Printing");

            while (!timeup)
            {
                timeRemainingSeconds = (float)(endingtime - startingtime).TotalSeconds;
                if (timeRemainingSeconds > 0)  Console.WriteLine("Time remaining " + timeRemainingSeconds);
                
                else   break;
                startingtime = DateTime.Now;
                Thread.Sleep(5000);
            }
            Console.WriteLine("Printing complete");
        }
    }
}
