using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = 23;

            /*
            age++;
            Console.WriteLine(age);

            age--;
            Console.WriteLine(age);

            age = age + 10;
            Console.WriteLine(age);

            age += 10;
            Console.WriteLine(age);

            age *= 10;
            Console.WriteLine(age);

            */

            age /= 10;
            Console.WriteLine(age);

            string name = "Ye Htet Aung";
            name += " is a programmer";
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(++i);
            Console.WriteLine(i);


            Console.ReadLine();
        }
    }
}
