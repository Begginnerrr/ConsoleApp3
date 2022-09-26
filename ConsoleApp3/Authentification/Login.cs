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
    public class Login
    {
        private bool checkingValue = false;
        private int dataInput;
        private string stringDataInput;
        private string inputName="";
        private string inputPassword = "";
        private bool succesfulAuth = false;

        public bool authenticateUser()
        {
            Console.WriteLine("Hello, please enter your details:");
            while (!checkingValue)
            {
                
                Console.WriteLine("Input your name: ");
                inputName = Console.ReadLine();
                Console.WriteLine("Input your password");
                inputPassword = Console.ReadLine();
                succesfulAuth = UserRepository.GetUserByCredentials(inputName, inputPassword);
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
