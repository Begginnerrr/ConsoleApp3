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
Printer updatedPrinter = new Printer();
updatedPrinter.PrinterId = 1;
updatedPrinter.PrinterName = "New kind of printer";
updatedPrinter.PrinterDescription = "Has no description";
updatedPrinter.PrinterLocation = "Office D";

bool isUpdated = await PrinterRepository.UpdatePrinterAsync(updatedPrinter);
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
User user = new User();
user.userId= 2;
user.name = "user1";
user.password = "pw";
user.isAdmin = true;

List<User> listofPrinters = UserRepository.GetUsers();
foreach (User prnt in listofPrinters)
{
    Console.WriteLine(prnt.userId);
}
User print = UserRepository.GetUserById(1);
Console.WriteLine(print.name);


/*
bool success =UserRepository.CreateUser(user);
if (success)
{
    Console.WriteLine("User succesfully created");
}
else
{
    Console.WriteLine("Things went wrong");
}
*/
/*
bool success = UserRepository.DeleteUser(2);
if (success)
{
    Console.WriteLine("User succesfully created");
}
else
{
    Console.WriteLine("Things went wrong");
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
    services.AddDbContext<PrinterManagementContext>(options => options.UseMySQL("server=localhost;user=root;database=SchoolDb;password=root;port=3306"));
    //.AddHostedService<DiBerieBotMain>();
    ;
})
.Build();
*/


