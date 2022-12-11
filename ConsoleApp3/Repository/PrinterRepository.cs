﻿using ConsoleAppContext;
using ConsoleApp3.Data;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Common;

namespace ConsoleApp3.Repository
{
    internal static class PrinterRepository
    {
        internal static List<Printer> GetPrinters()
        {
            using (var db = new PrinterManagementContext())
            {
                return db.Printers.ToList();
            }
        }

        internal static Printer GetPrinterById(int postId)
        {
            using (var db = new PrinterManagementContext())
            {
                return db.Printers.FirstOrDefault(printer => printer.PrinterId == postId);
            }
        }

        internal static List<Printer>GetPrinterByOffice(string office)
        {
            using (var db = new PrinterManagementContext())
            {
                List<Printer> printerTOreturn = db.Printers.Where(p => p.PrinterLocation == office).ToList();
                return printerTOreturn;
            }
        }
        internal static Printer RandomPrinterFromOffice(string office) {
            using (var db = new PrinterManagementContext())
            {
                Printer printer = db.Printers.FirstOrDefault(p => p.PrinterLocation == office);
                return printer;
            }
        }

        internal static bool SinglePrinterExistInOffice(string office)
        {
            using (var db = new PrinterManagementContext())
            {
                var printerToEvaluate = db.Printers.Where(p => p.PrinterLocation == office);
                if (printerToEvaluate.Count() == 1)
                {
                   Printer printer = printerToEvaluate.FirstOrDefault();
                    return printer.IsAvailable;
                }
                else return false;

            }
        }

        internal static bool CreatePrinter(Printer printerToAdd)
        {
            using (var db = new PrinterManagementContext())
            {
                try
                {
                     db.Printers.Add(printerToAdd);
                    return db.SaveChanges() >= 1;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        internal static bool UpdatePrinter(Printer printerToUpdate)
        {
            using (var db = new PrinterManagementContext())
            {
                try
                {
                    db.Printers.Update(printerToUpdate);

                    return db.SaveChanges() >= 1;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        internal static bool DeletePost(int printerId)
        {
            using (var db = new PrinterManagementContext())
            {
                try
                {
                    Printer printerToDelete = GetPrinterById(printerId);

                    db.Remove(printerToDelete);

                    return db.SaveChanges() >= 1;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

    }
}
