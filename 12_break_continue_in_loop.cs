using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class _12_break_continue_in_loop
    {
        static void Main1(string[] args)
        {
            //program that shows the break and continue in a loop
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    continue; //this will just skip the line one time
                }
                else
                    break;// this will just skip the next coming line
                Console.WriteLine(i + 1);
            }
            Console.ReadLine();
        }
    }
}
