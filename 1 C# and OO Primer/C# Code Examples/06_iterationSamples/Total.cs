// while loop
// a program which totals the numbers between 1 and 100 and prints the answer

using System;

namespace Iteration
{
    class Total
    {
        private static void Main()          
        {
            int total = 0;

            int i = 1;
            while (i <= 100)
            {
                total += i;
                i++;
            }
           Console.WriteLine("The answer is: " + total);
        }
    }
}



