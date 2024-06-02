using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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

            double money = 10D / 3;

            Console.WriteLine(money);
            Console.WriteLine(String.Format("-£10 / £3 = £{0:0.00}", money));
            Console.WriteLine();

            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));
            Console.WriteLine();

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));


            Console.ReadLine();
        }
    }
}
