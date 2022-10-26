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
            int sno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string name=Console.ReadLine();
            Console.WriteLine("Sno : "+sno+" Name: "+name);
        }
    }
}
