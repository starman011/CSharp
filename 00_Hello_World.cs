using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class _00_Hello_World
    {
        static void Main0(string[] args)
        {
            // is used to comment in single line
            /* is a 
               multiline comment*/
            int car = 1;// integer variable
            //Data Types are of following types
            /* 1 byte = 8 bit
            1. Integer               - int harry;  ---> takes 4 bytes
            1.1 Long                 - long harry; ---> takes 8 bytes
            2. Floating point number - float that; ---> takes 4 bytes
            2.1 Double               - double harry; --> takes 8 bytes
            3. Character             - char a = 'A';  ---> takes 2 bytes
            4. Boolean               - bool isGreat = True; ---> takes 1 bit
            5. String                - string inp = "Harry"; ---> takes 2 bytes / characters
            */
            Console.WriteLine("Hello World");
            Console.Write("This will make the code continue in same line");
            Console.WriteLine("Hello World" +  car );
            Console.ReadLine();
        }
    }
}
