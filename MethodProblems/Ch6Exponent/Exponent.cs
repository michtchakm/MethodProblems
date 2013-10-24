using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch6Exponent
{
    class Exponent
    {
       
        public static void Main()
        {
            int Number = 0;
        string input;
        Console.WriteLine("Enter an integer");
             input = Console.ReadLine();
             Number = Convert.ToInt32(input);
            SquareNumber(Number);
            CubeNumber(Number);   
        }
        
        
        public static void SquareNumber(int Number)
        {
            Console.WriteLine("{0}", Number * Number);
        }

        public static void CubeNumber(int Number)
        {
            Console.WriteLine("{0}", Number * Number * Number);
        }

    }
}
