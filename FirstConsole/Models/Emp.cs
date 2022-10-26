using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole.Models
{
    internal class Emp
    {
        public int Eno { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public void Show()
        {
            Console.WriteLine("\nEno: " + Eno);

            Console.WriteLine("\nName: " + Name);

            Console.WriteLine("\nCity: " + City);
        }

    }
}
