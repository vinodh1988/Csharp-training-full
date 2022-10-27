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

            Console.Write(person.Sno.ToString());
           // person.Name = "Rakesh";//readonly not assignable
        }
    }
}

/*
 * 
 * Status(501, new {message =" ID is already there"})
*/