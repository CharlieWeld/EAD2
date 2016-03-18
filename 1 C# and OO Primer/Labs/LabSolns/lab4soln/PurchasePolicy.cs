// determine a purchasing policy based on the cost of an item

using System;

class PurchasePolicy
{
   public static void Main()
   {       
       
        Console.Write("Enter the cost of the item: ");
        double itemCost  = Double.Parse(Console.ReadLine());
    
        if (itemCost > 5000)
        {
            Console.WriteLine("You must tender for this item");
        }
        else
        {
            if ( (itemCost >= 500) && (itemCost <= 5000) )
            {
                Console.WriteLine("You must get 3 quotes for this item");
            }
            else
            {
                Console.WriteLine("You can go ahead and order this item");
            }
        }
   }
}
