using ConsoleApp2;
using ConsoleApp3.Data;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3.Repository
{
    internal static class PrinterRepository
    {
        internal static List<Printer> GetPrinters()
        {
            using (var db = new SchoolContext())
            {
                return db.Printers.ToList();
            }
        }

        internal static Printer GetPrinterById(int postId)
        {
            using (var db = new SchoolContext())
            {
                return db.Printers.FirstOrDefault(printer => printer.PrinterId == postId);
            }
        }

        internal static bool CreatePrinter(Printer printerToAdd)
        {
            using (var db = new SchoolContext())
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
            using (var db = new SchoolContext())
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
            using (var db = new SchoolContext())
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
