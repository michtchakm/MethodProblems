using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch3Furniture
{
    class Furniture
    {
        static void main(string[] args)
        {
            string input;

            Console.WriteLine("Type P for Pine, O for Oak, M for Mahogany");
            input = Console.ReadLine();

            if (input == "P") 
            {
                Console.WriteLine("Price is $100");
            }

            if (input == "O")
            {
                Console.WriteLine("Price is $225");
            }

            if (input == "M")
            {
                Console.WriteLine("Price is $310");
            }

            if (input != "P" && input != "O" && input != "M")
            {
                Console.WriteLine("Price is $0");
            } 
        }
    }
}
