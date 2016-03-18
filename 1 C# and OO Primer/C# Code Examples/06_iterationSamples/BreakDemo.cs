// a program which illustrates the use of the break statement 

using System;

namespace Iteration
{
    class BreakDemo
    {
        private static void Main()          
        {
            const int BreakPoint = 5;
    
            for (int i=0; i < 100; i++)        // for loop
            {
                Console.WriteLine(i);
                if (i == BreakPoint)
                    break;                     // break out of loop
											   // i.e. looping will done 5 times (until i == breakpoint) and then looping will stop
            }
            Console.WriteLine("After loop");
        }
    }
}
