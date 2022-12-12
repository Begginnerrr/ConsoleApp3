using ConsoleApp3.ErrorHandling;
using ConsoleApp3.Repository;
using ConsoleApp3.Utility;
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
            while (!checkingLoopValue)
            {
                Console.Clear();
                Console.WriteLine("Hello, please enter your details:");
                Console.WriteLine("Input your name: ");
                inputLoginName = Console.ReadLine();
                
                Console.WriteLine("Input your password: ");
                inputLoginPassword = Console.ReadLine();
                succesfulAuth = UserRepository.GetUserByCredentials(inputLoginName, inputLoginPassword);

                if (succesfulAuth)
                {
                    UserRole.SetAdminRole(UserRepository.GetUserRoleByCredetials(inputLoginName, inputLoginPassword));
                    return succesfulAuth;
                }
                ColorManager.redMessage("Login credentials are incorrect");
                Thread.Sleep(3000);

            }
            return false;
        }
    }
}
