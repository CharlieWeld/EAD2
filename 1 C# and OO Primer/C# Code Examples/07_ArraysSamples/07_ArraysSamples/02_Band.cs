// foreach loop

using System;

namespace Arrays
{
    class Band
    {
        private static void Main()          
        {
            String[] theBeatles = {"John", "Paul", "George", "Ringo"};

            // use a foreach loop to print members of the band
            foreach (String member in theBeatles)
            {
                Console.Write(member + " ");
            }
            // foreach limitations:
            // can't determine index position, cannot change array contents, forward direction only

            Console.WriteLine();

            // create a new reference to the same array
            String[] theBootlegBeatles = theBeatles;

            foreach (var member in theBootlegBeatles)
            {
                Console.Write(member + " ");
            }

        }
    }
}

