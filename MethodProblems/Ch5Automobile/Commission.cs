using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch5Automobile
{
    class Commission
    {
        static void main(string[] args)
        {
            string input;
            double price;

            Console.WriteLine("Type the price of the car");
            input = Console.ReadLine();
            price = Convert.ToDouble(input);

            if (price <= 15000)
            {
                Console.WriteLine("You receive 5%");
            }

            if (price > 15000 && price <= 24000)
            {
                Console.WriteLine("You receive 7%");
            }

            if (price > 24000)
            {
                Console.WriteLine("You receive 10%");
            }
        }
    }
}
