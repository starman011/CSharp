using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class _13_methods
    {
        //funciton to return a average of three given number
        static int average(int a, int b, int c)
        {
            Console.WriteLine("The average is:");
            int sum = a + b + c;
            int sum_average = (a + b + c) / 3;
            return sum_average;

        }
        //program to demostrate the usuage of method/function 
        static void greet(string name)
        {
            Console.WriteLine("Good Morning" + name);

        }
        static void Main1(string[] args)
        {
            greet("Saqlain");
            greet("Leelu");
            Console.WriteLine(average(1, 5, 89));
            Console.ReadLine();
        }       
    }
}
