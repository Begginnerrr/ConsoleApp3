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



//MysqlEntityFrameworkDesignTimeServices abc = new MysqlEntityFrameworkDesignTimeServices();

Console.WriteLine("Hello, World!");
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
Console.WriteLine("Maybe this will be reached??");

Request request = new Request();
request.refreshData();

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


