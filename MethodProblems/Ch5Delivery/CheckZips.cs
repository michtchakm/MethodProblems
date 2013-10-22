using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch5Delivery
{
    class CheckZips
    {
        static void main(string[] args)
        {
            string input;
            int counter = 0;

            int[] zipcodes = new int[10] {18041, 18042, 18043, 18044, 18045, 18046, 18047, 18048, 18049, 18050};
            
            for(int i = 0; i < zipcodes.Length; i++)
            {
                Console.WriteLine(zipcodes[i]);
            }

            while (counter < zipcodes.Length)
            {
                Console.WriteLine(zipcodes[counter]);
                counter++;
            }
        
            Console.WriteLine("Type your zip code");
        
            input = Console.ReadLine();

            if (input != "18041" && input != "18042" && input != "18043" && input != "18044" && input != "18045" && input != "18046" && input != "18047" && input != "18048" && input != "18049" && input != "18050")
            {
                Console.WriteLine("We do not deliver there");
            }
        }
    }
}
