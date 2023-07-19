using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class _07_if_else
    {
        static void Main6(string[] args)
        {
            //program to run if else statement
            Console.WriteLine("Enter the age");
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);

            if (b < 2)
            {
                Console.WriteLine("You're just born");
            }
            else if (b > 18)
            {
                Console.WriteLine("You can drive a Vehicle");
            }

            else
            {
                Console.WriteLine("You are not eligibe to ride a motorcycle");
            }
            Console.ReadLine();
        }
    }
}
