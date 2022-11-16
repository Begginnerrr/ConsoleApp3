using ConsoleApp3.AppConfiguration;
using ConsoleApp3.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            optionsBuilder
                .UseMySQL(
                    Configuration.GetDBConnectionData());
        }

        //  protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=AppDB.db");

    }
}
 