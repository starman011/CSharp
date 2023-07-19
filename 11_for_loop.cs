using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class _11_for_loop
    {
        static void Main23(string[] argz)
        {
            //program to write a for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1);
                break;//this will force the algorithm to forcefully exit
            }
            Console.ReadLine();
        }
        
    }
}
