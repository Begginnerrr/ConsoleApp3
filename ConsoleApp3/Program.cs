// See https://aka.ms/new-console-template for more information
using ConsoleApp2;
using ConsoleApp3;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using static K4os.Compression.LZ4.Engine.Pubternal;
using Microsoft.EntityFrameworkCore.Design;
using MySql.EntityFrameworkCore.Extensions;
using ConsoleApp3.Data;
using Microsoft.VisualBasic;
using ConsoleApp3.Repository;
using ConsoleApp3.Authentification;



//MysqlEntityFrameworkDesignTimeServices abc = new MysqlEntityFrameworkDesignTimeServices();

bool succesfullLogin = false;
succesfullLogin = Login.authenticateUser();
if (succesfullLogin)
{
    Console.Clear();
    DrawMenu menu = new DrawMenu();
    menu.drawingMenu();
    menu.startProgram();
}
else
{
    Console.WriteLine("Application stopped working, Contact support");
}




// ------------------------------------------------------------------------------------------------------------------------------------
/*
IHost hostBuilder = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((context, builder) =>
    {
        builder.SetBasePath(Directory.GetCurrentDirectory());
        // var connectionString = hostContext.Configuration.GetConnectionString("server=localhost;user=root;database=SchoolDb;password=root;port=3306");
       // var connectionString = context.Configuration.GetConnectionString("server=localhost;user=root;database=SchoolDb;password=root;port=3306");
    })
    .ConfigureServices((context, services) =>
    {
        var cns = context.Configuration.GetConnectionString("server=localhost;user=root;database=PrinterManagementSystemDB;password=root;port=3306");
        services.AddDbContext<PrinterManagementContext>(options => options.UseMySQL("server=localhost;user=root;database=PrinterManagementSystemDB;password=root;port=3306"));
       
    })
    .Build();
hostBuilder.Run();
*/




