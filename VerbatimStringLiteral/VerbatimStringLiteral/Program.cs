using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerbatimStringLiteral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * \t = tab
             * \n = new line
             * \ = escape character ( \", \\ )
             */

            string speech = "He said \"something\"";
            string path = "C:\\Users\\CoffeeNCode\\Desktop\\C# Course\nNew Line Test";
            Console.WriteLine(path);
            Console.WriteLine(speech);

            path = @"C:\Users\CoffeeNCode\Desktop\C# Course" + "\nNew Line Test";
            Console.WriteLine(path);

            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            name = @"Hello 'someone'";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
