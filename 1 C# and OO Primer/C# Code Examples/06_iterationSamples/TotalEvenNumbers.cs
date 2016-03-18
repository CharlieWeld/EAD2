// do while
// a program totals sums the even numbers between 1 and 100

using System;

namespace Iteration*-0
{
    class TotalEvenNumbers
    {
        private static void Main()
        {
            int i = 1;
            int total = 0;
    
            do
            {
                if (i % 2 == 0)           // even ?
                {
                    total += i;
                }
                i++;                      // next number
            }
            while (i <= 100);
    
            Console.Write("The total is: " + total);
        }
    }
}



