using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Utility
{
    public static class ColorManager
    {
        public static void blueMessage(string s){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(s);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void redMessage(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void greenMessage(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
