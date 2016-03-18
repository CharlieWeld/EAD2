// calculate the area of a circle

using System;

class CircleArea
{
   public static void Main()
   {       
        double radius;
        double area;
        
        Console.Write("Enter the radius: ");
        radius  = Double.Parse(Console.ReadLine());
     
        if (radius < 0)
        {
            Console.WriteLine("Error - negative radius!");
        }
        else
        {
            area = Math.PI * (radius * radius);                 // System.Math.PI is a const double
            Console.WriteLine(area);
        }
        
   }
}
