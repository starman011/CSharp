using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class _06_string_functions
    {
        static void Main5(string[] args)
        {
            // string method and there functions, length is a function
            string hello = "Hello Morty";
            Console.WriteLine(hello.Length);
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello + " You are nice");
            Console.WriteLine(string.Concat(hello, " You are nice"));


            // same as a f-string, it is called string interpolation in C#
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the number of candies");
            string candies = Console.ReadLine();
            // this is string interpolation
            Console.WriteLine($"Your name is {name} and you will get {candies} candies");
            //accessing the index / characters
            string hi = "This is it";
            Console.WriteLine(hi[0]);
            //how to get to know the position of the string in a index
            Console.WriteLine(hi.IndexOf("is"));
            //to get a deduciton in the length and then print the line
            Console.WriteLine(hi.Substring(5));

            //escape sequence characters
            string f = "This is a new planet named \"Earth";

            //inserting a new line
            string e = "thiis  is  a \n new line";

            //inserting a tab in between two word
            string g = "this has a \t tab in it";

            Console.WriteLine(e, f);
            Console.WriteLine(g);


            Console.ReadLine();
        }
    }
}
