using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int age; // variable declaration
            age = 23; // variable intialization
            */

            /*
            int x;
            int y;
            int z;
            */

            /*int x, y, z;*/

            int age = -23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue); // 2147483647
            Console.WriteLine(int.MinValue); // -2147483648

            long bigNumber = -9000000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);  // 9223372036854775807
            Console.WriteLine(long.MinValue);  // -9223372036854775808

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue); // 1.79769313486232E+308
            Console.WriteLine(double.MinValue); // -1.79769313486232E+308

            float precision = 5.000001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);  // 3.402823E+38
            Console.WriteLine(float.MinValue);  // -3.402823E+38

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(double.MaxValue);  // 1.79769313486232E+308
            Console.WriteLine(double.MinValue);  // -1.79769313486232E+308

            age = 50;
            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
