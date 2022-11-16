using System.IO;
using System;
using System.Collections.Generic;

namespace ConsoleApp3.AppConfiguration
{
    public static class Configuration
    {
        string dbConnectionString = "server=localhost;user=root;database=PrinterManagementSystemDB;password=metadata1;port=3306";
        string printerFilesLocation = "C:\\Users\\Nebula\\Desktop\\ProjectOnTheFly\\ConsoleApp3\\ConsoleApp3\\Printer Files\\";

        static string configFilename = "config.ini";

        public Configuration()
        {
            string execPath = Assembly.GetEntryAssembly().Location;
            string path = execPath + "\\..\\" + configFilename;

            if (File.Exists(path))
                ReadConfig(path);
            else
                CreateConfigFile(path);
        }

        public string GetDBConnectionData()
        {
            return dbConnectionString;
        }

        public string GetPrinterFilesPath()
        {
            return printerFilesLocation;
        }

        void CreateConfigFile(string path)
        {
            StreamWriter write = new StreamWriter(path);

            write.Write(dbConnectionString);

            write.Close();
        }

        void ReadConfig(string path)
        {
            StreamReader read = new StreamReader(path);

            string allData = read.ReadToEnd();

            read.Close();

            string[] seps = { "\r\n", "\n" };
            string[] lines = allData.Split(seps, StringSplitOptions.RemoveEmptyEntries);

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
