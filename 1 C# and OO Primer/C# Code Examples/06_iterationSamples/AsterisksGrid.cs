// nested for loop
// a program which uses a nested for loop to print out a 5 by 5 grid of asterisks
//
// The inner loop ploops 5 time
// The outer loop lopps 5 times   
// Therefore we will see (5 * 5) = 25
// This is because for each outer loop, the inner loop lopps 5 times
// Step through code to see this!

using System;

namespace Iteration
{
    class AsterisksGrid
    {
        private static void Main()          
        {
            for (int i=1; i<=5; i++)                // outer loop i from 1 to 5
            {
                for (int j=1; j<=5; j++)            // inner loop j from 1 to 5 (ie inner j will happen 5 times  for every looping of outer i loop)
                {
                    Console.Write("*");
                }
                Console.WriteLine();                // carriage return
            }
        }
    }
}



