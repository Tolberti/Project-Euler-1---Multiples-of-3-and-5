using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Problem 1: Find the sum of all the multiples of 3 or 5 below 1000.

namespace Project_Euler_1___Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; // The current number to have the divisibility of checked
            int total = 0; // The current sum of found multiples
            int remainder;
            for (number = 1; number < 1000; number++)
            {
                Math.DivRem(number, 3, out remainder); // Divide the number by 3 first, then check for a remainder.
                if (remainder == 0)
                {
                    total += number; // Number is divisible by 3, add it to the sum.
                    continue;
                }
                else // If it's not divisible by 3, check if it's divisible by 5.
                {
                    Math.DivRem(number, 3, out remainder);
                    if (remainder == 0) total += number;
                    else continue;
                }
            }
            Console.WriteLine(total.ToString()); 
            Console.ReadKey();
        }
    }
}
