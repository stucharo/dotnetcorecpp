using System;
﻿using ICalc;

namespace Adder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");
            var first = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            var second = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Total: " + ICalc.ICalc.Add(first, second).ToString());
        }
    }
}
