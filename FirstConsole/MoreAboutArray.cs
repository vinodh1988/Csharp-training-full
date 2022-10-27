using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstConsole
{
    internal class MoreAboutArray
    {
        static void Main(string[] n)
        {
            int[] x = new int[5] { 34, 35, 3636, 4534, 34 };

            string[] y = new string[5] { "Larry","Zaheer","Joseph","Mike","Steve"};

            Console.WriteLine(y.Contains("Joseph"));
            Console.WriteLine(y.Max());
            Console.WriteLine(x.Max());

            //Array.Sort(x);
            Array.Sort(x);
            Array.Reverse(x);
            foreach (var temp in x)
                Console.WriteLine(temp);

            

            

        }
    }
}
