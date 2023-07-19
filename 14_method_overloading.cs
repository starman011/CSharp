using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{

    class _14_method_overloading
    { 
        //program to show a example of method overloading
        static float Average(int a, int b, int c)
        {
            float sum_of_numbers = a + b + c;
            return sum_of_numbers / 3;
        }
        //example of method overloading 
        static float Average(int a, int b)
        {
            float sum_of_number = a + b;
            return sum_of_number / 2;
        }
        static void Main2(string[] args)
        {
            Console.WriteLine("This is a normal method line, the next line is a method overload");
            Console.WriteLine(Average(1, 2, 4));
            Console.WriteLine(Average(1, 6));
            Console.ReadLine();
        }
    }
}
