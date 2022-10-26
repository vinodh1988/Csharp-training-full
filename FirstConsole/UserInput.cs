using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    internal class UserInput
    {
        static void Main(string[] n)
        {
            Console.WriteLine("Enter Sno:");
            int sno = Int32.Parse(Console.ReadLine());
            //Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Sno : " + sno + " Name: " + name);


            Int32 x = sno;//Autoboxing
            int y = x;//unboxing

            int? z = null;
            Int32? k = null; //Nullable -> Nullable<Int32> k=null;
            Nullable<Int32> data = null;

            float? m = 30.34f;
            double d = 1.2;
            Single? sample = m;//represents Float

        }
    }
}
