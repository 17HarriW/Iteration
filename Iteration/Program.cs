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
        }
    }
}
