﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello my name is Ye Htet Aung!");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            // Console.WriteLine(name);

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            // Console.WriteLine(age);

            /*  Console.Write("Your name is ");
              Console.Write(name);
              Console.Write(" and your age is ");
              Console.Write(age);*/

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + age);

            Console.ReadLine();
        }
    }
}
