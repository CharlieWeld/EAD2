// add the numbers from 50 to 100

using System;

class Sum1
{
    public static void Main()
    {
        const int Start = 50;
        const int Finish = 100;
        
        int sum = 0;
    
        for (int i = Start; i <= Finish; i++)
        {
            sum += i;
        }
    
        Console.WriteLine("The sum of numbers from " + Start + " to " + Finish + " is: " + sum);
    }
}
