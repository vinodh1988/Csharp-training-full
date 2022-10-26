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

            Console.WriteLine(x + " " + f);
            Console.WriteLine("{0} is the float and {1:X} is the integer", f, x);
        }
    }
}
