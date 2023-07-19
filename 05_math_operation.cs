using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class _05_math_operation
    {
        static void Main4(string[] args)
        {
            // math is a class inside C#, for mathematical operations

            int a = Math.Max(34, 455);
            double b = Math.Sqrt(456);
            Console.WriteLine(a);
            Console.WriteLine(b);
            int c = Convert.ToInt16(b);
            Console.WriteLine(c);
            //properly using a math command
            double d = Math.Round(b);
            Console.ReadLine();
        }
    }
}
