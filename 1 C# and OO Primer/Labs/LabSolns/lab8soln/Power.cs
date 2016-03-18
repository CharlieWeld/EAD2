// raise a number to a specified power

using System;

class Power
{
    public static void Main()
    {
        int n, power, ans;

        Console.Write("Enter the number: ");
        n = Int32.Parse(Console.ReadLine());

        Console.Write("Enter the power: ");
        power = Int32.Parse(Console.ReadLine());
    
        if (power < 0)
        {
            Console.WriteLine("Invalid power");
        }
        else
        {
            if (power == 0)
            {
                ans = 1;                            // x to the power of 0 is 1
            }
            else
            {
                ans = n;
                for (int i = 1; i < power; i++)     // i = 1 to power - 1
                {
                    ans = ans * n;
                }
            }
            Console.WriteLine(n + " to the power of " + power + " is: " + ans);
        }
    }
}
