// Store and process rainfall figures for a week
 
using System;

class Rainfall
{
    public static void Main()
    {
        const int DaysInWeek = 7;

        double[] rainfall = new double[DaysInWeek];
        double totalRainfall = 0;
        double averageRainfall;
       
        // read in the figures
        for (int i=0; i < rainfall.Length; i++)
        { 
            Console.Write("Enter the rainfall for day " + (i+1) + ": ");
            rainfall[i] = Double.Parse(Console.ReadLine());
            totalRainfall += rainfall[i]; 
        }

        // output the total
        Console.WriteLine("The total rainfall for the week was: " + totalRainfall);
 
        // calculate the average rainfall
        if (rainfall.Length != 0)
        {
            averageRainfall = totalRainfall / rainfall.Length;
        }
        else
        {
            averageRainfall = 0;
        }
  
        // output the average
        Console.WriteLine("The average rainfall for the week was: " + averageRainfall);
 
 
        // output the days when rainfall exceeded 3.5cm
        for (int i=0; i < rainfall.Length; i++)
        { 
            if (rainfall[i] > 3.5)
            {
                Console.Write("The rain on day " + (i+1) + " was > 3.5cm"); 
                Console.WriteLine(", it was "+ rainfall[i] + "cm" );
            }
        } 
    }
}
