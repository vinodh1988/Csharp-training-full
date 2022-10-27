using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    internal class JaggedArray
    {
        static void Main(string[] n)
        {
            int[][] jagged = new int[3][];

            jagged[0] = new int[3] { 3, 53, 34 };
            jagged[1] = new int[2] { 3, 53 };
            jagged[2] = new int[4] { 3, 53, 34,89 };

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++) {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
