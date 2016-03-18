using System;

class GrassCutTime
{
   public static void Main()
   {
       const double HouseWidth = 30;
       const double HouseLength = 40; 
       const double YardWidth = 40; 
       const double YardLength = 50;  
       const double Speed = 2;
    
       double houseArea;
       double yardArea;
       double grassArea;
       double time;
    
       houseArea = HouseWidth * HouseLength;
       yardArea = YardWidth * YardLength;

       grassArea = yardArea - houseArea;

       time = (grassArea / Speed) / 60;
    
       Console.WriteLine("The length of time to cut the grass is " + time + " minutes");
   }
}