using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Repeat 12 times
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Line " + (i + 1) + " printed");
            }

            // Repeat until user says "yes"
            bool endLoop= false;

            while (endLoop == false)
            {
                Console.WriteLine("End loop?: ");
                endLoop = Console.ReadLine().ToLower() == "yes";
            }

            // repeats from 1 to 50
            for(int i = 1; i < 50; i++)
            {
                // say if a number is odd or even
                string parity = (i % 2 == 0) ? "even" : "odd";

                Console.WriteLine($"{i} is {parity}");

                // say if a number is divisible by 3
                string divisibleThree = (i % 3 == 0) ? "divisible by 3" : "not divisible by 3";

                Console.WriteLine($"{i} is {divisibleThree}");
            }

            Console.ReadLine();

        }
    }
}
