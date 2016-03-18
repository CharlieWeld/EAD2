// arrays
// store and print the lotto numbers for a draw

using System;

namespace Arrays
{
    class LottoNumbers
    {
        private static void Main()          
        {
            int[] lottoNumbers;                         // lottoNumbers is an array of ints
            
            lottoNumbers = new int[7];                  // create an array to store 7 numbers (default all 0), indexed 0 .. 6

            // store values, better than 7 separate ints
            lottoNumbers[0] = 6;
            lottoNumbers[1] = 21;
            lottoNumbers[2] = 14;
            lottoNumbers[3] = 1;
            lottoNumbers[4] = 2;
            lottoNumbers[5] = 18;
            lottoNumbers[6] = 20;
			
			//can initialise array as follows
		    // int[] lottoNumbers = new int[7] { 6, 21, 14, 1, 2, 18, 20 };

            // print off the values
            Console.Write(lottoNumbers[0] + " ");
            Console.Write(lottoNumbers[1] + " ");
            Console.Write(lottoNumbers[2] + " ");
            Console.Write(lottoNumbers[3] + " ");
            Console.Write(lottoNumbers[4] + " ");
            Console.Write(lottoNumbers[5] + " ");
            Console.Write(lottoNumbers[6] + " ");

            Console.WriteLine();
            // print off the values in a loop - better
            for (int i = 0; i < lottoNumbers.Length; i++)
            {
                Console.Write(lottoNumbers[i] + " ");
            }

            // trying to read or write past the end of the array throws an excecption e.g. lottoNumbers[7]
        }
    }
}



