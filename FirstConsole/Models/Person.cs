using System;
using System.Collections.Generic;
using System.Text;

namespace FirstConsole.Models
{
    internal class Person
    {
        private int sno; //instance variables
        private string name;
        private string city;

        internal void SetFields(int sno, String name, String city) {
            this.sno = sno;
            this.name = name;
            this.city = city;
        }

        internal void Show() {
            Console.WriteLine("\n Sno: " + sno);
            Console.WriteLine("\n Name: " + name);
            Console.WriteLine("\n City " + city);
        }
    }
}
/*
 * Instance variables are called instance variables because
 * for every object the copy of the variable is created
 * 
 * 
 * private
 * protected
 * public 
 * internal
 * 
 * 
 * */