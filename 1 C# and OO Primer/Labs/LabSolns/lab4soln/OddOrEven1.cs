// a program which tests whether an integer input is odd or even

using System;

class OddOrEven1
{
   public static void Main()
   {       
        Console.Write("Enter an integer: ");
        int i  = Int32.Parse(Console.ReadLine());
    
        if ((i % 2 == 0))                   // modulus
          Console.WriteLine(i + " is even");
        else
          Console.WriteLine(i + " is odd");       
   }
}
