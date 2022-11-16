using System.IO;
using System;
using System.Collections.Generic;

namespace ConsoleApp3.AppConfiguration
{
    public static class Configuration
    {
        static string dbConnectionString = "server=localhost;user=root;database=PrinterManagementSystemDB;password=metadata1;port=3306";
        static string printerFilesLocation = "C:\\Users\\Nebula\\Desktop\\ProjectOnTheFly\\ConsoleApp3\\ConsoleApp3\\Printer Files\\";

        readonly static string configFilename = "config.ini";

        public static Configuration()
        {
            string execPath = Assembly.GetEntryAssembly().Location;

            if (execPath == "" || execPath == null)
            {
                Console.WriteLine("Failed to locate .exe path!\n");
                return; 
            }

            string path = execPath + "\\..\\" + configFilename;

            if (File.Exists(path))
                ReadConfig(path);
            else
                CreateConfigFile(path);
        }

        public static string GetDBConnectionData()
        {
            return dbConnectionString;
        }

        public static string GetPrinterFilesPath()
        {
            return printerFilesLocation;
        }

        static void CreateConfigFile(string path)
        {
            StreamWriter write;
            try
            {
                write = new StreamWriter(path);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex + "\n");
                return;
            }

            write.Write(dbConnectionString);

            write.Close();
        }

        static void ReadConfig(string path)
        {
            StreamReader read;
            try
            {
                read = new StreamReader(path);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex + "\n");
                return;
            }

            string allData = read.ReadToEnd();

            read.Close();

            string[] seperators = { "\r\n", "\n" };
            string[] lines = allData.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            // Check if we have enough lines for config data
            if (lines.Length < 5)
                return;

            string finalStr = "";

            for (int i = 0; i < lines.Length; i++)
            {
                switch(i)
                {
                    case 0:
                        if (lines[i].StartsWith("server="))
                            finalStr += lines[i];
                        else
                            return;
                        break;

                    case 1:
                        if (lines[i].StartsWith("user="))
                            finalStr += lines[i];
                        else
                            return;
                        break;

                    case 2:
                        if (lines[i].StartsWith("database="))
                            finalStr += lines[i];
                        else
                            return;
                        break;

                    case 3:
                        if (lines[i].StartsWith("password="))
                            finalStr += lines[i];
                        else
                            return;
                        break;

                    case 4:
                        if (lines[i].StartsWith("port="))
                            finalStr += lines[i];
                        else
                            return;
                        break;
                }
            }

            dbConnectionString = finalStr;
        }
    }
}
