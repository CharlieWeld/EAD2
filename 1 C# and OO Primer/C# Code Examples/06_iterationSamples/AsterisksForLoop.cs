// for loop
// a program which uses a for loop to print out 25 asterisks

using System;						

/*
This program loops 25 and prints out *
Therefore 25 *'s are printed to the screen
*/


namespace Iteration                     
{
    class AsterisksForLoop          
    {
        private static void Main()          
        {
            for (int i=1; i <=25; i++)    // loop i from 1 to 25
            {													
              Console.Write("*");
            }                            //end of loop code
			
			/* notice the 'i<= 25' above
			   That mean it will check it will loop form 1 to 25 inclusive
			   A lot of mistakes are made because you type 'i<25' or vise-versa
			   Just check that the lopp is looping the correct amout of times#
			 */
        }
    }
} 
	


