﻿// <auto-generated />
using ConsoleApp2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp3.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20220926141142_Initial3")]
    partial class Initial3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ConsoleApp3.Data.Printer", b =>
                {
                    b.Property<int>("PrinterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PrinterDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PrinterLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PrinterName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PrinterId");

                    b.ToTable("Printers");
                });

            modelBuilder.Entity("ConsoleApp3.Data.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
