using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FirstConsole
{
    internal class ArraysDemo
    {
        static void Main(string[] n) {
            foreach (var x in n) { 
               Console.WriteLine(x);
            }

            string[] names = { "Raghav", "Ramesh", "Rakesh", "Harry" };
            //decleration and intialization - it takes the size to the number of element in the initial value

            string[] names2 = new string[5];
            Console.WriteLine(names[3]);

            foreach (var x in names)
                Console.WriteLine(x+" and its lengtyh is "+x.Length);

            Console.WriteLine("-------------------------------------");

            names2[3] = "Naveen";
            names2[4] = "Sahid";
            foreach (var x in names2)
                Console.WriteLine(x);//+" "+x.Length);

            //names[4] = "Steven";

            int[] temp=new int[5];
          //  temp[4] = null ;
            temp[2] = 90;

            foreach(var x in temp) {
                Console.WriteLine(x);
            }

            for (int i = 0; i < temp.Length; i++) {
                Console.WriteLine("temp[" + i + "] = " + temp[i]);
            }
 
            
        }
    }
}
