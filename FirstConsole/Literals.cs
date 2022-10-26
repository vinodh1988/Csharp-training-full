using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    internal class Literals
    {
        static void Main(string[] s) {
            float f = 34.34f;
            int x = 0x34;// 3x(16^1)+(4x16^0) =52
            int octal = Convert.ToInt32("34", 8);
            string printoctal = Convert.ToString(24, 8);

            int binary = Convert.ToInt32("1010", 2);
            string printbinary = Convert.ToString(10, 2);
            Console.WriteLine(x + " " + f);
            Console.WriteLine(binary);
            Console.WriteLine(printbinary);
            Console.WriteLine(octal);
            Console.WriteLine(printoctal);
            Console.WriteLine("{0} is the float and {1:X} is the integer", f, x);
        }
    }
}
