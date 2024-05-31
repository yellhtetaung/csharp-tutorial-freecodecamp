using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbericFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D;

            Console.WriteLine(value);
            Console.WriteLine(String.Format("{0:0.0}", value));
            Console.WriteLine(String.Format("{0:0.#}", value));
            Console.WriteLine(String.Format("{0:0.000}", value));

            Console.ReadLine();
        }
    }
}
