using FirstConsole.Models;
using System;

namespace FirstConsole
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person();
            p.SetFields(1, "Ravi Krishna", "Chennai");
            p.Show();
            p.Sno = 2;
            p.Name = "Ravi Kumar";

            p.Show();

            Emp e = new Emp();
            e.Show();
          //  p.sno = 12; //error
        }
    }
}
/**
 * class Name:
 * 
 *   Convention:
 *             Name the classes starting with uppercase
 *             
 *   Rules
 *             For class names
 *             Not start with numbers
 *             No Space
 *             No special characters except underscore
 *             
 *   Method Name:
 *   
 *     Follow the same rules and conventions that you follow for
 *     class
 *             
 *   
 */
