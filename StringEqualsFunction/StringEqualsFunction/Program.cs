using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEqualsFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string compare = "Hello";

            if(compare.Equals(message))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Diff");
            }

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if (!name.Equals(""))
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Invalid name input");
            }

            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            object newCompare = new string(chars);

            if(message == newCompare)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Diff");
            }

            Console.ReadLine();
        }
    }
}
