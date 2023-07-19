using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class __02_Type_Casting
    {
        static void Main2(string[] args)
        {
            // program to write data for typecasting
            // data type examples
            int a = 34;
            float b = 34.2F; //we have to use F as a suffix, because C# is a type safe language and it requires it to exactly write what we told
            double c = 43.2D;
            bool isGreat = false;
            char d = 'a';
            string e = "this is a string";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(isGreat);
            Console.WriteLine("Hello");
            Console.WriteLine(e);


            // Type Casting
            // There are two types of typecasting
            // 1. Implicit Casting:
            // char to int to long to float to double
            
            // 2. Explicit Casting:
            // int x = (int)3.5;

            int x = (int)3.5;
            int f = 3;
            double y = f;
            float z = 'y';
            //there are various built in methods that can convert data types:
            // ex :
            float x1 = Convert.ToInt32(3.45);
            //Convert.ToDouble
            //Convert.ToString

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(f);
            Console.WriteLine(z);
            Console.WriteLine(x1);
            Console.ReadLine();
            
        }
    }
}

