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
    public class PrinterEditor { 


    Printer updatedPrinter = new Printer();
    private bool checkingValue = false;
    private int dataInput;
    private string stringDataInput;
    private bool createSuccess;
    public void editPrinter()
        {

            Console.WriteLine("Input the printers ID: ");
            while (!checkingValue)
            {
                checkingValue = int.TryParse(Console.ReadLine(), out dataInput);
                if (!checkingValue) Console.WriteLine("Invalid value entered");
                checkingValue = RangeValidation.validate(dataInput);
            }
            updatedPrinter = PrinterRepository.GetPrinterById(dataInput);
            if (updatedPrinter != null)
            {
                Console.WriteLine("Selected printer Stats");
                Console.WriteLine("Printer ID: " + updatedPrinter.PrinterId);
                Console.WriteLine("Printer Name: " + updatedPrinter.PrinterName);
                Console.WriteLine("Printer Description: " + updatedPrinter.PrinterDescription);
                Console.WriteLine("Printer Location: " + updatedPrinter.PrinterLocation);
                
                Console.WriteLine("Fill out printer data: ");
                Console.WriteLine("Input printer Name: ");
                stringDataInput = Console.ReadLine();
                updatedPrinter.PrinterName = stringDataInput;
                Console.WriteLine("Input printer Description: ");
                updatedPrinter.PrinterDescription = Console.ReadLine();
                Console.WriteLine("Input printer Location: ");
                updatedPrinter.PrinterLocation = Console.ReadLine();
                createSuccess = PrinterRepository.UpdatePrinter(updatedPrinter);
                if (createSuccess == true)
                {
                    Console.WriteLine("This was succesfull");
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                }
            }
            else
            {
                Console.WriteLine("Printer doesn't exist");
            }
        }
    }
}
