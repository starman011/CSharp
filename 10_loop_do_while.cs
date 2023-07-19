using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class _10_loop_do_while
    {
        static void Main9(string[] args)
        {
            //program to write a command for do while
            //this is same as while command but do is in first so it will atleast run once

            int number = 0;
            do
            {
                Console.WriteLine(number + 1);
                number++;
            }
            while (number < 5);
            Console.ReadLine();
        }
    }
}
