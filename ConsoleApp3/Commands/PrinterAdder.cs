﻿using ConsoleApp3.Data;
using ConsoleApp3.Repository;
using ConsoleApp3.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Commands
{
    public class PrinterAdder
    {
        Printer printer = new Printer();
        private bool checkingValue = false;
        private int dataInput;
        private string stringDataInput;
        private bool createSuccess;


        public void addPrinter()
        {
            Console.WriteLine("Fill out the printer data");
            while (!checkingValue)
            {
                Console.WriteLine("Input the printers ID: ");
                checkingValue = int.TryParse(Console.ReadLine(), out dataInput);
                if (!checkingValue) Console.WriteLine("Invalid value entered");
                checkingValue = RangeValidation.validate(dataInput);
            }
            printer.PrinterId = dataInput;
            Console.WriteLine("Input printer Name: ");
            Console.WriteLine("");
            stringDataInput = Console.ReadLine();
            printer.PrinterName = stringDataInput;
            Console.WriteLine("Input printer Description: ");
            Console.WriteLine("");
            printer.PrinterDescription = Console.ReadLine();
            Console.WriteLine("Input printer Location: ");
            Console.WriteLine("");
            printer.PrinterLocation = Console.ReadLine();
            createSuccess = PrinterRepository.CreatePrinter(printer);
            if (createSuccess == true)
            {
                Console.WriteLine("This was succesfull");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }

    }
}
