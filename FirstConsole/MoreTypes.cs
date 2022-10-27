using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    internal class MoreTypes
    {
        static void Main(string[] s) {
            var a = 20; //inferes the type to Int32
            Console.WriteLine(a);
            a = 34;//it is ok to take a new value provided if it is int32

            // a = 34.45; //error
            //dynamic types
            //dynamic variables gets the type of the variable during runtime not
            //decided during compilation..during compilation type of the variable is
            //ignored
            //c# -4 feature is introduced
            dynamic x = 43;
            Console.WriteLine(x+ "is the value and type is "+ x.GetType());
            x = "hello";
            Console.WriteLine(x+" is the value and type is "+ x.GetType());
        }
    }
}
