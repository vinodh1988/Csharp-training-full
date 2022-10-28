using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace FirstConsole
{
    //structure is a collection of heterogeneous types
    struct PersonType
    {
        public int sno;
        public string name;
        public string city;

        public void Show() {
            Console.WriteLine("Name: " + name);
        }
    }

    class PersonClass { 
        public int sno;
        public string name;
        public string city;
    }
    internal class StructDemo
    {
        static void Main(string[] n) {
            PersonType p ;
            PersonType p1 = new PersonType() { sno=1,name="Raj",city="Chennai"};
            p.sno = 1;p.name = "Arjun";p.city = "Chennai";
            Console.WriteLine(p);
            Console.WriteLine("sno: {0},name: {1}, city: {2}", p.sno, p.name, p.city);
            Console.WriteLine("sno: {0},name: {1}, city: {2}", p1.sno, p1.name, p1.city);
            p.Show();
            p1.Show();
           // PersonClass x;
           // x.sno = 20; //error - a class reference variable should be assigned to an object
            
        }
    }
}
