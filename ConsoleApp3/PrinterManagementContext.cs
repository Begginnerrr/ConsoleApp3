using ConsoleApp3.AppConfiguration;
using ConsoleApp3.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppContext
{
    public class PrinterManagementContext : DbContext
    { 
        /*
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        */

        public DbSet<Printer> Printers { get; set; }
        public DbSet<User> Users { get; set; }

        public PrinterManagementContext(DbContextOptions<PrinterManagementContext> options) : base(options)
        {
             
        }

        public PrinterManagementContext()
        {
        }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Chinook");
            }
        }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
            optionsBuilder.UseMySql(Configuration.dbConnectionString, serverVersion);

            //optionsBuilder.UseMySQL( Configuration.dbConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region BlogSeed
            for(int i=1; i < 1000; i++)
            {
                User user = new User();
                user.userId = i + 10;
                user.name = "user" + i.ToString() + 10;
                user.password = "user" + i.ToString() + 10;
                user.isAdmin = false;
                modelBuilder.Entity<User>().HasData(user);
            }
            for (int i = 1; i < 1000; i++)
            {
                Printer printer = new Printer();
                printer.PrinterId = i + 10;
                printer.PrinterDescription = "This is printer";
                printer.PrinterName = "Printer" + i.ToString();
                printer.PrinterLocation = "Office" + i.ToString();
                printer.IsAvailable = true;
                modelBuilder.Entity<Printer>().HasData(printer);
            }
            #endregion
        }

        //  protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=AppDB.db");

    }
}
 