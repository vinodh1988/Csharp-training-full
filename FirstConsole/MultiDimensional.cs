using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    internal class MultiDimensional
    {
        static void Main(string[] x)
        {
            int[,] twod = new int[3, 4] {
               {2,4,4,6 },{34,34,33,5},{34,334,34,35}
            };

            Console.WriteLine("Number of Rows " + twod.GetLength(0));
            Console.WriteLine("Number of Columns " + twod.GetLength(1));
            for (int i = 0; i < twod.GetLength(0); i++)
            {
               
                for (int j = 0; j < twod.GetLength(1); j++)
                {
                    Console.Write(twod[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }

}