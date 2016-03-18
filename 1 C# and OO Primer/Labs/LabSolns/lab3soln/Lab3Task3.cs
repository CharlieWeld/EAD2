using System;

class TimeCalc1
{
   public static void Main()
   {       
        const int SecondsPerHour = 3600;
        const int SecondsPerMinute = 60;

        int hours;
        int minutes;
        int seconds;
        int totalSeconds;
      
        Console.Write("Enter the number of hours: ");   
        hours = Int32.Parse(Console.ReadLine());  
        Console.Write("Enter the number of minutes: ");   
        minutes = Int32.Parse(Console.ReadLine()); 
        Console.Write("Enter the number of seconds: ");
        seconds = Int32.Parse(Console.ReadLine());

        totalSeconds = hours * SecondsPerHour + minutes * SecondsPerMinute + seconds;

        Console.WriteLine("Total seconds: " + totalSeconds);
   }
}

