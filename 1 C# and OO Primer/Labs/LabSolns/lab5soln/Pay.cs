// calculate a person's pay for a day

using System;

class Pay
{
    public static void Main()
    {
        const int NormalRatePerHour = 10;
        const int NormalHoursPerDay = 8;
    
        int startTime;
        int finishTime;
        int hoursWorked;
        double earned;
  
        // must be a int input i.e. hour format (not including minutes)

        Console.Write("Enter the start time: ");
        startTime = Int32.Parse(Console.ReadLine());
      
        Console.Write("Enter the finish time: ");
        finishTime = Int32.Parse(Console.ReadLine());
     
        hoursWorked = ( (finishTime - startTime) / 100 ) - 1; // take off break
    
        if (hoursWorked < 0)
        {
             Console.WriteLine("Invalid time entry!");
        }
        else
        {
            if (hoursWorked > NormalHoursPerDay)                  // overtime
            {
                earned = ((NormalHoursPerDay * NormalRatePerHour) + ((hoursWorked - NormalHoursPerDay) * (NormalRatePerHour * 1.5)));
            }
            else                                                    // no overtime
            {
                earned = (hoursWorked * NormalRatePerHour);
            }

            Console.WriteLine("You earned €" + earned + " today");
        }
    }
}
