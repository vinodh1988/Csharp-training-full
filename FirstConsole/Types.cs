using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    internal class Types
    {
        static void Main(string[] s) {
            int a = 30;
            Console.WriteLine(a+" is the value and its type is " + a.GetType());

            //var x; //error
            var p = 349; //implicitly typed variable
            Console.WriteLine(p + " is the value and its type is " + p.GetType());

            var m = 34.53f;
            var z = 34893.35;
            var temp = true;

            Console.WriteLine(m + " is the value and its type is " + m.GetType());
            Console.WriteLine(z + " is the value and its type is " + z.GetType());
            Console.WriteLine(temp + " is the value and its type is " + temp.GetType());

        }
    }
}
