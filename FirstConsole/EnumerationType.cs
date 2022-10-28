using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FirstConsole
{
    enum Profession { 
       Teacher=20,
       Doctor=22,
       Programmer,
       Plumber,
       Accountant=30,
       Dancer,
       Singer,
       Labour
    }
    internal class EnumerationType
    {
        static void Main(string[] n) {
            int profession =(int) Profession.Teacher;
            Console.WriteLine("profession is " + profession);
            profession = (int)Profession.Dancer;
            Console.WriteLine("profession is " + profession);
        }
    }
}
