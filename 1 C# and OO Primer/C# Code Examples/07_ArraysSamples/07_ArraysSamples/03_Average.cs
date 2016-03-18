// arrays
// calculate the average of a set of doubles stored in an array

using System;

namespace Arrays
{
    class Average
    {
        private static void Main()          
        {
			//ask user how many vlues there are : this will be the size of our array of doubles ( double[] values  below)
            Console.Write("How many values are there? ");
            int numberOfValues = Int32.Parse(Console.ReadLine());

            // create an array of doubles : the size of this array will be the number the user entered
            double[] values = new double[numberOfValues];                 // array size specified by value of variable numberOfValues
            
			//Read in the values array and store
			// - Perform loop code to fill the array
			//-  Each iteration of the loop will ask the user for a number and then fill in the array with that value           
            for (int i=0; i < values.Length; i++)
            {
                Console.Write("Enter value " + (i+1) + ": ");
                values[i] = Double.Parse(Console.ReadLine());
            }

			

            double sum = 0;
            // calculate average : Loop over array again and this sime sum up each value in the array
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            Console.WriteLine("The average is: " + sum / values.Length);

        }
    }
}

