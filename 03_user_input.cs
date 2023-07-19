using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class _03_user_input
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("Welcome to the program, write your name");
            String name = Console.ReadLine();
            Console.WriteLine("Hi " + name);

            // code to calculate candies based on user input
            Console.WriteLine("How many candies do you want?");
            string candies = Console.ReadLine();
            int candies_final = Convert.ToInt32(candies);
            Console.WriteLine("The candies you have are " + (candies_final + 4));
            Console.ReadLine();
        }
    }
}
 