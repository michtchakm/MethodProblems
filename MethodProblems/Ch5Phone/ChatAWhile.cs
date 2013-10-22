using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch5Phone
{
    class ChatAWhile
    {
        static void main(string[] args)
        {
            string input;

            int[] areacodes = new int[6] { 262, 414, 608, 715, 815, 920 };

            Console.WriteLine("Enter your area code and length of call");

            input = Console.ReadLine();

            if (input == "262")
            {
                Console.WriteLine("Per-Minute Rate($) is 0.07, which is multiplied by {0} minutes of the call");
            }

            if (input == "414")
            {
                Console.WriteLine("Per-Minute Rate($) is 0.10, which is multiplied by {0} minutes of the call");
            }

            if (input == "608")
            {
                Console.WriteLine("Per-Minute Rate($) is 0.05, which is multiplied by {0} minutes of the call");
            }

            if (input == "715")
            {
                Console.WriteLine("Per-Minute Rate($) is 0.16, which is multiplied by {0} minutes of the call");
            }

            if (input == "815")
            {
                Console.WriteLine("Per-Minute Rate($) is 0.24, which is multiplied by {0} minutes of the call");
            }

            if (input == "920")
            {
                Console.WriteLine("Per-Minute Rate($) is 0.14, which is multiplied by {0} minutes of the call");
            }
        }
    }
}
