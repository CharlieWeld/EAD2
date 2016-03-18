// input &&, ||, ! and output name of logical operator

using System;

class LogicalOperators
{
   public static void Main()
   {       
        Console.Write("Enter a logical operator: ");
        string s = Console.ReadLine();
    
        if (s == "&&")
            Console.WriteLine("logical AND");
        else if (s == "||")
            Console.WriteLine("logical OR");
        else if (s == "!")
            Console.WriteLine("logical NOT");
        else
            Console.WriteLine("Error, no match!");
   }
}
