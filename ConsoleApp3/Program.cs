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



//MysqlEntityFrameworkDesignTimeServices abc = new MysqlEntityFrameworkDesignTimeServices();

Console.WriteLine("Hello, World!");

DrawMenu menu = new DrawMenu();
menu.drawingMenu();
menu.startProgram();



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
        var cns = context.Configuration.GetConnectionString("server=localhost;user=root;database=SchoolDb;password=root;port=3306");
        services.AddDbContext<SchoolContext>(options => options.UseMySQL("server=localhost;user=root;database=SchoolDb;password=root;port=3306"));
       
    })
    .Build();
hostBuilder.Run();
*/

/*
Printer printer = new Printer();
printer.PrinterId = 2;
printer.PrinterName = "Testing Printer2";
printer.PrinterDescription = "This is printerDescription 2";
printer.PrinterLocation = "Office B";

bool createSuccess = await PrinterRepository.CreatePrinterAsync(printer);
if(createSuccess == true)
{
    Console.WriteLine("This was succesfull");
}
else
{
    Console.WriteLine("Something went wrong");
}
*/

/*
List<Printer> listofPrinters = PrinterRepository.GetPrinters();
foreach (Printer prnt in listofPrinters)
{
    Console.WriteLine(prnt.PrinterId);
}

Printer print = await PrinterRepository.GetPrinterByIdAsync(1);
Console.WriteLine(print.PrinterName);
*/
/*
Printer printer2 = new Printer();
printer2.PrinterId = 1;
printer2.PrinterName = "New kind of printer";
printer2.PrinterDescription = "Has no description";
printer2.PrinterLocation = "Office D";

bool isUpdated = await PrinterRepository.UpdatePrinterAsync(printer2);
if (isUpdated == true)
{
    Console.WriteLine("This was succesfull");
}
else
{
    Console.WriteLine("Something went wrong");
}


bool isDeleted = await PrinterRepository.DeletePostAsync(1);
if (isDeleted == true)
{
    Console.WriteLine("This was succesfull");
}
else
{
    Console.WriteLine("Something went wrong");
}
*/


/*

Console.WriteLine("Maybe this will be reached??");

Request request = new Request();
request.refreshData();
*/
/*

IHost host = Host.CreateDefaultBuilder(args)
.ConfigureAppConfiguration((config) =>
{
   // config.AddJsonFile("appsettings.json");
    config.AddEnvironmentVariables();
    config.Build();
})

.ConfigureServices((context, services) =>
{
    var cns = context.Configuration.GetConnectionString("MyConnection");
    services.AddDbContext<SchoolContext>(options => options.UseMySQL("server=localhost;user=root;database=SchoolDb;password=root;port=3306"));
    //.AddHostedService<DiBerieBotMain>();
    ;
})
.Build();
*/


