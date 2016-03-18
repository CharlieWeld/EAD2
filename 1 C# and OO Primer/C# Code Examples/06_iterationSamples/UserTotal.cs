// while loop
// Reads in integers until 999 entered and displays total

using System;

namespace Iteration
{
    class UserTotal
    {
        private static void Main()          
        {
            int i;
            int total = 0;
            bool finished = false;                                      // not finished yet
         
            while (!finished)
            {
                Console.Write("Enter an integer: ");                    // prompt user
                i  = Int32.Parse(Console.ReadLine());                   // read in & convert
      
                if (i == 999)
                {
                    finished = true;                                    // all done
                }
                else
                {
                    total += i;                                         // update total
                }
            }
           Console.WriteLine("The total is: " + total);                 // final answer
        }
    }
}



