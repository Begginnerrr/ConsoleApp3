﻿using ConsoleApp3.Data;
using ConsoleApp3.Repository;
using ConsoleApp3.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Commands
{
    public class ListAllPrinters
    {
        private bool checkingValue = false;
        private int dataInput;

        public void getallprinters()
        {
            Console.WriteLine("Listing all Printers");
            List<Printer> listofPrinters = PrinterRepository.GetPrinters();
            foreach (Printer prnt in listofPrinters)
            {
                Console.WriteLine("Printer ID: " + prnt.PrinterId);
                Console.WriteLine("Printer Name: " + prnt.PrinterName);
                Console.WriteLine("Printer Description: " + prnt.PrinterDescription);
                Console.WriteLine("Printer Location :" + prnt.PrinterLocation);
            }

        }

        public void getPrinterById()
        {
            Console.WriteLine("Input the printers ID: ");
            while (!checkingValue)
            {
                checkingValue = int.TryParse(Console.ReadLine(), out dataInput);
                if (!checkingValue) Console.WriteLine("Invalid value entered");
                checkingValue = RangeValidation.validate(dataInput);
            }
            Printer print = PrinterRepository.GetPrinterById(dataInput);
            if (print != null)
            {
                Console.WriteLine("Selected printer Stats");
                Console.WriteLine("Printer ID: " + print.PrinterId);
                Console.WriteLine("Printer Name: " + print.PrinterName);
                Console.WriteLine("Printer Description: " + print.PrinterDescription);
                Console.WriteLine("Printer Location :" + print.PrinterLocation);
            }
            else
            {
                Console.WriteLine("Printer doesn't exist");
            }
            }
}
}
