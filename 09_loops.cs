using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class _09_loops
    {
        static void Main8(string[] args)
        {
            // program to write loop in C#
            //while loops
            int number = 0;
            while (number < 100)
            {
                Console.WriteLine(number + 1);
                number++;
            }

            Console.ReadLine();
        }
    }
}
