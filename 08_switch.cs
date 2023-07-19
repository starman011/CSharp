using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class _08_switch
    {
        static void Main7(string[] args)
        {
            int age = 20;
            switch (age)
            {
                case 18:
                    Console.WriteLine("Please wait for an year");
                    break;
                case 19:
                    Console.WriteLine("You are eligible to ride");
                    break;
                default:
                    Console.WriteLine("Enjoy!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
