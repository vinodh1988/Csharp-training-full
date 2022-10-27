using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    internal class ExplicitConversion
    {
        static void Main(string[] n)
        {
            int x = 10;
            byte y = (byte)x; //typecasting

            double p = 3243.344;
            float f = (float)p; //typecasting

            double k = f; //implicit conversion
            k = x; //implicit conversion

            Console.WriteLine(x + " " + y + " " + p + "  " + f + " " + k);

            char c = (char)65;

            string z = 254 + "";

            Console.WriteLine(c);
            Console.WriteLine(z);

        }
    }
}
