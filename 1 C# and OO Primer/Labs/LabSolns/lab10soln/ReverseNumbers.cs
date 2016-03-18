// Read numbers into an array, total them, print them in reverse
 
using System;

class ReverseNumbers
{
    public static void Main()
    {
        double[] numbers = new double[5];
        double sum = 0;

        // read in the numbers, accumulate sum
        for (int i=0; i < numbers.Length; i++)
        { 
            Console.Write("Enter number " + (i+1) + ": "); 
            numbers[i] = Double.Parse(Console.ReadLine());
            sum += numbers[i]; 
        } 
 
        Console.WriteLine("The sum of the numbers is: " + sum);
  
 
        // output the numbers in forward order
        foreach(double num in numbers)
        { 
            Console.Write(num + " ");
        }

        Console.WriteLine();

        // output the numbers in reverse order
        for (int i = numbers.Length -1; i >= 0; i--)
        { 
            Console.Write(numbers[i] + " ");
        }
    }
}
