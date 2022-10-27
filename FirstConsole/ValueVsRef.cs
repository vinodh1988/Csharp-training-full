using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    internal class ValueVsRef
    {
        //Overloading
        //Creating functions with different parameters specifation
        //parameter specifiation - number of parameter, type of parameter ,order of parameter
       // x and y are not in the same location it is pass by value
        static void AssignMe(int x) {
            Console.WriteLine("Within Assign me x is {0}", x);
            x = 90;
            Console.WriteLine("After Changing Within Assign me x is {0}", x);
        }
        // x and array are pointing same address - pass by reference
        static void AssignMe(int[] x) {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = 90;
            }
        }

        static void AssignMe(Single x) {
            x = 90;
        }
            
        static void Main(String[] n) {
            int[] array = { 34, 34, 53, 5, 34, 35, 590 };
            int y = 349;
            Single z = 9034.4f;

            Console.WriteLine("Before Calling");
            Console.WriteLine("array is ->");
            foreach (var x in array)
                Console.WriteLine(x);
            Console.WriteLine("y is {0} ", y);
            Console.WriteLine("z is {0}", z);

            AssignMe(array);
            AssignMe(y);
            AssignMe(z);

            Console.WriteLine("After Calling");
            Console.WriteLine("array is ->");
            foreach (var x in array)
                Console.WriteLine(x);
            Console.WriteLine("y is {0} ", y);
            Console.WriteLine("z is {0}", z);


        }
    }
}
