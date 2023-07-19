using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    class _15_oops
    {
        static void Main(string[] args)
        {
            player sandra = new player();
            Console.WriteLine(sandra.health);
            sandra.setHealth(190);
            Console.WriteLine(sandra.health);
            Console.ReadLine();
        }
        
    }
}
