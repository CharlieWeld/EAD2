// read in 5 floating point numbers and display the average

using System;

class Stats1
{
    public static void Main()
    {
        const int Length = 5;                          // constant
    
        double number;
        double total = 0;
        
        int i = 1;

        while (i <= Length)               // 5 numbers
        {
            Console.Write("Enter number " + i + ": ");
            number  = Double.Parse(Console.ReadLine());
            total += number; // update running total
            i++;
        }
        double average =  total / Length;
        Console.WriteLine("The average is: " + average);
    }
}

