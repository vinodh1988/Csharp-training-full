using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole
{
    internal class AnonymousTypes
    {
        static void Main(string[] n) {
            var person = new { Sno=1, Name =" Roger", City ="Mumbai"};

            Console.WriteLine(person);
            Console.WriteLine(person.Name);
            Console.WriteLine("Type of Person is "+person.GetType());

           // person.Name = "Rakesh";//readonly not assignable
        }
    }
}
