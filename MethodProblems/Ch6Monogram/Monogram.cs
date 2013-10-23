using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch6Monogram
{
    class Monogram
    {
        public static void DisplayMonogram(string FirstInitial, string MiddleInitial, string LastInitial)
        {
             Console.WriteLine("** {0}. {1}. {2}. **", FirstInitial, MiddleInitial, LastInitial);
        }

        public static void Main()
        {
            DisplayMonogram("T", "I", "N");
            DisplayMonogram("J", "M", "F");           
        }
    }
}
