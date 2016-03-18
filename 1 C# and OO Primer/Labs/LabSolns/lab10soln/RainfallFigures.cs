// 2D array
 
using System;

class RainFallFigures
{
    public static void Main()
    {
        const int NoRegions = 2;        // Number of regions i.e rows
        const int NoMonths = 3;         // Number of months i.e. columns

        double sum;

        // create 2D array
        double[,] rain = new double[NoRegions, NoMonths];

        // read in the values
        for (int i = 0; i < NoRegions; i++)
        {
            for (int j = 0; j < NoMonths; j++)
            {
                Console.Write("What is the rainfall for month " + (j+1) + " in area " + (i+1) + "? ");
                rain[i, j] = Double.Parse(Console.ReadLine());
            }
        }

     
        // print out the values and print and display the average per month
        for (int i = 0; i < NoRegions; i++)
        {
            Console.Write("Region " + (i+1) + " rainfall:");
            sum = 0;
            for (int j = 0; j < NoMonths; j++)
            {
                Console.Write(" " + rain[i, j]);
                sum = sum + rain[i, j];
            }
            Console.WriteLine(" average: " + sum/NoMonths);
        }
    }
}
