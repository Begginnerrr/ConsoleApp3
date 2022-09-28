using ConsoleApp3.Repository;
using ConsoleApp3.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3.Authentification
{
    public static class Login
    {
        private static bool checkingLoopValue = false;
        private static string inputLoginName="";
        private static string inputLoginPassword = "";
        private static bool succesfulAuth = false;

        public static bool authenticateUser()
        {
            Console.WriteLine("Hello, please enter your details:");
            while (!checkingLoopValue)
            {
                Console.WriteLine("Input your name: ");
                Console.WriteLine("");
                inputLoginName = Console.ReadLine();
                Console.WriteLine("Input your password: ");
                Console.WriteLine("");
                inputLoginPassword = Console.ReadLine();
                succesfulAuth = UserRepository.GetUserByCredentials(inputLoginName, inputLoginPassword);
                if (succesfulAuth == true)
                {
                    return succesfulAuth;
                }
                Console.WriteLine("Credentials are incorect");

            }
            return false;
        }

        
    }
}
