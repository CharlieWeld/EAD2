// This program computes the number of hours, minutes, and seconds that are
// equivalent to the number of seconds input in the program

using System;

class TimeCalc1
{
   public static void Main()
   {       
        const int SecondsPerHour = 3600;
        const int SecondsPerMinute = 60;
       
        int seconds, minutes, hours;
        
        Console.Write("Enter the number of seconds: ");
        seconds = Int32.Parse(Console.ReadLine());

        hours = seconds / SecondsPerHour;
        seconds = seconds % SecondsPerHour; 
        minutes = seconds / SecondsPerMinute;
        seconds = seconds % SecondsPerMinute; 
        
        Console.WriteLine("Hours: " + hours);
        Console.WriteLine("Minutes: " + minutes);
        Console.WriteLine("Seconds: " + seconds);
   }
}

