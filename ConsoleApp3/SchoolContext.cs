﻿using ConsoleApp3.AppConfiguration;
using ConsoleApp3.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SchoolContext : DbContext
    { 
        /*
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        */

        public DbSet<Printer> Printers { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
             
        }

        public SchoolContext()
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
                    Configuration.dbConnectionString);
        }

        //  protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=AppDB.db");

    }
}
 