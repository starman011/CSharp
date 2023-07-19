using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class _04_operators
    {
        static void Main3(string[] args)
        {
            //different types of operators are:
            Console.WriteLine("These are the different types of operators in C#");
            /* 
             1. Arithmetic Operators
             2. Assignment Operators
             3. Logical Operators
             4. Comparison Operators
            */

            int a = 10;
            int b = 5;
            //Arithmetic Operators
            Console.WriteLine("Arithmetic operators");
            Console.WriteLine("The value of a + b is " + (a + b));
            Console.WriteLine("The value of a - b is " + (a - b));
            Console.WriteLine("The value of a * b is " + (a * b));
            Console.WriteLine("The value of a / b is " + (a / b));

            //Assignment Operators
            int c = 4;
            int d = c;
            // c += 4;
            // c -= 5;
            // c *= 4;
            // c /= 4;

            //Logical Operators;
            // && and
            // || or
            // !  not of (Not operator)
            //&& operator
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            //or operator
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);

            // not of true/false
            Console.WriteLine(!true);
            Console.WriteLine(!true);
            Console.WriteLine(!false);

            //Comparison Operators
            Console.WriteLine(344 > 233); //greator than operator
            Console.WriteLine(344 <= 333); //less than or equal to operator
            Console.WriteLine(345 >= 555); //greator than or equal to operator
            Console.WriteLine(344 != 555); // not equal to operator
            Console.WriteLine(333 == 333); // equal to equal to operator
            Console.ReadLine();
        }
    
    }

}
