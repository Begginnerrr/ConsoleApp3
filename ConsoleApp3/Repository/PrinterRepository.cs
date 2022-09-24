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

        internal async static Task<Printer> GetPrinterByIdAsync(int postId)
        {
            using (var db = new SchoolContext())
            {
                return await db.Printers.FirstOrDefaultAsync( printer => printer.PrinterId == postId);
            }
        }

        internal async static Task<bool> CreatePrinterAsync(Printer printerToAdd)
        {
            using (var db = new SchoolContext())
            {
                try
                {
                    await db.Printers.AddAsync(printerToAdd);
                    return await db.SaveChangesAsync() >= 1;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        internal async static Task<bool> UpdatePrinterAsync(Printer printerToUpdate)
        {
            using (var db = new SchoolContext())
            {
                try
                {
                    db.Printers.Update(printerToUpdate);

                    return await db.SaveChangesAsync() >= 1;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        internal async static Task<bool> DeletePostAsync(int printerId)
        {
            using (var db = new SchoolContext())
            {
                try
                {
                    Printer printerToDelete = await GetPrinterByIdAsync(printerId);

                    db.Remove(printerToDelete);

                    return await db.SaveChangesAsync() >= 1;

                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

    }
}
