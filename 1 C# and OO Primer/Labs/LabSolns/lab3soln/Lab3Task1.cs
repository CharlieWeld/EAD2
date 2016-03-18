using System;

class Schedule
{
    public static void Main()
   {       
        const int Dress = 45;
        const int Eat = 30;
        const int Drive = 30;
        const int Class = 60;
        
        int totalmins = 0;
        totalmins = Dress + 3 * Eat + 2 * Drive + 4 * Class;
 
        Console.Write("You spend " + totalmins / 60);
        Console.Write(" hours and " + totalmins % 60 );
        Console.WriteLine(" minutes a day on scheduled activities");
   }
}

/*
(a) You spend 7 hours and 15 minutes a day on scheduled activities
(b) Identifiers = Schedule, Dress, Eat, Drive, Class, totalmins
(c) Named Constants = Dress, Eat, Drive, Class
(d) The purpose of the % is to calculate the remainder after performing a division operation
*/
