// read in a set of floating point numbers and display the average

using System;

class Stats2
{
    public static void Main()
    {
        double number;
        double total = 0;
        int size = 0;                                    // number of numbers entered
        
        do
        {
            Console.Write("Enter a number, 0 to quit: ");
            number  = Double.Parse(Console.ReadLine());
            if (number != 0)
            {
                total += number;
                size++;
            }
        }
        while(number != 0);
    
        if (size !=0)                                   // only do calculations if some numbers were entered
        {
            double average =  (total / size);           // calculate average
            Console.WriteLine("The average is: " + average);
        }
    }
}
