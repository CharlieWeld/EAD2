// report the number of days in a requested month, assume no leap year

using System;

class DaysinMonth
{
   public static void Main()
   {
        Console.Write("Enter the  month#: ");
        int month  = Int32.Parse(Console.ReadLine());

        switch (month)
        {
            case 1: case 3: case 5: case 7: case 8: case 10: case 12:
            {
                Console.WriteLine("31 days");
                break;
            }
            case 9: case 4: case 6: case 11:             // Sept, April, June, Nov
            {
                Console.WriteLine("30 days");
                break;
            }
            case 2:                                     // Feb
            {
                Console.WriteLine("28 days");
                break;
            }
            default:
            {
                Console.WriteLine("Error: Invalid month#");
                break;
            }
        }
   }
}
