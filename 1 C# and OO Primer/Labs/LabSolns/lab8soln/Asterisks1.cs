// A program which prints a triangular pattern of asterisks
// *
// **
// ***
// ****
// *****
 
using System;

class Asterisks1
{
    public static void Main()
    {
        const int Rows = 5;
    
        for (int i = 1; i <= Rows; i++)             // outer loop i from 1 to 5
        {
            for (int j = 1; j <= i; j++)            // inner loop j from 1 to i
            {
                Console.Write("*");
            }
        Console.WriteLine();                
        }
    }
}
