// read in engine size and output motor tax cost

using System;

class MotorTax
{
   public static void Main()
   {       
        int engineSize;
        int cost;

        Console.Write("Enter the engine size (CC): ");
        engineSize = Int32.Parse(Console.ReadLine());
      
        // calc cost
    
        if (engineSize <= 1000)
            cost = 150;
        else if (engineSize <= 1200)
            cost = 175;
        else if (engineSize <= 1400)
            cost = 200;
        else if (engineSize <= 1600)
            cost = 250;
        else if (engineSize <= 1800)
            cost = 300; 
        else if (engineSize <= 2000)
            cost = 350;
        else
            cost = 500;
    
        Console.WriteLine("The cost is €" + cost);       
   }
}
