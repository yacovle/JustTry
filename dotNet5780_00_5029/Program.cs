using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_00_5029
{
    class Program
    {
        static void Main(string[] args)
        {
            //vdd
            WelcomeMethod();
            Console.ReadKey();
        }

        private static void WelcomeMethod()
        {
            Console.WriteLine("enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("{0}, Welcome to my first console application", name);
        }
    }
}
